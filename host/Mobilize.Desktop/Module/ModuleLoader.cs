// ***********************************************************************
// <copyright file="ModuleLoader.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Desktop.Module
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
        /// Creates the module information.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The ModuleInfo.</returns>
        private static ModuleInfo CreateModuleInfo(Type type)
        {
            var dependsOn = ModuleDependencies(type);
            var moduleInfo = ModuleInfo(type);
            moduleInfo.DependsOn.AddRange(dependsOn);
            return moduleInfo;
        }

        /// <summary>
        /// Gets the not  loaded module .
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="moduleType">Type of the i module.</param>
        /// <returns>The modules</returns>
        private static IEnumerable<ModuleInfo> GetNotLoadedModule(DirectoryInfo directory, Type moduleType) =>
            LoadedAssemblies(directory).SelectMany(
                file => Assembly.ReflectionOnlyLoadFrom(file.FullName).GetExportedTypes()
                    .Where(moduleType.IsAssignableFrom).Where(t => t != moduleType).Where(t => !t.IsAbstract)
                    .Select(type => CreateModuleInfo(type)));

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
        /// Modules the configuration.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if  It is a demand, <c>false</c> otherwise.</returns>
        private static (string moduleName, bool onDemand) ModuleConfiguration(Type type)
        {
            var moduleName = type.Name;
            var onDemand = false;
            var moduleAttribute = CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(
                cad => cad.Constructor.DeclaringType.FullName == typeof(ModuleAttribute).FullName);

            if (moduleAttribute == null)
            {
                return (moduleName, onDemand);
            }

            foreach (var argument in moduleAttribute.NamedArguments)
            {
                moduleName = ModuleName(argument, moduleName);
                onDemand = OnDemand(argument);
            }

            return (moduleName, onDemand);
        }

        /// <summary>
        /// Modules the dependencies.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The list of dependencies;.</returns>
        private static List<string> ModuleDependencies(Type type)
        {
            var moduleDependencyAttributes = CustomAttributeData.GetCustomAttributes(type).Where(
                cad => cad.Constructor.DeclaringType.FullName == typeof(ModuleDependencyAttribute).FullName);

            var dependsOn = moduleDependencyAttributes.Select(cad => (string)cad.ConstructorArguments[0].Value)
                .ToList();
            return dependsOn;
        }

        /// <summary>
        /// Modules the information.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>the ModuleInfo.</returns>
        private static ModuleInfo ModuleInfo(Type type)
        {
            var configuration = ModuleConfiguration(type);

            return new ModuleInfo(configuration.moduleName, type.AssemblyQualifiedName)
                       {
                           InitializationMode =
                               configuration.onDemand
                                   ? InitializationMode
                                       .OnDemand
                                   : InitializationMode
                                       .WhenAvailable,
                           Ref = type.Assembly
                               .EscapedCodeBase
                       };
        }

        /// <summary>
        /// Modules the name.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="default">The default.</param>
        /// <returns>The method name</returns>
        private static string ModuleName(CustomAttributeNamedArgument argument, string @default)
        {
            var argumentName = argument.MemberInfo.Name;
            if (argumentName == "ModuleName")
            {
                return (string)argument.TypedValue.Value;
            }

            return @default;
        }

        /// <summary>
        /// Called when [demand].
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <returns><c>true</c> if  the attribute is by demand, <c>false</c> otherwise.</returns>
        private static bool OnDemand(CustomAttributeNamedArgument argument)
        {
            var argumentName = argument.MemberInfo.Name;
            if (argumentName == "OnDemand")
            {
                return (bool)argument.TypedValue.Value;
            }

            if (argumentName == "StartupLoaded")
            {
                return !(bool)argument.TypedValue.Value;
            }

            return false;
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