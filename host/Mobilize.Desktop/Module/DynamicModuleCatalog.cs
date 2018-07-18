// ***********************************************************************
// <copyright file="DynamicModuleCatalog.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Desktop
{
    using System;
    using System.Collections.ObjectModel;
    using System.IO;

    using Mobilize.Desktop.Module;

    using Prism.Modularity;

    /// <summary>
    /// Class DynamicModuleCatalog.
    /// </summary>
    /// <seealso cref="Prism.Modularity.ModuleCatalog" />
    public class DynamicModuleCatalog : ModuleCatalog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicModuleCatalog"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public DynamicModuleCatalog(string path)
        {
            var watcher = new FileSystemWatcher(path, "*.dll");
            watcher.Created += this.ModuleWatcher;
            watcher.EnableRaisingEvents = true;
            this.LoadModule(path);
        }

        /// <summary>
        /// Loads the module.
        /// </summary>
        /// <param name="path">The path.</param>
        private void LoadModule(string path)
        {
            this.Items.AddRange(AppDomain.CurrentDomain.GetModules(path));
        }

        /// <summary>
        /// Modules the watcher.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="FileSystemEventArgs"/> instance containing the event data.</param>
        private void ModuleWatcher(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created)
            {
                this.LoadModule(e.FullPath);
            }
        }
    }
}