// ***********************************************************************
// <copyright file="Graph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Graph.
    /// </summary>
    /// <seealso cref="Mobilize.Grammar.Graph.IGraph" />
    public class Graph : IGraph
    {
        /// <summary>
        /// The edges
        /// </summary>
        private readonly List<IEdge> edges;

        /// <summary>
        /// The vertices
        /// </summary>
        private readonly List<IVertex> vertices;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class.
        /// </summary>
        public Graph()
        {
            this.edges = new List<IEdge>();
            this.vertices = new List<IVertex>();
        }

        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <value>The edges.</value>
        public IEnumerable<IEdge> Edges { get; }

        /// <summary>
        /// Gets the vertices.
        /// </summary>
        /// <value>The vertices.</value>
        public IEnumerable<IVertex> Vertices { get; }

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        public void AddEdge(IEdge edge)
        {
            this.edges.Add(edge);
        }

        /// <summary>
        /// Adds the endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        public void AddVertice(IVertex endpoint)
        {
            this.vertices.Add(endpoint);
        }
    }
}