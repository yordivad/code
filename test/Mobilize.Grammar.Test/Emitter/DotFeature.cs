// ***********************************************************************
// <copyright file="DotFeature.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Test.Emitter
{
    using System;
    using System.Collections.Generic;

    using Antlr4.StringTemplate;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Mobilize.Grammar.Emitter.Dot;
    using Mobilize.Grammar.Emitter.Dot.Model;
    using Mobilize.Quality.Core;
    using Mobilize.Quality.Core.Annotations;

    /// <summary>
    /// Class DotFeature.
    /// </summary>
    /// <seealso cref="Mobilize.Quality.Core.Feature" />
    [TestClass]
    [Feature(@"Adding Template and Emitters")]
    public class DotFeature : Feature
    {
        /// <summary>
        /// Emitter this instance.
        /// </summary>
        [TestMethod]
        public void Emitter()
        {
            this.RunScenario(given => this.SetAGraph(), when => this.GraphRender());
        }

        /// <summary>
        /// Templates this instance.
        /// </summary>
        [TestMethod]
        [Scenario(@"Templates")]
        public void Template()
        {
            this.RunScenario(
                given => this.DefineTheTemplate(),
                and => this.DefineData(),
                when => this.Binding(),
                and => this.Render());
        }

        /// <summary>
        /// Bindings this instance.
        /// </summary>
        private void Binding()
        {
            var template = this.Scenario.Get<Template>("template");
            var data = this.Scenario.Get<List<(int id, string name, string lastname)>>("data");
            template.AddMany("items.{lastName, firstName, id}", data[0].lastname, data[0].name, data[0].id);
            template.AddMany("items.{lastName, firstName, id}", data[1].lastname, data[1].name, data[1].id);
        }

        /// <summary>
        /// Defines the data.
        /// </summary>
        private void DefineData()
        {
            this.Scenario["data"] =
                new List<(int id, string name, string lastname)> { (1, "Roy", "Gonzalez"), (2, "Max", "Gonzalez") };
        }

        /// <summary>
        /// Defines the template.
        /// </summary>
        private void DefineTheTemplate()
        {
            this.Scenario["template"] = new Template("<items:{it|<it.id>: <it.lastName>, <it.firstName>\n}>");
        }

        /// <summary>
        /// Graphes the render.
        /// </summary>
        private void GraphRender()
        {
            var graph = this.Scenario.Get<Graph>("graph");
            var x = graph.Render();
            Console.WriteLine(x);
        }

        /// <summary>
        /// Renders this instance.
        /// </summary>
        private void Render()
        {
            var template = this.Scenario.Get<Template>("template");
            var info = template.Render();
        }

        /// <summary>
        /// Sets a graph.
        /// </summary>
        private void SetAGraph()
        {
            var graph = Emit.Graph("mygraph")
                .AddStatement(Emit.AttributeStatement(AttributeKind.Graph).Property("color", "red"))
                .AddStatement(Emit.AttributeStatement(AttributeKind.Edge));
            this.Scenario["graph"] = graph;
        }
    }
}