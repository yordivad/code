//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from S:/Workspace/Analysis/Mobilize/Grammar/Syntax\TinyParser.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Mobilize.Grammar.Language {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class TinyParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		VAR=1, WHILE=2, RETURN=3, LPAREN=4, RPAREN=5, LBRACE=6, RBRACE=7, LBRACK=8, 
		RBRACK=9, SEMI=10, COMMA=11, DOT=12, ASSIGN=13, GT=14, LT=15, BANG=16, 
		TILDE=17, QUESTION=18, COLON=19, EQUAL=20, LE=21, GE=22, NOTEQUAL=23, 
		AND=24, OR=25, INC=26, DEC=27, ADD=28, SUB=29, MUL=30, DIV=31, BITAND=32, 
		BITOR=33, CARET=34, MOD=35, WS=36, COMMENT=37, LINE_COMMENT=38, STRING=39, 
		INT=40;
	public const int
		RULE_unit = 0, RULE_method = 1, RULE_parameter = 2, RULE_block = 3, RULE_statement = 4, 
		RULE_declaration = 5, RULE_expression = 6, RULE_term = 7, RULE_id = 8, 
		RULE_integer = 9;
	public static readonly string[] ruleNames = {
		"unit", "method", "parameter", "block", "statement", "declaration", "expression", 
		"term", "id", "integer"
	};

	private static readonly string[] _LiteralNames = {
		null, "'var'", "'while'", "'return'", "'('", "')'", "'{'", "'}'", "'['", 
		"']'", "';'", "','", "'.'", "'='", "'>'", "'<'", "'!'", "'~'", "'?'", 
		"':'", "'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'", "'--'", 
		"'+'", "'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "VAR", "WHILE", "RETURN", "LPAREN", "RPAREN", "LBRACE", "RBRACE", 
		"LBRACK", "RBRACK", "SEMI", "COMMA", "DOT", "ASSIGN", "GT", "LT", "BANG", 
		"TILDE", "QUESTION", "COLON", "EQUAL", "LE", "GE", "NOTEQUAL", "AND", 
		"OR", "INC", "DEC", "ADD", "SUB", "MUL", "DIV", "BITAND", "BITOR", "CARET", 
		"MOD", "WS", "COMMENT", "LINE_COMMENT", "STRING", "INT"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "TinyParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static TinyParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public TinyParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public TinyParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class UnitContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(TinyParser.Eof, 0); }
		public MethodContext[] method() {
			return GetRuleContexts<MethodContext>();
		}
		public MethodContext method(int i) {
			return GetRuleContext<MethodContext>(i);
		}
		public UnitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_unit; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterUnit(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitUnit(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public UnitContext unit() {
		UnitContext _localctx = new UnitContext(Context, State);
		EnterRule(_localctx, 0, RULE_unit);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 20; method();
				}
				}
				State = 23;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==STRING );
			State = 25; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodContext : ParserRuleContext {
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public ITerminalNode LPAREN() { return GetToken(TinyParser.LPAREN, 0); }
		public ParameterContext parameter() {
			return GetRuleContext<ParameterContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(TinyParser.RPAREN, 0); }
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public MethodContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_method; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterMethod(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitMethod(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMethod(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MethodContext method() {
		MethodContext _localctx = new MethodContext(Context, State);
		EnterRule(_localctx, 2, RULE_method);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27; id();
			State = 28; Match(LPAREN);
			State = 29; parameter();
			State = 30; Match(RPAREN);
			State = 31; block();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ParameterContext : ParserRuleContext {
		public IdContext[] id() {
			return GetRuleContexts<IdContext>();
		}
		public IdContext id(int i) {
			return GetRuleContext<IdContext>(i);
		}
		public ITerminalNode[] COMMA() { return GetTokens(TinyParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(TinyParser.COMMA, i);
		}
		public ParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_parameter; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterParameter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitParameter(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParameter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ParameterContext parameter() {
		ParameterContext _localctx = new ParameterContext(Context, State);
		EnterRule(_localctx, 4, RULE_parameter);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 33; id();
			State = 38;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while (_la==COMMA) {
				{
				{
				State = 34; Match(COMMA);
				State = 35; id();
				}
				}
				State = 40;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BlockContext : ParserRuleContext {
		public ITerminalNode LBRACE() { return GetToken(TinyParser.LBRACE, 0); }
		public ITerminalNode RBRACE() { return GetToken(TinyParser.RBRACE, 0); }
		public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public BlockContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_block; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterBlock(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitBlock(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBlock(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BlockContext block() {
		BlockContext _localctx = new BlockContext(Context, State);
		EnterRule(_localctx, 6, RULE_block);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41; Match(LBRACE);
			State = 45;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << VAR) | (1L << WHILE) | (1L << RETURN) | (1L << LBRACE) | (1L << STRING) | (1L << INT))) != 0)) {
				{
				{
				State = 42; statement();
				}
				}
				State = 47;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 48; Match(RBRACE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public BlockContext block() {
			return GetRuleContext<BlockContext>(0);
		}
		public DeclarationContext declaration() {
			return GetRuleContext<DeclarationContext>(0);
		}
		public ITerminalNode WHILE() { return GetToken(TinyParser.WHILE, 0); }
		public ITerminalNode LPAREN() { return GetToken(TinyParser.LPAREN, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RPAREN() { return GetToken(TinyParser.RPAREN, 0); }
		public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public ITerminalNode RETURN() { return GetToken(TinyParser.RETURN, 0); }
		public ITerminalNode SEMI() { return GetToken(TinyParser.SEMI, 0); }
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 8, RULE_statement);
		try {
			State = 62;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LBRACE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 50; block();
				}
				break;
			case VAR:
			case STRING:
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 51; declaration();
				}
				break;
			case WHILE:
				EnterOuterAlt(_localctx, 3);
				{
				State = 52; Match(WHILE);
				State = 53; Match(LPAREN);
				State = 54; expression(0);
				State = 55; Match(RPAREN);
				State = 56; statement();
				}
				break;
			case RETURN:
				EnterOuterAlt(_localctx, 4);
				{
				State = 58; Match(RETURN);
				State = 59; expression(0);
				State = 60; Match(SEMI);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DeclarationContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode SEMI() { return GetToken(TinyParser.SEMI, 0); }
		public ITerminalNode VAR() { return GetToken(TinyParser.VAR, 0); }
		public DeclarationContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_declaration; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterDeclaration(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitDeclaration(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDeclaration(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DeclarationContext declaration() {
		DeclarationContext _localctx = new DeclarationContext(Context, State);
		EnterRule(_localctx, 10, RULE_declaration);
		try {
			State = 71;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
			case INT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 64; expression(0);
				State = 65; Match(SEMI);
				}
				break;
			case VAR:
				EnterOuterAlt(_localctx, 2);
				{
				State = 67; Match(VAR);
				State = 68; expression(0);
				State = 69; Match(SEMI);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public IToken bop;
		public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ASSIGN() { return GetToken(TinyParser.ASSIGN, 0); }
		public ITerminalNode ADD() { return GetToken(TinyParser.ADD, 0); }
		public ITerminalNode SUB() { return GetToken(TinyParser.SUB, 0); }
		public ITerminalNode MUL() { return GetToken(TinyParser.MUL, 0); }
		public ITerminalNode DIV() { return GetToken(TinyParser.DIV, 0); }
		public ITerminalNode MOD() { return GetToken(TinyParser.MOD, 0); }
		public ITerminalNode LE() { return GetToken(TinyParser.LE, 0); }
		public ITerminalNode GE() { return GetToken(TinyParser.GE, 0); }
		public ITerminalNode LT() { return GetToken(TinyParser.LT, 0); }
		public ITerminalNode GT() { return GetToken(TinyParser.GT, 0); }
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 12;
		EnterRecursionRule(_localctx, 12, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 74; term();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 90;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 88;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
					case 1:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 76;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 77; Match(ASSIGN);
						State = 78; expression(5);
						}
						break;
					case 2:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 79;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 80;
						_localctx.bop = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==ADD || _la==SUB) ) {
							_localctx.bop = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 81; expression(4);
						}
						break;
					case 3:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 82;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 83;
						_localctx.bop = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MUL) | (1L << DIV) | (1L << MOD))) != 0)) ) {
							_localctx.bop = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 84; expression(3);
						}
						break;
					case 4:
						{
						_localctx = new ExpressionContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 85;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 86;
						_localctx.bop = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << GT) | (1L << LT) | (1L << LE) | (1L << GE))) != 0)) ) {
							_localctx.bop = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 87; expression(2);
						}
						break;
					}
					} 
				}
				State = 92;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,6,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		public IdContext id() {
			return GetRuleContext<IdContext>(0);
		}
		public IntegerContext integer() {
			return GetRuleContext<IntegerContext>(0);
		}
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(Context, State);
		EnterRule(_localctx, 14, RULE_term);
		try {
			State = 95;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
				EnterOuterAlt(_localctx, 1);
				{
				State = 93; id();
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 94; integer();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IdContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(TinyParser.STRING, 0); }
		public IdContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_id; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterId(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitId(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitId(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IdContext id() {
		IdContext _localctx = new IdContext(Context, State);
		EnterRule(_localctx, 16, RULE_id);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 97; Match(STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntegerContext : ParserRuleContext {
		public ITerminalNode INT() { return GetToken(TinyParser.INT, 0); }
		public IntegerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integer; } }
		public override void EnterRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.EnterInteger(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ITinyParserListener typedListener = listener as ITinyParserListener;
			if (typedListener != null) typedListener.ExitInteger(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ITinyParserVisitor<TResult> typedVisitor = visitor as ITinyParserVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInteger(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntegerContext integer() {
		IntegerContext _localctx = new IntegerContext(Context, State);
		EnterRule(_localctx, 18, RULE_integer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 99; Match(INT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 6: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 4);
		case 1: return Precpred(Context, 3);
		case 2: return Precpred(Context, 2);
		case 3: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '*', 'h', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', 
		'\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x4', 
		'\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x3', 
		'\x2', '\x6', '\x2', '\x18', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x19', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\a', '\x4', '\'', '\n', '\x4', '\f', '\x4', '\xE', '\x4', 
		'*', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '.', '\n', 
		'\x5', '\f', '\x5', '\xE', '\x5', '\x31', '\v', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x41', '\n', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x5', '\a', 'J', '\n', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\a', '\b', '[', '\n', '\b', '\f', '\b', '\xE', 
		'\b', '^', '\v', '\b', '\x3', '\t', '\x3', '\t', '\x5', '\t', '\x62', 
		'\n', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x2', '\x3', '\xE', '\f', '\x2', '\x4', '\x6', '\b', '\n', '\f', 
		'\xE', '\x10', '\x12', '\x14', '\x2', '\x5', '\x3', '\x2', '\x1E', '\x1F', 
		'\x4', '\x2', ' ', '!', '%', '%', '\x4', '\x2', '\x10', '\x11', '\x17', 
		'\x18', '\x2', 'i', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x4', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x6', '#', '\x3', '\x2', '\x2', '\x2', 
		'\b', '+', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', '\x2', '\x2', 
		'\x2', '\f', 'I', '\x3', '\x2', '\x2', '\x2', '\xE', 'K', '\x3', '\x2', 
		'\x2', '\x2', '\x10', '\x61', '\x3', '\x2', '\x2', '\x2', '\x12', '\x63', 
		'\x3', '\x2', '\x2', '\x2', '\x14', '\x65', '\x3', '\x2', '\x2', '\x2', 
		'\x16', '\x18', '\x5', '\x4', '\x3', '\x2', '\x17', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'\x1A', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', '\a', '\x2', 
		'\x2', '\x3', '\x1C', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', 
		'\x5', '\x12', '\n', '\x2', '\x1E', '\x1F', '\a', '\x6', '\x2', '\x2', 
		'\x1F', ' ', '\x5', '\x6', '\x4', '\x2', ' ', '!', '\a', '\a', '\x2', 
		'\x2', '!', '\"', '\x5', '\b', '\x5', '\x2', '\"', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '#', '(', '\x5', '\x12', '\n', '\x2', '$', '%', '\a', '\r', 
		'\x2', '\x2', '%', '\'', '\x5', '\x12', '\n', '\x2', '&', '$', '\x3', 
		'\x2', '\x2', '\x2', '\'', '*', '\x3', '\x2', '\x2', '\x2', '(', '&', 
		'\x3', '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', ')', 
		'\a', '\x3', '\x2', '\x2', '\x2', '*', '(', '\x3', '\x2', '\x2', '\x2', 
		'+', '/', '\a', '\b', '\x2', '\x2', ',', '.', '\x5', '\n', '\x6', '\x2', 
		'-', ',', '\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '/', '-', '\x3', '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x30', '\x32', '\x3', '\x2', '\x2', '\x2', '\x31', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\a', '\t', '\x2', '\x2', 
		'\x33', '\t', '\x3', '\x2', '\x2', '\x2', '\x34', '\x41', '\x5', '\b', 
		'\x5', '\x2', '\x35', '\x41', '\x5', '\f', '\a', '\x2', '\x36', '\x37', 
		'\a', '\x4', '\x2', '\x2', '\x37', '\x38', '\a', '\x6', '\x2', '\x2', 
		'\x38', '\x39', '\x5', '\xE', '\b', '\x2', '\x39', ':', '\a', '\a', '\x2', 
		'\x2', ':', ';', '\x5', '\n', '\x6', '\x2', ';', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '<', '=', '\a', '\x5', '\x2', '\x2', '=', '>', '\x5', '\xE', 
		'\b', '\x2', '>', '?', '\a', '\f', '\x2', '\x2', '?', '\x41', '\x3', '\x2', 
		'\x2', '\x2', '@', '\x34', '\x3', '\x2', '\x2', '\x2', '@', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x36', '\x3', '\x2', '\x2', '\x2', '@', '<', 
		'\x3', '\x2', '\x2', '\x2', '\x41', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x42', '\x43', '\x5', '\xE', '\b', '\x2', '\x43', '\x44', '\a', '\f', 
		'\x2', '\x2', '\x44', 'J', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', 
		'\a', '\x3', '\x2', '\x2', '\x46', 'G', '\x5', '\xE', '\b', '\x2', 'G', 
		'H', '\a', '\f', '\x2', '\x2', 'H', 'J', '\x3', '\x2', '\x2', '\x2', 'I', 
		'\x42', '\x3', '\x2', '\x2', '\x2', 'I', '\x45', '\x3', '\x2', '\x2', 
		'\x2', 'J', '\r', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\b', '\b', '\x1', 
		'\x2', 'L', 'M', '\x5', '\x10', '\t', '\x2', 'M', '\\', '\x3', '\x2', 
		'\x2', '\x2', 'N', 'O', '\f', '\x6', '\x2', '\x2', 'O', 'P', '\a', '\xF', 
		'\x2', '\x2', 'P', '[', '\x5', '\xE', '\b', '\a', 'Q', 'R', '\f', '\x5', 
		'\x2', '\x2', 'R', 'S', '\t', '\x2', '\x2', '\x2', 'S', '[', '\x5', '\xE', 
		'\b', '\x6', 'T', 'U', '\f', '\x4', '\x2', '\x2', 'U', 'V', '\t', '\x3', 
		'\x2', '\x2', 'V', '[', '\x5', '\xE', '\b', '\x5', 'W', 'X', '\f', '\x3', 
		'\x2', '\x2', 'X', 'Y', '\t', '\x4', '\x2', '\x2', 'Y', '[', '\x5', '\xE', 
		'\b', '\x4', 'Z', 'N', '\x3', '\x2', '\x2', '\x2', 'Z', 'Q', '\x3', '\x2', 
		'\x2', '\x2', 'Z', 'T', '\x3', '\x2', '\x2', '\x2', 'Z', 'W', '\x3', '\x2', 
		'\x2', '\x2', '[', '^', '\x3', '\x2', '\x2', '\x2', '\\', 'Z', '\x3', 
		'\x2', '\x2', '\x2', '\\', ']', '\x3', '\x2', '\x2', '\x2', ']', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '^', '\\', '\x3', '\x2', '\x2', '\x2', '_', 
		'\x62', '\x5', '\x12', '\n', '\x2', '`', '\x62', '\x5', '\x14', '\v', 
		'\x2', '\x61', '_', '\x3', '\x2', '\x2', '\x2', '\x61', '`', '\x3', '\x2', 
		'\x2', '\x2', '\x62', '\x11', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', 
		'\a', ')', '\x2', '\x2', '\x64', '\x13', '\x3', '\x2', '\x2', '\x2', '\x65', 
		'\x66', '\a', '*', '\x2', '\x2', '\x66', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x19', '(', '/', '@', 'I', 'Z', '\\', '\x61',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Mobilize.Grammar.Language