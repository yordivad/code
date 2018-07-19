// ***********************************************************************
// <copyright file="DomainExtension.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Desktop.Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Security.Policy;

    using Prism.Modularity;

    /// <summary>
    /// Class DomainExtension.
    /// </summary>
    public static class DomainExtension
    {
        /// <summary>
        /// Clones the specified domain.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <returns>the clone.</returns>
        public static AppDomain Clone(this AppDomain domain) =>
            AppDomain.CreateDomain("DiscoveryRegion", new Evidence(domain.Evidence), domain.SetupInformation);

        /// <summary>
        /// Gets the modules.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <param name="path">The path.</param>
        /// <returns>the modules..</returns>
        public static IEnumerable<ModuleInfo> GetModules(this AppDomain domain, string path)
        {
            var clone = domain.Clone();
            try
            {
                return ModuleLoader(domain, clone).GetModuleInfos(path);
            }
            finally
            {
                AppDomain.Unload(clone);
            }
        }

        /// <summary>
        /// Locals the assemblies.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <returns>the list of local assemblies</returns>
        private static IEnumerable<Assembly> LocalAssemblies(this AppDomain domain) =>
            from Assembly assembly in domain.GetAssemblies()
            where !(assembly is System.Reflection.Emit.AssemblyBuilder)
                  && assembly.GetType().FullName != "System.Reflection.Emit.InternalAssemblyBuilder"
                  && !string.IsNullOrEmpty(assembly.Location)
            select assembly;

        /// <summary>
        /// Modules the loader.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <param name="clone">The clone.</param>
        /// <returns>The ModuleLoader.</returns>
        private static ModuleLoader ModuleLoader(AppDomain domain, AppDomain clone)
        {
            var assemblies = domain.LocalAssemblies();
            var type = typeof(ModuleLoader);
            var loader = (ModuleLoader)clone.CreateInstanceFromAndUnwrap(type.Assembly.Location, type.FullName);
            loader.LoadAssemblies(assemblies.Select(c => c.Location).ToArray());
            return loader;
        }
    }
}