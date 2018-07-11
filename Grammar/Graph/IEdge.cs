// ***********************************************************************
// <copyright file="IEdge.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    using System;

    /// <summary>
    /// Interface IEdge
    /// </summary>
    public interface IEdge
    {
        /// <summary>
        /// Gets the endpoints.
        /// </summary>
        /// <value>The endpoints.</value>
        Tuple<IVertex, IVertex> Endpoints { get;  }
    }
}