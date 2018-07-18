// ***********************************************************************
// <copyright file="GraphExtension.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph
{
    using System.Collections.Generic;

    /// <summary>
    ///     Class GraphExtension.
    /// </summary>
    public static class GraphExtension
    {
        /// <summary>
        ///     Determines whether [is] [the specified other].
        /// </summary>
        /// <typeparam name="T">The type of the t.</typeparam>
        /// <param name="item">The item.</param>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if [is] [the specified other]; otherwise, <c>false</c>.</returns>
        public static bool Is<T>(this T item, T other) => EqualityComparer<T>.Default.Equals(item, other);

        /// <summary>
        ///     Determines whether [has] [the specified in].
        /// </summary>
        /// <typeparam name="T">The type of vertex</typeparam>
        /// <param name="edge">The edge.</param>
        /// <param name="in">The in.</param>
        /// <param name="out">The out.</param>
        /// <returns><c>true</c> if [has] [the specified in]; otherwise, <c>false</c>.</returns>
        public static bool Is<T>(this IEdge<T> edge, T @in, T @out) =>
            edge.Endpoints.In.Is(@in) && edge.Endpoints.Out.Is(@out);
    }
}