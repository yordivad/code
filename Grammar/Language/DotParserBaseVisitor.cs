// ***********************************************************************
// <copyright file="DotParserBaseVisitor.cs" company="Mobilize">
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
    /// This class provides an empty implementation of <see cref="IDotParserVisitor{Result}"/>,
    /// which can be extended to create a visitor which only needs to handle a subset
    /// of the available methods.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public class DotParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IDotParserVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.a_list"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitA_list([NotNull] DotParser.A_listContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitAttribute_list([NotNull] DotParser.Attribute_listContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitAttribute_statement([NotNull] DotParser.Attribute_statementContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitEdge_operation([NotNull] DotParser.Edge_operationContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitEdge_statement([NotNull] DotParser.Edge_statementContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitEdgeRHS([NotNull] DotParser.EdgeRHSContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.graph"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitGraph([NotNull] DotParser.GraphContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.id"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitId([NotNull] DotParser.IdContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.node_id"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNode_id([NotNull] DotParser.Node_idContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitNode_statement([NotNull] DotParser.Node_statementContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.port"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitPort([NotNull] DotParser.PortContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.statement"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitStatement([NotNull] DotParser.StatementContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitStatement_list([NotNull] DotParser.Statement_listContext context)
        {
            return this.VisitChildren(context);
        }

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// <para>
        /// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
        /// on <paramref name="context"/>.
        /// </para>
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        public virtual Result VisitSubgraph([NotNull] DotParser.SubgraphContext context)
        {
            return this.VisitChildren(context);
        }
    }
} // namespace Mobilize.Grammar.Language