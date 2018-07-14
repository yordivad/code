// ***********************************************************************
// <copyright file="IGraph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Mobilize.Grammar.Graph.Generic;

namespace Mobilize.Grammar.Graph
{
    /// <summary>
    ///     Interface IGraph
    /// </summary>
    /// <typeparam name="T">The type of the vertice</typeparam>
    public interface IGraph<T>
        where T : IComparable
    {
        /// <summary>
        ///     Gets the edges.
        /// </summary>
        /// <value>The edges.</value>
        IEnumerable<Edge<T>> Edges { get; }

        /// <summary>
        ///     Gets the vertices.
        /// </summary>
        /// <value>The vertices.</value>
        IEnumerable<T> Vertex { get; }

        /// <summary>
        ///     Adds the edge.
        /// </summary>
        /// <param name="edge">The edge.</param>
        void AddEdge(Edge<T> edge);

        /// <summary>
        ///     Adds the vertice.
        /// </summary>
        /// <param name="vertice">The vertice.</param>
        void AddVertex(T vertice);
    }
}