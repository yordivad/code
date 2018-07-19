// ***********************************************************************
// <copyright file="DotParserBaseListener.cs" company="Mobilize">
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
    using Antlr4.Runtime;
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;

    /// <summary>
    /// This class provides an empty implementation of <see cref="IDotParserListener"/>,
    /// which can be extended to create a listener which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public class DotParserBaseListener : IDotParserListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.a_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterA_list([NotNull] DotParser.A_listContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterAttribute_list([NotNull] DotParser.Attribute_listContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterAttribute_statement([NotNull] DotParser.Attribute_statementContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterEdge_operation([NotNull] DotParser.Edge_operationContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterEdge_statement([NotNull] DotParser.Edge_statementContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterEdgeRHS([NotNull] DotParser.EdgeRHSContext context)
        {
        }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public virtual void EnterEveryRule([NotNull] ParserRuleContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.graph"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterGraph([NotNull] DotParser.GraphContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.id"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterId([NotNull] DotParser.IdContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.node_id"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterNode_id([NotNull] DotParser.Node_idContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterNode_statement([NotNull] DotParser.Node_statementContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.port"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterPort([NotNull] DotParser.PortContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterStatement([NotNull] DotParser.StatementContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterStatement_list([NotNull] DotParser.Statement_listContext context)
        {
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void EnterSubgraph([NotNull] DotParser.SubgraphContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.a_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitA_list([NotNull] DotParser.A_listContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitAttribute_list([NotNull] DotParser.Attribute_listContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitAttribute_statement([NotNull] DotParser.Attribute_statementContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitEdge_operation([NotNull] DotParser.Edge_operationContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitEdge_statement([NotNull] DotParser.Edge_statementContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitEdgeRHS([NotNull] DotParser.EdgeRHSContext context)
        {
        }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public virtual void ExitEveryRule([NotNull] ParserRuleContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.graph"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitGraph([NotNull] DotParser.GraphContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.id"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitId([NotNull] DotParser.IdContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.node_id"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitNode_id([NotNull] DotParser.Node_idContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitNode_statement([NotNull] DotParser.Node_statementContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.port"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitPort([NotNull] DotParser.PortContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.statement"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitStatement([NotNull] DotParser.StatementContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitStatement_list([NotNull] DotParser.Statement_listContext context)
        {
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// <para>The default implementation does nothing.</para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public virtual void ExitSubgraph([NotNull] DotParser.SubgraphContext context)
        {
        }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public virtual void VisitErrorNode([NotNull] IErrorNode node)
        {
        }

        /// <inheritdoc/>
        /// <remarks>The default implementation does nothing.</remarks>
        public virtual void VisitTerminal([NotNull] ITerminalNode node)
        {
        }
    }
} // namespace Mobilize.Grammar.Language