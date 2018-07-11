// ***********************************************************************
// <copyright file="GraphFeature.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Test.Graph
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Mobilize.Grammar.Graph;
    using Mobilize.Quality.Core;
    using Mobilize.Quality.Core.Annotations;

    /// <summary>
    /// Class GraphFeature.
    /// </summary>
    /// <seealso cref="Mobilize.Quality.Core.Feature" />
    [TestClass]
    [Feature(@"The creation of graph")]
    public class GraphFeature : Feature
    {
        /// <summary>
        /// Generics the graph.
        /// </summary>
        [Scenario(@"")]
        [TestMethod]
        public void GenericGraph()
        {
            this.RunScenario(when=> this.CreateGraph());
        }

        /// <summary>
        /// Creates the graph.
        /// </summary>
        private void CreateGraph()
        {
            

        }
    }
}