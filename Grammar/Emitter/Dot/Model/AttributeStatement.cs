// ***********************************************************************
// <copyright file="AttributeStatement.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Dot.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class AttributeStatement.
    /// </summary>
    /// <seealso cref="Mobilize.Grammar.Emitter.Dot.Model.Statement" />
    public class AttributeStatement : Statement
    {
        /// <summary>
        /// The kind
        /// </summary>
        private readonly AttributeKind kind;

        /// <summary>
        /// The properties
        /// </summary>
        private readonly List<Property> properties;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeStatement"/> class.
        /// </summary>
        /// <param name="kind">The kind.</param>
        public AttributeStatement(AttributeKind kind)
        {
            this.kind = kind;
            this.properties = new List<Property>();
        }

        /// <summary>
        /// Gets a value indicating whether this instance has properties.
        /// </summary>
        /// <value><c>true</c> if this instance has properties; otherwise, <c>false</c>.</value>
        public bool HasProperties => this.properties.Count > 0;

        /// <summary>
        /// Gets the name of the kind.
        /// </summary>
        /// <value>The name of the kind.</value>
        public string KindName => Enum.GetName(typeof(AttributeKind), this.kind);

        /// <summary>
        /// Gets the properties.
        /// </summary>
        /// <value>The properties.</value>
        public IEnumerable<Property> Properties => this.properties;

        /// <summary>
        /// Adds the property.
        /// </summary>
        /// <param name="property">The property.</param>
        public void AddProperty(Property property)
        {
            this.properties.Add(property);
        }
    }
}