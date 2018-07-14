// ***********************************************************************
// <copyright file="GraphFeature.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Deedle;
using DeepEqual.Syntax;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobilize.Grammar.Graph;
using Mobilize.Quality.Core;
using Mobilize.Quality.Core.Annotations;

namespace Mobilize.Grammar.Test.Graph
{
    /// <summary>
    ///     Class GraphFeature.
    /// </summary>
    /// <seealso cref="Mobilize.Quality.Core.Feature" />
    [TestClass]
    [Feature(@"The creation of graph")]
    public class GraphFeature : Feature
    {
        /// <summary>
        ///     Adjacency the dictionary.
        /// </summary>
        [Scenario(@"Adjacency Dictionary")]
        [TestMethod]
        public void AdjacencyDictionary()
        {
            RunScenario(
                given => CreateGraph<int>(),
                and => AddVertexToGraph(1),
                and => AddVertexToGraph(2),
                and => AddVertexToGraph(3),
                and => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 2),
                when => GetAdjacencyDictionary<int>(),
                then => VerifyDictionary(
                    new Dictionary<int, IEnumerable<int>>
                    {
                        {1, new List<int> {1, 2}},
                        {2, new List<int> {1}},
                        {3, new List<int>()}
                    }));
        }

        /// <summary>
        ///     Vertexes the degree.
        /// </summary>
        [Scenario("Adjecency Table")]
        [TestMethod]
        public void AdjecencyTable()
        {
            RunScenario(
                given => CreateGraph<int>(),
                and => AddVertexToGraph(1),
                and => AddVertexToGraph(2),
                and => AddVertexToGraph(3),
                and => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 2),
                when => GetAdjacencyTable<int>(),
                then => TableAsExpected(1, 1, 1),
                and => TableAsExpected(1, 2, 1),
                and => TableAsExpected(1, 3, 0),
                and => TableAsExpected(2, 1, 1),
                and => TableAsExpected(2, 2, 0),
                and => TableAsExpected(2, 3, 0),
                and => TableAsExpected(3, 1, 0),
                and => TableAsExpected(3, 3, 0),
                and => TableAsExpected(3, 3, 0));
        }

        [Scenario("Tracing")]
        [TestMethod]
        public void Trace()
        {
            RunScenario(
                given => CreateGraph<int>(),
                and => AddVertexToGraph(1),
                and => AddVertexToGraph(2),
                and => AddVertexToGraph(3),
                and => AddVertexToGraph(4),
                and => AddVertexToGraph(5),
                and => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 2),
                and => AddEdgeToGraph(1, 4),
                and => AddEdgeToGraph(2, 5),
                and => AddEdgeToGraph(5, 2),
                when => TraceGraph(1));
        }

        private void TraceGraph<T>(T vertex)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            var trace = graph.Trace(vertex);
        }


        /// <summary>
        ///     Generics the graph.
        /// </summary>
        [Scenario(@"Warranty that vertex is a set")]
        [TestMethod]
        public void EdgeGraphIsASet()
        {
            RunScenario(
                given => CreateGraph<int>(),
                when => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 1),
                then => EdgeLengthIs<int>(1),
                and => AddEdgeToGraph(1, 2),
                then => EdgeLengthIs<int>(2));
        }

        /// <summary>
        ///     Vertexes the degree.
        /// </summary>
        [Scenario("Vertex Degree")]
        [TestMethod]
        public void GraphIsEven()
        {
            RunScenario(
                given => CreateGraph<int>(),
                and => AddVertexToGraph(1),
                and => AddVertexToGraph(2),
                and => AddVertexToGraph(3),
                and => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 2),
                then => IsGraphEven<int>(true));
        }

        /// <summary>
        ///     Vertexes the degree.
        /// </summary>
        [Scenario("Vertex Degree")]
        [TestMethod]
        public void VertexDegree()
        {
            RunScenario(
                given => CreateGraph<int>(),
                and => AddVertexToGraph(1),
                and => AddVertexToGraph(2),
                and => AddVertexToGraph(3),
                and => AddEdgeToGraph(1, 1),
                and => AddEdgeToGraph(1, 2),
                then => DegreeOf(1, 3),
                and => DegreeOf(2, 1),
                and => DegreeOf(3, 0));
        }

        /// <summary>
        ///     Generics the graph.
        /// </summary>
        [Scenario(@"Warranty that vertex is a set")]
        [TestMethod]
        public void VertexGraphIsASet()
        {
            RunScenario(
                given => CreateGraph<int>(),
                when => AddVertexToGraph(1),
                and => AddVertexToGraph(1),
                then => VertexLengthIs<int>(1),
                and => AddVertexToGraph(2),
                then => VertexLengthIs<int>(2));
        }

        /// <summary>
        ///     Adds the edge to graph.
        /// </summary>
        /// <typeparam name="T">The type of edge</typeparam>
        /// <param name="endpoint1">The endpoint1.</param>
        /// <param name="endpoint2">The endpoint2.</param>
        private void AddEdgeToGraph<T>(T endpoint1, T endpoint2)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.AddEdge(endpoint1, endpoint2);
        }

        /// <summary>
        ///     Adds the vertex to graph.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="value">The value.</param>
        private void AddVertexToGraph<T>(T value)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.AddVertex(value);
        }

        /// <summary>
        ///     Creates the graph.
        /// </summary>
        /// <typeparam name="T">The graph type.</typeparam>
        private void CreateGraph<T>()
            where T : IComparable
        {
            Scenario["graph"] = new Graph<T>();
        }

        /// <summary>
        ///     Degrees the of.
        /// </summary>
        /// <typeparam name="T">the vertex type.</typeparam>
        /// <param name="vertice">The vertice.</param>
        /// <param name="expected">The expected.</param>
        private void DegreeOf<T>(T vertice, int expected)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.Degree(vertice).Should().Be(expected);
        }

        /// <summary>
        ///     Edges the length is.
        /// </summary>
        /// <typeparam name="T">The vertex type</typeparam>
        /// <param name="expected">The expected.</param>
        private void EdgeLengthIs<T>(int expected)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.Edges.Count().Should().Be(expected);
        }

        /// <summary>
        ///     Gets the adjacency dictionary.
        /// </summary>
        /// <typeparam name="T">The type of vertex</typeparam>
        private void GetAdjacencyDictionary<T>()
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            Scenario["dictionary"] = graph.AdjacencyDictionary();
        }

        /// <summary>
        ///     Gets the adjaceny table.
        /// </summary>
        /// <typeparam name="T">The type of the vertex.</typeparam>
        private void GetAdjacencyTable<T>()
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            Scenario["table"] = graph.AdjacencyTable();
        }

        /// <summary>
        ///     Determines whether [is graph even] [the specified expected].
        /// </summary>
        /// <typeparam name="T">The type of the vertex.</typeparam>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        private void IsGraphEven<T>(bool expected)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.IsEven().Should().Be(expected);
        }

        /// <summary>
        ///     Tables as expected.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row">The row.</param>
        /// <param name="column">The column.</param>
        /// <param name="value">The value.</param>
        private void TableAsExpected<T>(T row, T column, int value)
        {
            var table = Scenario.Get<Frame<T, T>>("table");
            table[row, column].Should().Be(value);
        }

        /// <summary>
        ///     Verifies the dictionary.
        /// </summary>
        /// <typeparam name="T">The ty[e of vertex</typeparam>
        /// <param name="expected">The expected.</param>
        private void VerifyDictionary<T>(Dictionary<T, IEnumerable<T>> expected)
        {
            var dictionary = Scenario.Get<Dictionary<int, IEnumerable<int>>>("dictionary");

            dictionary.ShouldDeepEqual(expected);
        }

        /// <summary>
        ///     Vertexes the length is.
        /// </summary>
        /// <typeparam name="T">The vertex type.</typeparam>
        /// <param name="expected">The expected.</param>
        private void VertexLengthIs<T>(int expected)
            where T : IComparable
        {
            var graph = Scenario.Get<Graph<T>>("graph");
            graph.Vertex.Count().Should().Be(expected);
        }
    }
}