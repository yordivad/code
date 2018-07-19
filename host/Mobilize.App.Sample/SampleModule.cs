// ***********************************************************************
// <copyright file="SampleModule.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample
{
    using Microsoft.Practices.Unity;

    using Mobilize.App.Sample.State;
    using Mobilize.App.Sample.View;

    using Prism.Modularity;
    using Prism.Regions;
    using Prism.Unity;

    /// <summary>
    /// Class SampleModule.
    /// </summary>
    [Module(ModuleName = "Sample")]
    public class SampleModule : IModule
    {
        /// <summary>
        /// The container
        /// </summary>
        private readonly IUnityContainer container;

        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleModule" /> class.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="regionManager">The region manager.</param>
        public SampleModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.container = container;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            
            this.container.RegisterType<ISampleStore, SampleStore>();
            this.container.RegisterTypeForNavigation<User>("Content");
            this.regionManager.RegisterViewWithRegion("Content", typeof(User));
        }
    }
}