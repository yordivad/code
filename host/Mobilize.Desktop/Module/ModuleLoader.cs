// ***********************************************************************
// <copyright file="ModuleLoader.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Desktop
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Prism.Modularity;

    /// <summary>
    /// Class ModuleLoader.
    /// </summary>
    /// <seealso cref="System.MarshalByRefObject" />
    public class ModuleLoader : MarshalByRefObject
    {
        /// <summary>
        /// Gets the module infos.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>the ModuleInfo[].</returns>
        internal ModuleInfo[] GetModuleInfos(string path)
        {
            var directory = new DirectoryInfo(path);

            AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve +=
                (sender, args) => OnReflectionOnlyResolve(args, directory);

            var moduleReflectionOnlyAssembly = AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies()
                .First(asm => asm.FullName == typeof(IModule).Assembly.FullName);
            var moduleType = moduleReflectionOnlyAssembly.GetType(typeof(IModule).FullName);

            var modules = GetNotLoadedModule(directory, moduleType);

            return modules.ToArray();
        }

        /// <summary>
        /// Loads the assemblies.
        /// </summary>
        /// <param name="assemblies">The assemblies.</param>
        public void LoadAssemblies(string[] assemblies)
        {
            foreach (var assemblyPath in assemblies)
            {
                try
                {
                    Assembly.ReflectionOnlyLoadFrom(assemblyPath);
                }
                catch (FileNotFoundException)
                {
                    // Continue loading assemblies even if an assembly can not be loaded in the new AppDomain
                }
            }
        }

        /// <summary>
        /// Creates the module information.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The ModuleInfo.</returns>
        private static ModuleInfo CreateModuleInfo(Type type)
        {
            var moduleName = type.Name;
            var onDemand = false;
            var moduleAttribute = CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(
                cad => cad.Constructor.DeclaringType.FullName == typeof(ModuleAttribute).FullName);

            if (moduleAttribute != null)
            {
                foreach (var argument in moduleAttribute.NamedArguments)
                {
                    var argumentName = argument.MemberInfo.Name;
                    switch (argumentName)
                    {
                        case "ModuleName":
                            moduleName = (string)argument.TypedValue.Value;
                            break;

                        case "OnDemand":
                            onDemand = (bool)argument.TypedValue.Value;
                            break;

                        case "StartupLoaded":
                            onDemand = !(bool)argument.TypedValue.Value;
                            break;
                    }
                }
            }

            var moduleDependencyAttributes = CustomAttributeData.GetCustomAttributes(type).Where(
                cad => cad.Constructor.DeclaringType.FullName == typeof(ModuleDependencyAttribute).FullName);

            var dependsOn = moduleDependencyAttributes.Select(cad => (string)cad.ConstructorArguments[0].Value)
                .ToList();

            var moduleInfo = new ModuleInfo(moduleName, type.AssemblyQualifiedName)
                                 {
                                     InitializationMode =
                                         onDemand
                                             ? InitializationMode
                                                 .OnDemand
                                             : InitializationMode
                                                 .WhenAvailable,
                                     Ref = type.Assembly
                                         .EscapedCodeBase,
                                 };
            moduleInfo.DependsOn.AddRange(dependsOn);
            return moduleInfo;
        }

        /// <summary>
        /// Gets the not  loaded module .
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="moduleType">Type of the i module.</param>
        /// <returns>The modules</returns>
        private static IEnumerable<ModuleInfo> GetNotLoadedModule(DirectoryInfo directory, Type moduleType)
        {
            var validAssemblies = LoadedAssemblies(directory);
            

            return validAssemblies.SelectMany(
                file => Assembly.ReflectionOnlyLoadFrom(file.FullName).GetExportedTypes()
                    .Where(moduleType.IsAssignableFrom).Where(t => t != moduleType).Where(t => !t.IsAbstract)
                    .Select(type => CreateModuleInfo(type)));
        }

        /// <summary>
        /// Loaded  assemblies.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <returns>The files info.</returns>
        private static IEnumerable<FileInfo> LoadedAssemblies(DirectoryInfo directory)
        {
            var validAssemblies = new List<FileInfo>();

            foreach (var fileInfo in directory.GetFiles("*.dll").Where(
                file => AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().FirstOrDefault(
                            assembly => string.Compare(
                                            Path.GetFileName(assembly.Location),
                                            file.Name,
                                            StringComparison.OrdinalIgnoreCase) == 0) == null))
            {
                try
                {
                    Assembly.ReflectionOnlyLoadFrom(fileInfo.FullName);
                    validAssemblies.Add(fileInfo);
                }
                catch (BadImageFormatException)
                {
                    // skip non-.NET Dlls
                }
            }

            return validAssemblies;
        }

        /// <summary>
        /// Called when [reflection only resolve].
        /// </summary>
        /// <param name="args">The <see cref="ResolveEventArgs"/> instance containing the event data.</param>
        /// <param name="directory">The directory.</param>
        /// <returns>The Assembly.</returns>
        private static Assembly OnReflectionOnlyResolve(ResolveEventArgs args, DirectoryInfo directory)
        {
            var loadedAssembly = AppDomain.CurrentDomain.ReflectionOnlyGetAssemblies().FirstOrDefault(
                asm => string.Equals(asm.FullName, args.Name, StringComparison.OrdinalIgnoreCase));
            if (loadedAssembly != null)
            {
                return loadedAssembly;
            }

            var assemblyName = new AssemblyName(args.Name);
            var dependentAssemblyFilename = Path.Combine(directory.FullName, assemblyName.Name + ".dll");
            return File.Exists(dependentAssemblyFilename)
                       ? Assembly.ReflectionOnlyLoadFrom(dependentAssemblyFilename)
                       : Assembly.ReflectionOnlyLoad(args.Name);
        }
    }
}