// ***********************************************************************
// <copyright file="TinyParserBaseVisitor.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Mobilize.Grammar.Language
{
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;

    /// <summary>
    /// This class provides an empty implementation of <see cref="ITinyParserVisitor{Result}"/>,
    /// which can be extended to create a visitor which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public class TinyParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, ITinyParserVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.block"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitBlock([NotNull] TinyParser.BlockContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.declaration"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitDeclaration([NotNull] TinyParser.DeclarationContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.expression"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitExpression([NotNull] TinyParser.ExpressionContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.id"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitId([NotNull] TinyParser.IdContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.integer"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitInteger([NotNull] TinyParser.IntegerContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.method"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitMethod([NotNull] TinyParser.MethodContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.parameter"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitParameter([NotNull] TinyParser.ParameterContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.statement"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitStatement([NotNull] TinyParser.StatementContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.term"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitTerm([NotNull] TinyParser.TermContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.unit"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitUnit([NotNull] TinyParser.UnitContext context)
        {
            return this.VisitChildren(context);
        }
    }
} // namespace Mobilize.Grammar.Language