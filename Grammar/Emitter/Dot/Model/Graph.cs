using System;
using System.Collections.Generic;

namespace Mobilize.Grammar.Emitter.Dot.Model
{
    public enum GraphKind
    {
        graph,
        digraph
    }

    public class Graph : Writer
    {
        private readonly GraphKind kind;
        private readonly List<Statement> statements;

        public Graph(GraphKind kind, string id, bool strict = false)
        {
            this.kind = kind;
            Identifier = id;
            statements = new List<Statement>();
        }

        public IEnumerable<Statement> Statements => statements;

        public string GraphType { get; }

        public string Identifier { get; }

        public bool Strict { get; }

        public string KindName => Enum.GetName(typeof(GraphKind), kind);

        public override string File => "Emitter/Dot/dot.stg";

        public Graph AddStatement(Statement statement)
        {
            statements.Add(statement);
            return this;
        }

        public string Render()
        {
            return Template
                .Bind("graph")
                .Bind("it", this)
                .Render();
        }
    }
}