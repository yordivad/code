//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/roy/workspace/Mobilize/Grammar/TinyParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Mobilize.Grammar.Lenguage {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITinyParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class TinyParserBaseListener : ITinyParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnit([NotNull] TinyParser.UnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnit([NotNull] TinyParser.UnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod([NotNull] TinyParser.MethodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod([NotNull] TinyParser.MethodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] TinyParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] TinyParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] TinyParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] TinyParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] TinyParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] TinyParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] TinyParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] TinyParser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] TinyParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] TinyParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] TinyParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] TinyParser.TermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId([NotNull] TinyParser.IdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId([NotNull] TinyParser.IdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TinyParser.integer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInteger([NotNull] TinyParser.IntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TinyParser.integer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInteger([NotNull] TinyParser.IntegerContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Mobilize.Grammar.Lenguage
