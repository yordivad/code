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

    [TestClass]
    [Feature(@"Adding Template and Emitters")]
    public class DotFeature : Feature
    {
        [TestMethod]
        public void Emiter()
        {
            this.RunScenario(given => this.SetAGraph(), when => this.GraphRender());
        }

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

        private void Binding()
        {
            var template = this.Scenario.Get<Template>("template");
            var data = this.Scenario.Get<List<(int id, string name, string lastname)>>("data");
            template.AddMany("items.{lastName, firstName, id}", data[0].lastname, data[0].name, data[0].id);
            template.AddMany("items.{lastName, firstName, id}", data[1].lastname, data[1].name, data[1].id);
        }

        private void DefineData()
        {
            this.Scenario["data"] =
                new List<(int id, string name, string lastname)> { (1, "Roy", "Gonzalez"), (2, "Max", "Gonzalez") };
        }

        private void DefineTheTemplate()
        {
            this.Scenario["template"] = new Template("<items:{it|<it.id>: <it.lastName>, <it.firstName>\n}>");
        }

        private void GraphRender()
        {
            var graph = this.Scenario.Get<Graph>("graph");
            var x = graph.Render();
            Console.WriteLine(x);
        }

        private void Render()
        {
            var template = this.Scenario.Get<Template>("template");
            var info = template.Render();
        }

        private void SetAGraph()
        {
            var graph = Emit.Graph("mygraph")
                .AddStatement(Emit.AttributeStatement(AttributeKind.Graph).Property("color", "red"))
                .AddStatement(Emit.AttributeStatement(AttributeKind.Edge));
            this.Scenario["graph"] = graph;
        }
    }
}