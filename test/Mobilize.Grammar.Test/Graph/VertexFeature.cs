
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobilize.Grammar.Graph.Generic;
using Mobilize.Quality.Core;
using Mobilize.Quality.Core.Annotations;

namespace Mobilize.Grammar.Test.Graph
{
  
    [Feature(@"Vertex Feature")]
    [TestClass]
    public class VertexFeature:Feature
    {
        [Scenario(@"Unique")]
        public void Unique()
        {
            this.RunScenario(given => this.SetVertex(), and => this.SetOtherVertex(), when => this.Compare(), then => this.CompareIs(true));
        }

        private void CompareIs(bool expected)
        {
            this.Scenario.Get<bool>("compare").Should().Be(expected);
        }

        private void Compare()
        {
            var vertex1 = this.Scenario.Get<Vertex<int>>("vertex1");
            var vertex2 = this.Scenario.Get<Vertex<int>>("vertex2");
            this.Scenario["compare"] = vertex1 == vertex2;
        }

        private void SetOtherVertex()
        {
           this.Scenario["vertex1"] = new Vertex<int>(1);
        }

        private void SetVertex()
        {
            this.Scenario["vertex2"] =  new Vertex<int>(1);
        }
        
    }
}