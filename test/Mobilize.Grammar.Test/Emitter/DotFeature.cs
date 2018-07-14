using System;
using System.Collections.Generic;
using Antlr4.StringTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobilize.Grammar.Emitter.Dot;
using Mobilize.Grammar.Emitter.Dot.Model;
using Mobilize.Quality.Core;
using Mobilize.Quality.Core.Annotations;

namespace Mobilize.Grammar.Test.Emitter
{
    [TestClass]
    [Feature(@"Adding Template and Emitters")]
    public class DotFeature : Feature
    {
        [TestMethod]
        [Scenario(@"Templates")]
        public void Template()
        {
            RunScenario(given => DefineTheTemplate(), and => DefineData(), when => Binding(), and => Render());
        }

        [TestMethod]
        public void Emiter()
        {
            RunScenario(given => SetAGraph(), when => GraphRender());
        }

        private void GraphRender()
        {
            var graph = Scenario.Get<Grammar.Emitter.Dot.Model.Graph>("graph");
            var x = graph.Render();
            Console.WriteLine(x);
        }

        private void SetAGraph()
        {
            var graph = Emit.Graph("mygraph")
                .AddStatement(Emit.AttributeStatement(AttributeKind.Graph).Property("color", "red"))
                .AddStatement(Emit.AttributeStatement(AttributeKind.Edge));
            Scenario["graph"] = graph;
        }

        private void Render()
        {
            var template = Scenario.Get<Template>("template");
            var info = template.Render();
        }

        private void Binding()
        {
            var template = Scenario.Get<Template>("template");
            var data = Scenario.Get<List<(int id, string name, string lastname)>>("data");
            template.AddMany("items.{lastName, firstName, id}", data[0].lastname, data[0].name, data[0].id);
            template.AddMany("items.{lastName, firstName, id}", data[1].lastname, data[1].name, data[1].id);
        }

        private void DefineData()
        {
            Scenario["data"] = new List<(int id, string name, string lastname)>
            {
                (1, "Roy", "Gonzalez"),
                (2, "Max", "Gonzalez")
            };
        }

        private void DefineTheTemplate()
        {
            Scenario["template"] = new Template("<items:{it|<it.id>: <it.lastName>, <it.firstName>\n}>");
        }
    }
}