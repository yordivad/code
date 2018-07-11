// ***********************************************************************
// <copyright file="IGraph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface IGraph
    /// </summary>
    public interface IGraph
    {
        /// <summary>
        /// Gets the edges.
        /// </summary>
        /// <value>The edges.</value>
        IEnumerable<IEdge> Edges { get; }

        /// <summary>
        /// Gets the vertices.
        /// </summary>
        /// <value>The vertices.</value>
        IEnumerable<IVertex> Vertices { get; }

        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        void AddEdge(IEdge edge);

        /// <summary>
        /// Adds the endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        void AddVertice(IVertex endpoint);
    }
}