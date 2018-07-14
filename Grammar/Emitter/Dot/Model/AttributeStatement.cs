using System;
using System.Collections.Generic;

namespace Mobilize.Grammar.Emitter.Dot.Model
{
    public enum AttributeKind
    {
        Graph,
        Node,
        Edge
    }

    public class AttributeStatement : Statement
    {
        private readonly List<Property> properties;

        private readonly AttributeKind kind;

        public AttributeStatement(AttributeKind kind)
        {
            this.kind = kind;
            properties = new List<Property>();
        }

        public string KindName => Enum.GetName(typeof(AttributeKind), kind);

        public IEnumerable<Property> Properties => properties;

        public bool HasProperties => properties.Count > 0;

        public void AddProperty(Property property)
        {
            properties.Add(property);
        }
    }
}