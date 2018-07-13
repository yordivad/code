// ***********************************************************************
// <copyright file="IEdge.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    /// <summary>
    /// Interface IEdge
    /// </summary>
    /// <typeparam name="T">The type of the vertex</typeparam>
    public interface IEdge<T>
    {
        /// <summary>
        /// Gets the endpoints.
        /// </summary>
        /// <value>The endpoints.</value>
        (T In, T Out) Endpoints { get; }
    }
}