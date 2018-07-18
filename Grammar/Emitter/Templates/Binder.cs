// ***********************************************************************
// <copyright file="Binder.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Templates
{
    using System;
    using System.Collections.Generic;

    using MoreLinq;

    /// <summary>
    /// Class Binder.
    /// </summary>
    public class Binder
    {
        /// <summary>
        /// The template
        /// </summary>
        private readonly Antlr4.StringTemplate.Template template;

        /// <summary>
        /// Initializes a new instance of the <see cref="Binder"/> class.
        /// </summary>
        /// <param name="template">The template.</param>
        public Binder(Antlr4.StringTemplate.Template template)
        {
            this.template = template;
        }

        /// <summary>
        /// Binds the specified label.
        /// </summary>
        /// <typeparam name="T">the vertex type.</typeparam>
        /// <param name="label">The label.</param>
        /// <param name="value">The value.</param>
        /// <returns>The Binder.</returns>
        public Binder Bind<T>(string label, T value)
        {
            this.template.Add(label, value);
            return this;
        }

        /// <summary>
        /// Binds the specified specification.
        /// </summary>
        /// <typeparam name="T">The vertex type.</typeparam>
        /// <param name="specification">The specification.</param>
        /// <param name="items">The items.</param>
        /// <param name="map">The map.</param>
        /// <returns>The Binder.</returns>
        public Binder Bind<T>(string specification, IEnumerable<T> items, Func<T, object[]> map)
        {
            items.ForEach(item => this.template.AddMany(specification, map));
            return this;
        }

        /// <summary>
        /// Renders this instance.
        /// </summary>
        /// <returns>the Render.</returns>
        public string Render() => this.template.Render();
    }
}