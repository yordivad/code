// ***********************************************************************
// <copyright file="Graph.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Dot.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class Graph.
    /// </summary>
    /// <seealso cref="Mobilize.Grammar.Emitter.Writer" />
    public class Graph : Writer
    {
        /// <summary>
        /// The kind
        /// </summary>
        private readonly GraphKind kind;

        /// <summary>
        /// The statements
        /// </summary>
        private readonly List<Statement> statements;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class.
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="strict">if set to <c>true</c> [strict].</param>
        public Graph(GraphKind kind, string id, bool strict = false)
        {
            this.kind = kind;
            this.Identifier = id;
            this.statements = new List<Statement>();
        }

        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <value>The file.</value>
        public override string File => "Emitter/Dot/dot.stg";

        /// <summary>
        /// Gets the type of the graph.
        /// </summary>
        /// <value>The type of the graph.</value>
        public string GraphType { get; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Identifier { get; }

        /// <summary>
        /// Gets the name of the kind.
        /// </summary>
        /// <value>The name of the kind.</value>
        public string KindName => Enum.GetName(typeof(GraphKind), this.kind);

        /// <summary>
        /// Gets the statements.
        /// </summary>
        /// <value>The statements.</value>
        public IEnumerable<Statement> Statements => this.statements;

        /// <summary>
        /// Gets a value indicating whether this <see cref="Graph"/> is strict.
        /// </summary>
        /// <value><c>true</c> if strict; otherwise, <c>false</c>.</value>
        public bool Strict { get; }

        /// <summary>
        /// Adds the statement.
        /// </summary>
        /// <param name="statement">The statement.</param>
        /// <returns>Graph.</returns>
        public Graph AddStatement(Statement statement)
        {
            this.statements.Add(statement);
            return this;
        }

        /// <summary>
        /// Renders this instance.
        /// </summary>
        /// <returns>System.String.</returns>
        public string Render()
        {
            return this.Template.Bind("graph").Bind("it", this).Render();
        }
    }
}