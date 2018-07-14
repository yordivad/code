

namespace Mobilize.Grammar.Emitter.Dot
{
    using Model;
    
    public static class Emit
    {
        public static Graph Graph(string identifier, bool strict = false)
        {
            return new Graph(GraphKind.graph, identifier, strict);
        }
        
        public static Graph DiGraph(string identifier, bool strict = false)
        {
            return new Graph(GraphKind.digraph, identifier, strict);
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

        public static Graph Statement(this Graph graph, Statement statement)
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