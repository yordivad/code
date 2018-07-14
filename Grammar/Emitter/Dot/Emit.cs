using Mobilize.Grammar.Emitter.Dot.Model;

namespace Mobilize.Grammar.Emitter.Dot
{
    public static class Emit
    {
        public static Model.Graph Graph(string identifier, bool strict = false)
        {
            return new Model.Graph(GraphKind.graph, identifier, strict);
        }

        public static Model.Graph DiGraph(string identifier, bool strict = false)
        {
            return new Model.Graph(GraphKind.digraph, identifier, strict);
        }

        public static AttributeStatement AttributeStatement(AttributeKind kind)
        {
            return new AttributeStatement(kind);
        }

        public static AttributeStatement Property(this AttributeStatement statement, string label, string value)
        {
            statement.AddProperty(new Property(label, value));
            return statement;
        }

        public static Model.Graph Statement(this Model.Graph graph, Statement statement)
        {
            graph.AddStatement(statement);
            return graph;
        }

        public static Statement Property(this AttributeStatement statement, Property property)
        {
            statement.AddProperty(property);
            return statement;
        }
    }
}