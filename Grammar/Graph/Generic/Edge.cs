// ***********************************************************************
// <copyright file="Edge.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Graph.Generic
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface IEdge
    /// </summary>
    /// <typeparam name="T">The generic type</typeparam>
    /// <seealso cref="Edge{T}" />
    /// <seealso cref="Mobilize.Grammar.Graph.IEdge" />
    public class Edge<T> : IEdge, IEquatable<Edge<T>>
        where T : IComparable
    {
        /// <summary>
        /// The edge
        /// </summary>
        private readonly Tuple<IVertex, IVertex> edge;

        /// <summary>
        /// Initializes a new instance of the <see cref="Edge{T}" /> class.
        /// </summary>
        /// <param name="item1">The item1.</param>
        /// <param name="item2">The item2.</param>
        public Edge(T item1, T item2)
        {
            this.Endpoints = new Tuple<T, T>(item1, item2);
            this.edge = new Tuple<IVertex, IVertex>(new Vertex<T>(item1), new Vertex<T>(item2));
        }

        /// <summary>
        /// Gets the endpoints.
        /// </summary>
        /// <value>The endpoints.</value>
        public Tuple<T, T> Endpoints { get; }

        /// <summary>
        /// Gets the endpoints.
        /// </summary>
        /// <value>The endpoints.</value>
        Tuple<IVertex, IVertex> IEdge.Endpoints => this.edge;

        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(Edge<T> left, Edge<T> right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(Edge<T> left, Edge<T> right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>true if the current object is equal to the <paramref name="other">other</paramref> parameter; otherwise, false.</returns>
        public bool Equals(Edge<T> other)
        {
            if (other is null)
            {
                return false;
            }

            return ReferenceEquals(this, other) || this.Unique(other);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && this.Equals((Edge<T>)obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.Endpoints != null ? this.Endpoints.Item1.GetHashCode() % this.Endpoints.Item2.GetHashCode() : 0;
        }

        /// <summary>
        /// Unique  the equality.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if it is equal, <c>false</c> otherwise.</returns>
        private bool Unique(Edge<T> other)
        {
            return EqualityComparer<T>.Default.Equals(this.Endpoints.Item1, other.Endpoints.Item1)
                   && EqualityComparer<T>.Default.Equals(this.Endpoints.Item2, other.Endpoints.Item2);
        }
    }
}