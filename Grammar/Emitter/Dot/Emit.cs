// ***********************************************************************
// <copyright file="Emit.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Dot
{
    using Mobilize.Grammar.Emitter.Dot.Model;

    /// <summary>
    /// Class Emit.
    /// </summary>
    public static class Emit
    {
        /// <summary>
        /// Attributes the statement.
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <returns>The AttributeStatement.</returns>
        public static AttributeStatement AttributeStatement(AttributeKind kind) => new AttributeStatement(kind);

        /// <summary>
        /// Dis the graph.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <param name="strict">if set to <c>true</c> [strict].</param>
        /// <returns>The Digraph.</returns>
        public static Graph DiGraph(string identifier, bool strict = false) => new Graph(GraphKind.Digraph, identifier, strict);

        /// <summary>
        /// Graph the specified identifier.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <param name="strict">if set to <c>true</c> [strict].</param>
        /// <returns>The Graph.</returns>
        public static Graph Graph(string identifier, bool strict = false)
        {
            return new Graph(GraphKind.Graph, identifier, strict);
        }

        /// <summary>
        /// Properties the specified label.
        /// </summary>
        /// <param name="statement">The statement.</param>
        /// <param name="label">The label.</param>
        /// <param name="value">The value.</param>
        /// <returns>The AttributeStatement.</returns>
        public static AttributeStatement Property(this AttributeStatement statement, string label, string value)
        {
            statement.AddProperty(new Property(label, value));
            return statement;
        }

        /// <summary>
        /// Properties the specified property.
        /// </summary>
        /// <param name="statement">The statement.</param>
        /// <param name="property">The property.</param>
        /// <returns>The Statement.</returns>
        public static Statement Property(this AttributeStatement statement, Property property)
        {
            statement.AddProperty(property);
            return statement;
        }

        /// <summary>
        /// Statements the specified statement.
        /// </summary>
        /// <param name="graph">The graph.</param>
        /// <param name="statement">The statement.</param>
        /// <returns>The Graph.</returns>
        public static Graph Statement(this Graph graph, Statement statement)
        {
            graph.AddStatement(statement);
            return graph;
        }
    }
}