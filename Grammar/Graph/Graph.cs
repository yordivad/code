// ***********************************************************************
// <copyright file="Graph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using Deedle;
using Mobilize.Grammar.Graph.Generic;
using MoreLinq;

namespace Mobilize.Grammar.Graph
{
    /// <summary>
    ///     Class Graph.
    /// </summary>
    /// <typeparam name="TVertex">The type of the graph.</typeparam>
    /// <seealso cref="Mobilize.Grammar.Graph.IGraph{T}" />
    public class Graph<TVertex> : IGraph<TVertex>
        where TVertex : IComparable
    {
        /// <summary>
        ///     The edges
        /// </summary>
        private readonly ISet<Edge<TVertex>> edges;

        /// <summary>
        ///     The vertice
        /// </summary>
        private readonly ISet<TVertex> vertex;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Graph{TVertex}" /> class.
        /// </summary>
        public Graph()
        {
            edges = new HashSet<Edge<TVertex>>();
            vertex = new HashSet<TVertex>();
        }

        /// <summary>
        ///     Gets the edges.
        /// </summary>
        /// <value>The edges.</value>
        public IEnumerable<Edge<TVertex>> Edges => edges;

        /// <summary>
        ///     Gets the vertex.
        /// </summary>
        /// <value>The vertice.</value>
        public IEnumerable<TVertex> Vertex => vertex;

        /// <summary>
        ///     Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        public void AddEdge(Edge<TVertex> edge)
        {
            edges.Add(edge);
        }

        /// <summary>
        ///     Adds the vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        public void AddVertex(TVertex vertice)
        {
            vertex.Add(vertice);
        }

        /// <summary>
        ///     Adds the edge.
        /// </summary>
        /// <param name="in">The in.</param>
        /// <param name="out">The out.</param>
        public void AddEdge(TVertex @in, TVertex @out)
        {
            AddEdge(new Edge<TVertex>(@in, @out));
        }

        /// <summary>
        ///     Adjacency  dictionary.
        /// </summary>
        /// <returns>IEnumerable&lt;IDictionary&lt;TVertex, IEnumerable&lt;TVertex&gt;&gt;&gt;.</returns>
        public IDictionary<TVertex, IEnumerable<TVertex>> AdjacencyDictionary()
        {
            return vertex.Select(v => new KeyValuePair<TVertex, IEnumerable<TVertex>>(v, Neighbors(v)))
                .ToDictionary();
        }

        /// <summary>
        ///     Adjacency the list.
        /// </summary>
        /// <returns>Frame&lt;TVertex, TVertex&gt;.</returns>
        public Frame<TVertex, TVertex> AdjacencyTable()
        {
            return Frame.FromValues(
                vertex.SelectMany(
                    row => vertex.Select(
                        column => Tuple.Create(row, column, IsConnected(row, column) ? 1 : 0))));
        }

        /// <summary>
        ///     Degrees the specified vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The degree of the vertice</returns>
        public int Degree(TVertex vertice)
        {
            return edges.Count(c => c.Endpoints.In.Is(vertice)) + edges.Count(c => c.Endpoints.Out.Is(vertice));
        }

        /// <summary>
        ///     Ins the vertex.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The List of in vertex;.</returns>
        public IEnumerable<TVertex> InVertex(TVertex vertice)
        {
            return edges.Where(v => v.Endpoints.In.Is(vertice)).Select(c => c.Endpoints.Out);
        }

        /// <summary>
        ///     Determines whether the specified vertex1 is connected.
        /// </summary>
        /// <param name="vertex1">The vertex1.</param>
        /// <param name="vertex2">The vertex2.</param>
        /// <returns>Determine if two vertex are connected.</returns>
        public bool IsConnected(TVertex vertex1, TVertex vertex2)
        {
            return Edges.Any(e => e.Is(vertex1, vertex2) || e.Is(vertex2, vertex1));
        }

        /// <summary>
        ///     Determines whether this instance is even.
        /// </summary>
        /// <returns><c>true</c> if this instance is even; otherwise, <c>false</c>.</returns>
        public bool IsEven()
        {
            return vertex.Sum(Degree) % 2 == 0;
        }

        /// <summary>
        ///     Neighbors the specified vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>the List of the neighbors.</returns>
        public IEnumerable<TVertex> Neighbors(TVertex vertice)
        {
            return InVertex(vertice).Union(OutVertex(vertice)).Distinct();
        }

        /// <summary>
        ///     Outs the vertex.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The list of out vertex.</returns>
        public IEnumerable<TVertex> OutVertex(TVertex vertice)
        {
            return edges.Where(v => v.Endpoints.Out.Is(vertice)).Select(c => c.Endpoints.In);
        }

        /// <summary>
        ///     Traces the specified vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <returns>the list of the trace.</returns>
        public IEnumerable<Edge<TVertex>> Trace(TVertex vertex)
        {
            var visited = new HashSet<Edge<TVertex>>();
            var path = new HashSet<Edge<TVertex>>();

            var edge = Next(vertex, visited);
            while (edge != null)
            {
                if (!visited.Contains(edge))
                {
                    visited.Add(edge);
                    path.Add(edge);
                    vertex = edge.Endpoints.Out;
                }

                edge = Next(vertex, visited);
            }

            return path;
        }

        /// <summary>
        ///     Nexts the specified vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        /// <param name="visited">The visited.</param>
        /// <returns>Some edges</returns>
        private Edge<TVertex> Next(TVertex vertex, ISet<Edge<TVertex>> visited)
        {
            return edges.FirstOrDefault(c => c.Endpoints.In.Is(vertex) && visited.All(e => e != c));
        }
    }
}