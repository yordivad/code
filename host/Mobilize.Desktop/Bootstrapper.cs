// ***********************************************************************
// <copyright file="Bootstrapper.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Desktop
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Windows;

    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;

    using Mobilize.Desktop.Module;

    using Prism.Modularity;
    using Prism.Mvvm;
    using Prism.Unity;

    /// <summary>
    /// Class Bootstrapper.
    /// </summary>
    /// <seealso cref="Prism.Unity.UnityBootstrapper" />
    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates the <see cref="T:Prism.Modularity.IModuleCatalog" /> used by Prism.
        /// </summary>
        /// <returns>the ModuleCatalog.</returns>
        /// <remarks>The base implementation returns a new ModuleCatalog.</remarks>
        protected override IModuleCatalog CreateModuleCatalog() => new DynamicModuleCatalog(@"modules\net472");

        /// <summary>
        /// Creates the shell or main window of the application.
        /// </summary>
        /// <returns>The shell of the application.</returns>
        /// <remarks>If the returned instance is a <see cref="T:System.Windows.DependencyObject" />, the
        /// <see cref="T:Prism.Bootstrapper" /> will attach the default <see cref="T:Prism.Regions.IRegionManager" /> of
        /// the application in its <see cref="F:Prism.Regions.RegionManager.RegionManagerProperty" /> attached property
        /// in order to be able to add regions by using the <see cref="F:Prism.Regions.RegionManager.RegionNameProperty" />
        /// attached property from XAML.</remarks>
        protected override DependencyObject CreateShell() => ServiceLocator.Current.GetInstance<Shell>();

        /// <summary>
        /// Initializes the shell.
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow?.Show();
        }

        /// <summary>
        /// Configures the <see cref="T:Prism.Mvvm.ViewModelLocator" /> used by Prism.
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(
                (viewType) =>
                    {
                        var viewName = viewType.FullName;
                        var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                        var viewModelName = string.Format(
                            CultureInfo.InvariantCulture,
                            "{0}ViewModel, {1}",
                            viewName.Replace("View", "ViewModels"),
                            viewAssemblyName);
                        return Type.GetType(viewModelName);
                    });

            ViewModelLocationProvider.SetDefaultViewModelFactory(type => this.Container.Resolve(type));
        }
    }
}