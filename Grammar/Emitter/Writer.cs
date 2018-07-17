// ***********************************************************************
// <copyright file="Writer.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter
{
    using Mobilize.Grammar.Emitter.Templates;

    /// <summary>
    /// Class Writer.
    /// </summary>
    public abstract class Writer
    {
        /// <summary>
        /// The template
        /// </summary>
        private Template template;

        /// <summary>
        /// Gets the file.
        /// </summary>
        /// <value>The file.</value>
        public abstract string File { get; }

        /// <summary>
        /// Gets the template.
        /// </summary>
        /// <value>The template.</value>
        public Template Template => this.template ?? (this.template = new Template(this.File));
    }
}