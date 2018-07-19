// ***********************************************************************
// <copyright file="DotParserVisitor.cs" company="Mobilize">
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
    /// by <see cref="DotParser"/>.
    /// </summary>
    /// <typeparam name="Result">The return type of the visit operation.</typeparam>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public interface IDotParserVisitor<Result> : IParseTreeVisitor<Result>
    {
        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.a_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitA_list([NotNull] DotParser.A_listContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAttribute_list([NotNull] DotParser.Attribute_listContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitAttribute_statement([NotNull] DotParser.Attribute_statementContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitEdge_operation([NotNull] DotParser.Edge_operationContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitEdge_statement([NotNull] DotParser.Edge_statementContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitEdgeRHS([NotNull] DotParser.EdgeRHSContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.graph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitGraph([NotNull] DotParser.GraphContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitId([NotNull] DotParser.IdContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.node_id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNode_id([NotNull] DotParser.Node_idContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitNode_statement([NotNull] DotParser.Node_statementContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.port"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitPort([NotNull] DotParser.PortContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStatement([NotNull] DotParser.StatementContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitStatement_list([NotNull] DotParser.Statement_listContext context);

        /// <summary>
        /// Visit a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        /// <return>The visitor result.</return>
        Result VisitSubgraph([NotNull] DotParser.SubgraphContext context);
    }
} // namespace Mobilize.Grammar.Language