// ***********************************************************************
// <copyright file="Writer.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Emitter
{
    using Mobilize.Grammar.Emitter.Templates;

    public abstract class Writer
    {
        private Template template;

        public abstract string File { get; }

        public Template Template => this.template ?? (this.template = new Template(this.File));
    }
}