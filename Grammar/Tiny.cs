// ***********************************************************************
// <copyright file="Tiny.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar
{
    using System.Linq;

    using Antlr4.Runtime;

    using Mobilize.Grammar.Language;

    /// <summary>
    ///     Class Tiny.
    /// </summary>
    public class Tiny
    {
        /// <summary>
        ///     The errors
        /// </summary>
        private readonly TinyErrors errors;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Tiny" /> class.
        /// </summary>
        public Tiny()
        {
            this.errors = new TinyErrors();
        }

        /// <summary>
        ///     Gets a value indicating whether this instance has errors.
        /// </summary>
        /// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
        public bool HasErrors => this.errors.Errors.Any();

        /// <summary>
        ///     Trees the specified code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns>the parser.</returns>
        public TinyParser.UnitContext Tree(string code)
        {
            var stream = new AntlrInputStream(code);
            var lexer = new TinyLexer(stream);
            lexer.AddErrorListener(this.errors);
            var token = new CommonTokenStream(lexer);
            var parser = new TinyParser(token);
            parser.AddErrorListener(this.errors);
            return parser.unit();
        }
    }
}