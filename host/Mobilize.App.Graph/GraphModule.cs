// ***********************************************************************
// <copyright file="GraphModule.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Graph
{
    using Prism.Modularity;
    using Prism.Regions;

    /// <summary>
    /// Class GraphModule.
    /// </summary>
    /// <seealso cref="Prism.Modularity.IModule" />
    [Module(ModuleName = "Graph")]
    public class GraphModule : IModule
    {
        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphModule"/> class.
        /// </summary>
        /// <param name="regionManager">The region manager.</param>
        public GraphModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        /// <summary>
        /// Notifies the module that it has be initialized.
        /// </summary>
        public void Initialize()
        {
            this.regionManager.RegisterViewWithRegion("MainRegion", typeof(GraphView));
        }
    }
}