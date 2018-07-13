// ***********************************************************************
// <copyright file="Graph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Deedle;

    using Mobilize.Grammar.Graph.Generic;

    using MoreLinq;

    /// <summary>
    /// Class Graph.
    /// </summary>
    /// <typeparam name="TVertex">The type of the graph.</typeparam>
    /// <seealso cref="Mobilize.Grammar.Graph.IGraph{T}" />
    public class Graph<TVertex> : IGraph<TVertex>
        where TVertex : IComparable
    {
        /// <summary>
        /// The edges
        /// </summary>
        private readonly ISet<IEdge<TVertex>> edges;

        /// <summary>
        /// The vertice
        /// </summary>
        private readonly ISet<TVertex> vertex;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph{TVertex}"/> class.
        /// </summary>
        public Graph()
        {
            this.edges = new HashSet<IEdge<TVertex>>();
            this.vertex = new HashSet<TVertex>();
        }

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <value>The edges.</value>
        public IEnumerable<IEdge<TVertex>> Edges => this.edges;

        /// <summary>
        /// Gets the vertex.
        /// </summary>
        /// <value>The vertice.</value>
        public IEnumerable<TVertex> Vertex => this.vertex;

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        public void AddEdge(IEdge<TVertex> edge) => this.edges.Add(edge);

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="in">The in.</param>
        /// <param name="out">The out.</param>
        public void AddEdge(TVertex @in, TVertex @out) => this.AddEdge(new Edge<TVertex>(@in, @out));

        /// <summary>
        /// Adds the vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        public void AddVertex(TVertex vertice) => this.vertex.Add(vertice);

        /// <summary>
        /// Adjacency  dictionary.
        /// </summary>
        /// <returns>IEnumerable&lt;IDictionary&lt;TVertex, IEnumerable&lt;TVertex&gt;&gt;&gt;.</returns>
        public IDictionary<TVertex, IEnumerable<TVertex>> AdjacencyDictionary() =>
            this.vertex.Select(v => new KeyValuePair<TVertex, IEnumerable<TVertex>>(v, this.Neighbors(v)))
                .ToDictionary();

        /// <summary>
        /// Adjacency the list.
        /// </summary>
        /// <returns>Frame&lt;TVertex, TVertex&gt;.</returns>
        public Frame<TVertex, TVertex> AdjacencyTable() =>
            Frame.FromValues(
                this.vertex.SelectMany(
                    row => this.vertex.Select(
                        column => Tuple.Create(row, column, this.IsConnected(row, column) ? 1 : 0))));

        /// <summary>
        /// Degrees the specified vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The degree of the vertice</returns>
        public int Degree(TVertex vertice) =>
            this.edges.Count(c => c.Endpoints.In.Is(vertice)) + this.edges.Count(c => c.Endpoints.Out.Is(vertice));

        /// <summary>
        /// Ins the vertex.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The List of in vertex;.</returns>
        public IEnumerable<TVertex> InVertex(TVertex vertice) =>
            this.edges.Where(v => v.Endpoints.In.Is(vertice)).Select(c => c.Endpoints.Out);

        /// <summary>
        /// Determines whether the specified vertex1 is connected.
        /// </summary>
        /// <param name="vertex1">The vertex1.</param>
        /// <param name="vertex2">The vertex2.</param>
        /// <returns>Determine if two vertex are connected.</returns>
        public bool IsConnected(TVertex vertex1, TVertex vertex2) =>
            this.Edges.Any(e => e.Is(vertex1, vertex2) || e.Is(vertex2, vertex1));

        /// <summary>
        /// Determines whether this instance is even.
        /// </summary>
        /// <returns><c>true</c> if this instance is even; otherwise, <c>false</c>.</returns>
        public bool IsEven() => this.vertex.Sum(this.Degree) % 2 == 0;

        /// <summary>
        /// Neighbors the specified vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>the List of the neighbors.</returns>
        public IEnumerable<TVertex> Neighbors(TVertex vertice) =>
            this.InVertex(vertice).Union(this.OutVertex(vertice)).Distinct();

        /// <summary>
        /// Outs the vertex.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        /// <returns>The list of out vertex.</returns>
        public IEnumerable<TVertex> OutVertex(TVertex vertice) =>
            this.edges.Where(v => v.Endpoints.Out.Is(vertice)).Select(c => c.Endpoints.In);
    }
}