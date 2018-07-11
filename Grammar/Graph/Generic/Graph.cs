// ***********************************************************************
// <copyright file="Graph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph.Generic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface IGraph
    /// </summary>
    /// <typeparam name="T">The Generic type</typeparam>
    /// <seealso cref="Mobilize.Grammar.Graph.IGraph" />
    public class Graph<T>
        where T : IComparable
    {
        /// <summary>
        /// The edges
        /// </summary>
        private readonly ISet<Edge<T>> edges;

        /// <summary>
        /// The vertex
        /// </summary>
        private readonly ISet<T> vertex;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph{T}"/> class.
        /// </summary>
        public Graph()
        {
            this.edges = new HashSet<Edge<T>>();
            this.vertex = new HashSet<T>();
        }

        /// <summary>
        /// Adds the vertex.
        /// </summary>
        /// <param name="vertex">The vertex.</param>
        public void AddVertex(T vertex)
        {
            this.vertex.Add(vertex);
        }


        /// <summary>
        /// Adds the edge.
        /// </summary>
        /// <param name="endpoint1">The endpoint1.</param>
        /// <param name="endpoint2">The endpoint2.</param>
        public void AddEdge(T endpoint1, T endpoint2)
        {
            this.edges.Add(new Edge<T>(endpoint1, endpoint2));
        }
    }
}