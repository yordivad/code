// ***********************************************************************
// <copyright file="TinyParserListener.cs" company="Mobilize">
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
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="TinyParser"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public interface ITinyParserListener : IParseTreeListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterBlock([NotNull] TinyParser.BlockContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.declaration"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterDeclaration([NotNull] TinyParser.DeclarationContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterExpression([NotNull] TinyParser.ExpressionContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterId([NotNull] TinyParser.IdContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.integer"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterInteger([NotNull] TinyParser.IntegerContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.method"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterMethod([NotNull] TinyParser.MethodContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.parameter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterParameter([NotNull] TinyParser.ParameterContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStatement([NotNull] TinyParser.StatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterTerm([NotNull] TinyParser.TermContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="TinyParser.unit"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterUnit([NotNull] TinyParser.UnitContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.block"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitBlock([NotNull] TinyParser.BlockContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.declaration"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitDeclaration([NotNull] TinyParser.DeclarationContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.expression"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitExpression([NotNull] TinyParser.ExpressionContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitId([NotNull] TinyParser.IdContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.integer"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitInteger([NotNull] TinyParser.IntegerContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.method"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitMethod([NotNull] TinyParser.MethodContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.parameter"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitParameter([NotNull] TinyParser.ParameterContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStatement([NotNull] TinyParser.StatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.term"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitTerm([NotNull] TinyParser.TermContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="TinyParser.unit"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitUnit([NotNull] TinyParser.UnitContext context);
    }
} // namespace Mobilize.Grammar.Language