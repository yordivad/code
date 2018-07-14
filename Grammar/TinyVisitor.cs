// ***********************************************************************
// <copyright file="TinyVisitor.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using Mobilize.Grammar.Language;

namespace Mobilize.Grammar
{
    /// <summary>
    ///     Class TinyVisitor.
    /// </summary>
    /// <seealso cref="TinyParserBaseListener" />
    public class TinyVisitor : TinyParserBaseListener
    {
        /// <summary>
        ///     Enter a parse tree produced by <see cref="M:Mobilize.Grammar.Lenguage.TinyParser.unit" />.
        ///     <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterUnit(TinyParser.UnitContext context)
        {
            base.EnterUnit(context);
        }
    }
}