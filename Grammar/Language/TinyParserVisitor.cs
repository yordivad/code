// ***********************************************************************
// <copyright file="TinyParserVisitor.cs" company="Mobilize">
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
    /// This interface defines a complete generic visitor for a parse tree produced
    /// by <see cref="TinyParser"/>.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public interface ITinyParserVisitor<Result> : IParseTreeVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitBlock([NotNull] TinyParser.BlockContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.declaration"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitDeclaration([NotNull] TinyParser.DeclarationContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitExpression([NotNull] TinyParser.ExpressionContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitId([NotNull] TinyParser.IdContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.integer"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitInteger([NotNull] TinyParser.IntegerContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.method"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitMethod([NotNull] TinyParser.MethodContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.parameter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitParameter([NotNull] TinyParser.ParameterContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStatement([NotNull] TinyParser.StatementContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitTerm([NotNull] TinyParser.TermContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="TinyParser.unit"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitUnit([NotNull] TinyParser.UnitContext context);
    }
} // namespace Mobilize.Grammar.Language