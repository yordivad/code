// ***********************************************************************
// <copyright file="Template.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter.Templates
{
    using System.IO;

    using Antlr4.StringTemplate;

    /// <summary>
    /// Class Template.
    /// </summary>
    public class Template
    {
        /// <summary>
        /// The group
        /// </summary>
        private readonly TemplateGroup group;

        /// <summary>
        /// Initializes a new instance of the <see cref="Template"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Template(string name)
        {
            this.Name = name;
            this.group = new TemplateGroupFile($"{Directory.GetCurrentDirectory()}/{this.Name}");
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Binds the specified specification.
        /// </summary>
        /// <param name="specification">The specification.</param>
        /// <returns>The Binder.</returns>
        public Binder Bind(string specification)
        {
            var template = this.group.GetInstanceOf(specification);
            return new Binder(template);
        }
    }
}