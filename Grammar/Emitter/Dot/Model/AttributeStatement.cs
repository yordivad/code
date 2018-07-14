using System;
using System.Collections.Generic;
using System.Diagnostics;

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
        
        private AttributeKind kind;

        public AttributeStatement(AttributeKind kind)
        {
            this.kind = kind;
            properties = new List<Property>();
        
        }

        public void AddProperty(Property property)
        {
            properties.Add(property);
        }


        public string KindName => Enum.GetName(typeof(AttributeKind), this.kind);

        public IEnumerable<Property> Properties => this.properties;

        public bool HasProperties => this.properties.Count > 0;

    }
}