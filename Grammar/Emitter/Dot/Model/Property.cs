// ***********************************************************************
// <copyright file="Property.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Dot.Model
{
    /// <summary>
    /// Class Property.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Property"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="value">The value.</param>
        public Property(string label, string value)
        {
            this.Label = label;
            this.Value = value;
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; }
    }
}