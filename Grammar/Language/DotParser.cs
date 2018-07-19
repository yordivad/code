// ***********************************************************************
// <copyright file="DotParser.cs" company="Mobilize">
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
    using System;
    using System.IO;

    using Antlr4.Runtime;
    using Antlr4.Runtime.Atn;
    using Antlr4.Runtime.Dfa;
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [CLSCompliant(false)]
    public class DotParser : Parser
    {
        public const int RULE_graph = 0;

        public const int RULE_statement_list = 1;

        public const int RULE_statement = 2;

        public const int RULE_attribute_statement = 3;

        public const int RULE_attribute_list = 4;

        public const int RULE_a_list = 5;

        public const int RULE_edge_statement = 6;

        public const int RULE_edgeRHS = 7;

        public const int RULE_edge_operation = 8;

        public const int RULE_node_statement = 9;

        public const int RULE_node_id = 10;

        public const int RULE_port = 11;

        public const int RULE_subgraph = 12;

        public const int RULE_id = 13;

        public const int STRICT = 1;

        public const int GRAPH = 2;

        public const int DIGRAPH = 3;

        public const int NODE = 4;

        public const int EDGE = 5;

        public const int SUBGRAPH = 6;

        public const int LPAREN = 7;

        public const int RPAREN = 8;

        public const int LBRACE = 9;

        public const int RBRACE = 10;

        public const int LBRACK = 11;

        public const int RBRACK = 12;

        public const int SEMI = 13;

        public const int COMMA = 14;

        public const int DOT = 15;

        public const int COLON = 16;

        public const int ASSIGN = 17;

        public const int ARROW = 18;

        public const int OPTION = 19;

        public const int NUMBER = 20;

        public const int STRING = 21;

        public const int ID = 22;

        public const int HTML_STRING = 23;

        public const int COMMENT = 24;

        public const int LINE_COMMENT = 25;

        public const int PREPROC = 26;

        public const int WS = 27;

        private static readonly char[] _serializedATN =
            {
                '\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', '\x5964', '\x3', '\x1D',
                '\x82', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5',
                '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x4', '\t',
                '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r',
                '\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x3', '\x2', '\x5', '\x2', ' ', '\n',
                '\x2', '\x3', '\x2', '\x3', '\x2', '\x5', '\x2', '$', '\n', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3',
                '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', ',', '\n', '\x3', '\a', '\x3', '.', '\n',
                '\x3', '\f', '\x3', '\xE', '\x3', '\x31', '\v', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3',
                '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x5', '\x4', ';', '\n', '\x4', '\x3',
                '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x42', '\n', '\x6', '\x3',
                '\x6', '\x6', '\x6', '\x45', '\n', '\x6', '\r', '\x6', '\xE', '\x6', '\x46', '\x3', '\a', '\x3', '\a',
                '\x3', '\a', '\x5', '\a', 'L', '\n', '\a', '\x3', '\a', '\x5', '\a', 'O', '\n', '\a', '\x6', '\a', 'Q',
                '\n', '\a', '\r', '\a', '\xE', '\a', 'R', '\x3', '\b', '\x3', '\b', '\x5', '\b', 'W', '\n', '\b', '\x3',
                '\b', '\x3', '\b', '\x5', '\b', '[', '\n', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x5', '\t',
                '`', '\n', '\t', '\x6', '\t', '\x62', '\n', '\t', '\r', '\t', '\xE', '\t', '\x63', '\x3', '\n', '\x3',
                '\n', '\x3', '\v', '\x3', '\v', '\x5', '\v', 'j', '\n', '\v', '\x3', '\f', '\x3', '\f', '\x5', '\f',
                'n', '\n', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', 't', '\n', '\r',
                '\x3', '\xE', '\x3', '\xE', '\x5', '\xE', 'x', '\n', '\xE', '\x5', '\xE', 'z', '\n', '\xE', '\x3',
                '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x2', '\x2',
                '\x10', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x16', '\x18', '\x1A',
                '\x1C', '\x2', '\x6', '\x3', '\x2', '\x4', '\x5', '\x4', '\x2', '\x4', '\x4', '\x6', '\a', '\x3', '\x2',
                '\x14', '\x15', '\x3', '\x2', '\x16', '\x19', '\x2', '\x89', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2',
                '\x4', '/', '\x3', '\x2', '\x2', '\x2', '\x6', ':', '\x3', '\x2', '\x2', '\x2', '\b', '<', '\x3', '\x2',
                '\x2', '\x2', '\n', '\x44', '\x3', '\x2', '\x2', '\x2', '\f', 'P', '\x3', '\x2', '\x2', '\x2', '\xE',
                'V', '\x3', '\x2', '\x2', '\x2', '\x10', '\x61', '\x3', '\x2', '\x2', '\x2', '\x12', '\x65', '\x3',
                '\x2', '\x2', '\x2', '\x14', 'g', '\x3', '\x2', '\x2', '\x2', '\x16', 'k', '\x3', '\x2', '\x2', '\x2',
                '\x18', 'o', '\x3', '\x2', '\x2', '\x2', '\x1A', 'y', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x7F', '\x3',
                '\x2', '\x2', '\x2', '\x1E', ' ', '\a', '\x3', '\x2', '\x2', '\x1F', '\x1E', '\x3', '\x2', '\x2', '\x2',
                '\x1F', ' ', '\x3', '\x2', '\x2', '\x2', ' ', '!', '\x3', '\x2', '\x2', '\x2', '!', '#', '\t', '\x2',
                '\x2', '\x2', '\"', '$', '\x5', '\x1C', '\xF', '\x2', '#', '\"', '\x3', '\x2', '\x2', '\x2', '#', '$',
                '\x3', '\x2', '\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', '%', '&', '\a', '\v', '\x2', '\x2',
                '&', '\'', '\x5', '\x4', '\x3', '\x2', '\'', '(', '\a', '\f', '\x2', '\x2', '(', '\x3', '\x3', '\x2',
                '\x2', '\x2', ')', '+', '\x5', '\x6', '\x4', '\x2', '*', ',', '\a', '\xF', '\x2', '\x2', '+', '*',
                '\x3', '\x2', '\x2', '\x2', '+', ',', '\x3', '\x2', '\x2', '\x2', ',', '.', '\x3', '\x2', '\x2', '\x2',
                '-', ')', '\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3', '\x2',
                '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x5', '\x3', '\x2', '\x2', '\x2',
                '\x31', '/', '\x3', '\x2', '\x2', '\x2', '\x32', ';', '\x5', '\x14', '\v', '\x2', '\x33', ';', '\x5',
                '\xE', '\b', '\x2', '\x34', ';', '\x5', '\b', '\x5', '\x2', '\x35', '\x36', '\x5', '\x1C', '\xF', '\x2',
                '\x36', '\x37', '\a', '\x13', '\x2', '\x2', '\x37', '\x38', '\x5', '\x1C', '\xF', '\x2', '\x38', ';',
                '\x3', '\x2', '\x2', '\x2', '\x39', ';', '\x5', '\x1A', '\xE', '\x2', ':', '\x32', '\x3', '\x2', '\x2',
                '\x2', ':', '\x33', '\x3', '\x2', '\x2', '\x2', ':', '\x34', '\x3', '\x2', '\x2', '\x2', ':', '\x35',
                '\x3', '\x2', '\x2', '\x2', ':', '\x39', '\x3', '\x2', '\x2', '\x2', ';', '\a', '\x3', '\x2', '\x2',
                '\x2', '<', '=', '\t', '\x3', '\x2', '\x2', '=', '>', '\x5', '\n', '\x6', '\x2', '>', '\t', '\x3',
                '\x2', '\x2', '\x2', '?', '\x41', '\a', '\r', '\x2', '\x2', '@', '\x42', '\x5', '\f', '\a', '\x2',
                '\x41', '@', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43',
                '\x3', '\x2', '\x2', '\x2', '\x43', '\x45', '\a', '\xE', '\x2', '\x2', '\x44', '?', '\x3', '\x2', '\x2',
                '\x2', '\x45', '\x46', '\x3', '\x2', '\x2', '\x2', '\x46', '\x44', '\x3', '\x2', '\x2', '\x2', '\x46',
                'G', '\x3', '\x2', '\x2', '\x2', 'G', '\v', '\x3', '\x2', '\x2', '\x2', 'H', 'K', '\x5', '\x1C', '\xF',
                '\x2', 'I', 'J', '\a', '\x13', '\x2', '\x2', 'J', 'L', '\x5', '\x1C', '\xF', '\x2', 'K', 'I', '\x3',
                '\x2', '\x2', '\x2', 'K', 'L', '\x3', '\x2', '\x2', '\x2', 'L', 'N', '\x3', '\x2', '\x2', '\x2', 'M',
                'O', '\a', '\x10', '\x2', '\x2', 'N', 'M', '\x3', '\x2', '\x2', '\x2', 'N', 'O', '\x3', '\x2', '\x2',
                '\x2', 'O', 'Q', '\x3', '\x2', '\x2', '\x2', 'P', 'H', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\x3',
                '\x2', '\x2', '\x2', 'R', 'P', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\x3', '\x2', '\x2', '\x2', 'S',
                '\r', '\x3', '\x2', '\x2', '\x2', 'T', 'W', '\x5', '\x16', '\f', '\x2', 'U', 'W', '\x5', '\x1A', '\xE',
                '\x2', 'V', 'T', '\x3', '\x2', '\x2', '\x2', 'V', 'U', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\x3',
                '\x2', '\x2', '\x2', 'X', 'Z', '\x5', '\x10', '\t', '\x2', 'Y', '[', '\x5', '\n', '\x6', '\x2', 'Z',
                'Y', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\x3', '\x2', '\x2', '\x2', '[', '\xF', '\x3', '\x2', '\x2',
                '\x2', '\\', '_', '\x5', '\x12', '\n', '\x2', ']', '`', '\x5', '\x16', '\f', '\x2', '^', '`', '\x5',
                '\x1A', '\xE', '\x2', '_', ']', '\x3', '\x2', '\x2', '\x2', '_', '^', '\x3', '\x2', '\x2', '\x2', '`',
                '\x62', '\x3', '\x2', '\x2', '\x2', '\x61', '\\', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\x3',
                '\x2', '\x2', '\x2', '\x63', '\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\x3', '\x2', '\x2',
                '\x2', '\x64', '\x11', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\t', '\x4', '\x2', '\x2', '\x66',
                '\x13', '\x3', '\x2', '\x2', '\x2', 'g', 'i', '\x5', '\x16', '\f', '\x2', 'h', 'j', '\x5', '\n', '\x6',
                '\x2', 'i', 'h', '\x3', '\x2', '\x2', '\x2', 'i', 'j', '\x3', '\x2', '\x2', '\x2', 'j', '\x15', '\x3',
                '\x2', '\x2', '\x2', 'k', 'm', '\x5', '\x1C', '\xF', '\x2', 'l', 'n', '\x5', '\x18', '\r', '\x2', 'm',
                'l', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\x3', '\x2', '\x2', '\x2', 'n', '\x17', '\x3', '\x2', '\x2',
                '\x2', 'o', 'p', '\a', '\x12', '\x2', '\x2', 'p', 's', '\x5', '\x1C', '\xF', '\x2', 'q', 'r', '\a',
                '\x12', '\x2', '\x2', 'r', 't', '\x5', '\x1C', '\xF', '\x2', 's', 'q', '\x3', '\x2', '\x2', '\x2', 's',
                't', '\x3', '\x2', '\x2', '\x2', 't', '\x19', '\x3', '\x2', '\x2', '\x2', 'u', 'w', '\a', '\b', '\x2',
                '\x2', 'v', 'x', '\x5', '\x1C', '\xF', '\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\x3',
                '\x2', '\x2', '\x2', 'x', 'z', '\x3', '\x2', '\x2', '\x2', 'y', 'u', '\x3', '\x2', '\x2', '\x2', 'y',
                'z', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\x3', '\x2', '\x2', '\x2', '{', '|', '\a', '\v', '\x2',
                '\x2', '|', '}', '\x5', '\x4', '\x3', '\x2', '}', '~', '\a', '\f', '\x2', '\x2', '~', '\x1B', '\x3',
                '\x2', '\x2', '\x2', '\x7F', '\x80', '\t', '\x5', '\x2', '\x2', '\x80', '\x1D', '\x3', '\x2', '\x2',
                '\x2', '\x15', '\x1F', '#', '+', '/', ':', '\x41', '\x46', 'K', 'N', 'R', 'V', 'Z', '_', '\x63', 'i',
                'm', 's', 'w', 'y'
            };

        public static readonly ATN _ATN = new ATNDeserializer().Deserialize(_serializedATN);

        private static readonly string[] _LiteralNames =
            {
                null, null, null, null, null, null, null, "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'",
                "':'", "'='", "'->'", "'--'"
            };

        private static readonly string[] _SymbolicNames =
            {
                null, "STRICT", "GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "LPAREN", "RPAREN", "LBRACE", "RBRACE",
                "LBRACK", "RBRACK", "SEMI", "COMMA", "DOT", "COLON", "ASSIGN", "ARROW", "OPTION", "NUMBER", "STRING",
                "ID", "HTML_STRING", "COMMENT", "LINE_COMMENT", "PREPROC", "WS"
            };

        public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

        public static readonly string[] ruleNames =
            {
                "graph", "statement_list", "statement", "attribute_statement", "attribute_list", "a_list",
                "edge_statement", "edgeRHS", "edge_operation", "node_statement", "node_id", "port", "subgraph", "id"
            };

        protected static DFA[] decisionToDFA;

        protected static PredictionContextCache sharedContextCache = new PredictionContextCache();

        static DotParser()
        {
            decisionToDFA = new DFA[_ATN.NumberOfDecisions];
            for (var i = 0; i < _ATN.NumberOfDecisions; i++)
            {
                decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
            }
        }

        public DotParser(ITokenStream input)
            : this(input, Console.Out, Console.Error)
        {
        }

        public DotParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
            this.Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
        }

        public override string GrammarFileName
        {
            get
            {
                return "DotParser.g4";
            }
        }

        public override string[] RuleNames
        {
            get
            {
                return ruleNames;
            }
        }

        public override string SerializedAtn
        {
            get
            {
                return new string(_serializedATN);
            }
        }

        [NotNull]
        public override IVocabulary Vocabulary
        {
            get
            {
                return DefaultVocabulary;
            }
        }

        [RuleVersion(0)]
        public A_listContext a_list()
        {
            var _localctx = new A_listContext(this.Context, this.State);
            this.EnterRule(_localctx, 10, RULE_a_list);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 78;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    do
                    {
                        {
                            {
                                this.State = 70;
                                this.id();
                                this.State = 73;
                                this.ErrorHandler.Sync(this);
                                _la = this.TokenStream.LA(1);
                                if (_la == ASSIGN)
                                {
                                    {
                                        this.State = 71;
                                        this.Match(ASSIGN);
                                        this.State = 72;
                                        this.id();
                                    }
                                }

                                this.State = 76;
                                this.ErrorHandler.Sync(this);
                                _la = this.TokenStream.LA(1);
                                if (_la == COMMA)
                                {
                                    {
                                        this.State = 75;
                                        this.Match(COMMA);
                                    }
                                }
                            }
                        }

                        this.State = 80;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }
                    while ((((_la) & ~0x3f) == 0
                            && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING)))
                            != 0));
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Attribute_listContext attribute_list()
        {
            var _localctx = new Attribute_listContext(this.Context, this.State);
            this.EnterRule(_localctx, 8, RULE_attribute_list);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 66;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    do
                    {
                        {
                            {
                                this.State = 61;
                                this.Match(LBRACK);
                                this.State = 63;
                                this.ErrorHandler.Sync(this);
                                _la = this.TokenStream.LA(1);
                                if ((((_la) & ~0x3f) == 0
                                     && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID)
                                                        | (1L << HTML_STRING))) != 0))
                                {
                                    {
                                        this.State = 62;
                                        this.a_list();
                                    }
                                }

                                this.State = 65;
                                this.Match(RBRACK);
                            }
                        }

                        this.State = 68;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }
                    while (_la == LBRACK);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Attribute_statementContext attribute_statement()
        {
            var _localctx = new Attribute_statementContext(this.Context, this.State);
            this.EnterRule(_localctx, 6, RULE_attribute_statement);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 58;
                    _la = this.TokenStream.LA(1);
                    if (!((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << GRAPH) | (1L << NODE) | (1L << EDGE))) != 0)))
                    {
                        this.ErrorHandler.RecoverInline(this);
                    }
                    else
                    {
                        this.ErrorHandler.ReportMatch(this);
                        this.Consume();
                    }

                    this.State = 59;
                    this.attribute_list();
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Edge_operationContext edge_operation()
        {
            var _localctx = new Edge_operationContext(this.Context, this.State);
            this.EnterRule(_localctx, 16, RULE_edge_operation);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 99;
                    _la = this.TokenStream.LA(1);
                    if (!(_la == ARROW || _la == OPTION))
                    {
                        this.ErrorHandler.RecoverInline(this);
                    }
                    else
                    {
                        this.ErrorHandler.ReportMatch(this);
                        this.Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Edge_statementContext edge_statement()
        {
            var _localctx = new Edge_statementContext(this.Context, this.State);
            this.EnterRule(_localctx, 12, RULE_edge_statement);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 84;
                    this.ErrorHandler.Sync(this);
                    switch (this.TokenStream.LA(1))
                    {
                        case NUMBER:
                        case STRING:
                        case ID:
                        case HTML_STRING:
                            {
                                this.State = 82;
                                this.node_id();
                            }

                            break;
                        case SUBGRAPH:
                        case LBRACE:
                            {
                                this.State = 83;
                                this.subgraph();
                            }

                            break;
                        default:
                            throw new NoViableAltException(this);
                    }

                    this.State = 86;
                    this.edgeRHS();
                    this.State = 88;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == LBRACK)
                    {
                        {
                            this.State = 87;
                            this.attribute_list();
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public EdgeRHSContext edgeRHS()
        {
            var _localctx = new EdgeRHSContext(this.Context, this.State);
            this.EnterRule(_localctx, 14, RULE_edgeRHS);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 95;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    do
                    {
                        {
                            {
                                this.State = 90;
                                this.edge_operation();
                                this.State = 93;
                                this.ErrorHandler.Sync(this);
                                switch (this.TokenStream.LA(1))
                                {
                                    case NUMBER:
                                    case STRING:
                                    case ID:
                                    case HTML_STRING:
                                        {
                                            this.State = 91;
                                            this.node_id();
                                        }

                                        break;
                                    case SUBGRAPH:
                                    case LBRACE:
                                        {
                                            this.State = 92;
                                            this.subgraph();
                                        }

                                        break;
                                    default:
                                        throw new NoViableAltException(this);
                                }
                            }
                        }

                        this.State = 97;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }
                    while (_la == ARROW || _la == OPTION);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public GraphContext graph()
        {
            var _localctx = new GraphContext(this.Context, this.State);
            this.EnterRule(_localctx, 0, RULE_graph);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 29;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == STRICT)
                    {
                        {
                            this.State = 28;
                            this.Match(STRICT);
                        }
                    }

                    this.State = 31;
                    _la = this.TokenStream.LA(1);
                    if (!(_la == GRAPH || _la == DIGRAPH))
                    {
                        this.ErrorHandler.RecoverInline(this);
                    }
                    else
                    {
                        this.ErrorHandler.ReportMatch(this);
                        this.Consume();
                    }

                    this.State = 33;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if ((((_la) & ~0x3f) == 0
                         && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING))) != 0))
                    {
                        {
                            this.State = 32;
                            this.id();
                        }
                    }

                    this.State = 35;
                    this.Match(LBRACE);
                    this.State = 36;
                    this.statement_list();
                    this.State = 37;
                    this.Match(RBRACE);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public IdContext id()
        {
            var _localctx = new IdContext(this.Context, this.State);
            this.EnterRule(_localctx, 26, RULE_id);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 125;
                    _la = this.TokenStream.LA(1);
                    if (!((((_la) & ~0x3f) == 0
                           && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING)))
                           != 0)))
                    {
                        this.ErrorHandler.RecoverInline(this);
                    }
                    else
                    {
                        this.ErrorHandler.ReportMatch(this);
                        this.Consume();
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Node_idContext node_id()
        {
            var _localctx = new Node_idContext(this.Context, this.State);
            this.EnterRule(_localctx, 20, RULE_node_id);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 105;
                    this.id();
                    this.State = 107;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == COLON)
                    {
                        {
                            this.State = 106;
                            this.port();
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Node_statementContext node_statement()
        {
            var _localctx = new Node_statementContext(this.Context, this.State);
            this.EnterRule(_localctx, 18, RULE_node_statement);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 101;
                    this.node_id();
                    this.State = 103;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == LBRACK)
                    {
                        {
                            this.State = 102;
                            this.attribute_list();
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public PortContext port()
        {
            var _localctx = new PortContext(this.Context, this.State);
            this.EnterRule(_localctx, 22, RULE_port);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 109;
                    this.Match(COLON);
                    this.State = 110;
                    this.id();
                    this.State = 113;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == COLON)
                    {
                        {
                            this.State = 111;
                            this.Match(COLON);
                            this.State = 112;
                            this.id();
                        }
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public StatementContext statement()
        {
            var _localctx = new StatementContext(this.Context, this.State);
            this.EnterRule(_localctx, 4, RULE_statement);
            try
            {
                this.State = 56;
                this.ErrorHandler.Sync(this);
                switch (this.Interpreter.AdaptivePredict(this.TokenStream, 4, this.Context))
                {
                    case 1:
                        this.EnterOuterAlt(_localctx, 1);
                        {
                            this.State = 48;
                            this.node_statement();
                        }

                        break;
                    case 2:
                        this.EnterOuterAlt(_localctx, 2);
                        {
                            this.State = 49;
                            this.edge_statement();
                        }

                        break;
                    case 3:
                        this.EnterOuterAlt(_localctx, 3);
                        {
                            this.State = 50;
                            this.attribute_statement();
                        }

                        break;
                    case 4:
                        this.EnterOuterAlt(_localctx, 4);
                        {
                            this.State = 51;
                            this.id();
                            this.State = 52;
                            this.Match(ASSIGN);
                            this.State = 53;
                            this.id();
                        }

                        break;
                    case 5:
                        this.EnterOuterAlt(_localctx, 5);
                        {
                            this.State = 55;
                            this.subgraph();
                        }

                        break;
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public Statement_listContext statement_list()
        {
            var _localctx = new Statement_listContext(this.Context, this.State);
            this.EnterRule(_localctx, 2, RULE_statement_list);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 45;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    while ((((_la) & ~0x3f) == 0
                            && ((1L << _la) & ((1L << GRAPH) | (1L << NODE) | (1L << EDGE) | (1L << SUBGRAPH)
                                               | (1L << LBRACE) | (1L << NUMBER) | (1L << STRING) | (1L << ID)
                                               | (1L << HTML_STRING))) != 0))
                    {
                        {
                            {
                                this.State = 39;
                                this.statement();
                                this.State = 41;
                                this.ErrorHandler.Sync(this);
                                _la = this.TokenStream.LA(1);
                                if (_la == SEMI)
                                {
                                    {
                                        this.State = 40;
                                        this.Match(SEMI);
                                    }
                                }
                            }
                        }

                        this.State = 47;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        [RuleVersion(0)]
        public SubgraphContext subgraph()
        {
            var _localctx = new SubgraphContext(this.Context, this.State);
            this.EnterRule(_localctx, 24, RULE_subgraph);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 119;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    if (_la == SUBGRAPH)
                    {
                        {
                            this.State = 115;
                            this.Match(SUBGRAPH);
                            this.State = 117;
                            this.ErrorHandler.Sync(this);
                            _la = this.TokenStream.LA(1);
                            if ((((_la) & ~0x3f) == 0
                                 && ((1L << _la) & ((1L << NUMBER) | (1L << STRING) | (1L << ID) | (1L << HTML_STRING)))
                                 != 0))
                            {
                                {
                                    this.State = 116;
                                    this.id();
                                }
                            }
                        }
                    }

                    this.State = 121;
                    this.Match(LBRACE);
                    this.State = 122;
                    this.statement_list();
                    this.State = 123;
                    this.Match(RBRACE);
                }
            }
            catch (RecognitionException re)
            {
                _localctx.exception = re;
                this.ErrorHandler.ReportError(this, re);
                this.ErrorHandler.Recover(this, re);
            }
            finally
            {
                this.ExitRule();
            }

            return _localctx;
        }

        public class A_listContext : ParserRuleContext
        {
            public A_listContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_a_list;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitA_list(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode[] ASSIGN()
            {
                return this.GetTokens(DotParser.ASSIGN);
            }

            public ITerminalNode ASSIGN(int i)
            {
                return this.GetToken(DotParser.ASSIGN, i);
            }

            public ITerminalNode[] COMMA()
            {
                return this.GetTokens(DotParser.COMMA);
            }

            public ITerminalNode COMMA(int i)
            {
                return this.GetToken(DotParser.COMMA, i);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterA_list(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitA_list(this);
            }

            public IdContext[] id()
            {
                return this.GetRuleContexts<IdContext>();
            }

            public IdContext id(int i)
            {
                return this.GetRuleContext<IdContext>(i);
            }
        }

        public class Attribute_listContext : ParserRuleContext
        {
            public Attribute_listContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_attribute_list;
                }
            }

            public A_listContext[] a_list()
            {
                return this.GetRuleContexts<A_listContext>();
            }

            public A_listContext a_list(int i)
            {
                return this.GetRuleContext<A_listContext>(i);
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitAttribute_list(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterAttribute_list(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitAttribute_list(this);
            }

            public ITerminalNode[] LBRACK()
            {
                return this.GetTokens(DotParser.LBRACK);
            }

            public ITerminalNode LBRACK(int i)
            {
                return this.GetToken(DotParser.LBRACK, i);
            }

            public ITerminalNode[] RBRACK()
            {
                return this.GetTokens(DotParser.RBRACK);
            }

            public ITerminalNode RBRACK(int i)
            {
                return this.GetToken(DotParser.RBRACK, i);
            }
        }

        public class Attribute_statementContext : ParserRuleContext
        {
            public Attribute_statementContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_attribute_statement;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitAttribute_statement(this);
                return visitor.VisitChildren(this);
            }

            public Attribute_listContext attribute_list()
            {
                return this.GetRuleContext<Attribute_listContext>(0);
            }

            public ITerminalNode EDGE()
            {
                return this.GetToken(DotParser.EDGE, 0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterAttribute_statement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitAttribute_statement(this);
            }

            public ITerminalNode GRAPH()
            {
                return this.GetToken(DotParser.GRAPH, 0);
            }

            public ITerminalNode NODE()
            {
                return this.GetToken(DotParser.NODE, 0);
            }
        }

        public class Edge_operationContext : ParserRuleContext
        {
            public Edge_operationContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_edge_operation;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitEdge_operation(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode ARROW()
            {
                return this.GetToken(DotParser.ARROW, 0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterEdge_operation(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitEdge_operation(this);
            }

            public ITerminalNode OPTION()
            {
                return this.GetToken(DotParser.OPTION, 0);
            }
        }

        public class Edge_statementContext : ParserRuleContext
        {
            public Edge_statementContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_edge_statement;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitEdge_statement(this);
                return visitor.VisitChildren(this);
            }

            public Attribute_listContext attribute_list()
            {
                return this.GetRuleContext<Attribute_listContext>(0);
            }

            public EdgeRHSContext edgeRHS()
            {
                return this.GetRuleContext<EdgeRHSContext>(0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterEdge_statement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitEdge_statement(this);
            }

            public Node_idContext node_id()
            {
                return this.GetRuleContext<Node_idContext>(0);
            }

            public SubgraphContext subgraph()
            {
                return this.GetRuleContext<SubgraphContext>(0);
            }
        }

        public class EdgeRHSContext : ParserRuleContext
        {
            public EdgeRHSContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_edgeRHS;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitEdgeRHS(this);
                return visitor.VisitChildren(this);
            }

            public Edge_operationContext[] edge_operation()
            {
                return this.GetRuleContexts<Edge_operationContext>();
            }

            public Edge_operationContext edge_operation(int i)
            {
                return this.GetRuleContext<Edge_operationContext>(i);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterEdgeRHS(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitEdgeRHS(this);
            }

            public Node_idContext[] node_id()
            {
                return this.GetRuleContexts<Node_idContext>();
            }

            public Node_idContext node_id(int i)
            {
                return this.GetRuleContext<Node_idContext>(i);
            }

            public SubgraphContext[] subgraph()
            {
                return this.GetRuleContexts<SubgraphContext>();
            }

            public SubgraphContext subgraph(int i)
            {
                return this.GetRuleContext<SubgraphContext>(i);
            }
        }

        public class GraphContext : ParserRuleContext
        {
            public GraphContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_graph;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitGraph(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode DIGRAPH()
            {
                return this.GetToken(DotParser.DIGRAPH, 0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterGraph(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitGraph(this);
            }

            public ITerminalNode GRAPH()
            {
                return this.GetToken(DotParser.GRAPH, 0);
            }

            public IdContext id()
            {
                return this.GetRuleContext<IdContext>(0);
            }

            public ITerminalNode LBRACE()
            {
                return this.GetToken(DotParser.LBRACE, 0);
            }

            public ITerminalNode RBRACE()
            {
                return this.GetToken(DotParser.RBRACE, 0);
            }

            public Statement_listContext statement_list()
            {
                return this.GetRuleContext<Statement_listContext>(0);
            }

            public ITerminalNode STRICT()
            {
                return this.GetToken(DotParser.STRICT, 0);
            }
        }

        public class IdContext : ParserRuleContext
        {
            public IdContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_id;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitId(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterId(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitId(this);
            }

            public ITerminalNode HTML_STRING()
            {
                return this.GetToken(DotParser.HTML_STRING, 0);
            }

            public ITerminalNode ID()
            {
                return this.GetToken(DotParser.ID, 0);
            }

            public ITerminalNode NUMBER()
            {
                return this.GetToken(DotParser.NUMBER, 0);
            }

            public ITerminalNode STRING()
            {
                return this.GetToken(DotParser.STRING, 0);
            }
        }

        public class Node_idContext : ParserRuleContext
        {
            public Node_idContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_node_id;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitNode_id(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterNode_id(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitNode_id(this);
            }

            public IdContext id()
            {
                return this.GetRuleContext<IdContext>(0);
            }

            public PortContext port()
            {
                return this.GetRuleContext<PortContext>(0);
            }
        }

        public class Node_statementContext : ParserRuleContext
        {
            public Node_statementContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_node_statement;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitNode_statement(this);
                return visitor.VisitChildren(this);
            }

            public Attribute_listContext attribute_list()
            {
                return this.GetRuleContext<Attribute_listContext>(0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterNode_statement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitNode_statement(this);
            }

            public Node_idContext node_id()
            {
                return this.GetRuleContext<Node_idContext>(0);
            }
        }

        public class PortContext : ParserRuleContext
        {
            public PortContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_port;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitPort(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode[] COLON()
            {
                return this.GetTokens(DotParser.COLON);
            }

            public ITerminalNode COLON(int i)
            {
                return this.GetToken(DotParser.COLON, i);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterPort(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitPort(this);
            }

            public IdContext[] id()
            {
                return this.GetRuleContexts<IdContext>();
            }

            public IdContext id(int i)
            {
                return this.GetRuleContext<IdContext>(i);
            }
        }

        public class Statement_listContext : ParserRuleContext
        {
            public Statement_listContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_statement_list;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitStatement_list(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterStatement_list(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitStatement_list(this);
            }

            public ITerminalNode[] SEMI()
            {
                return this.GetTokens(DotParser.SEMI);
            }

            public ITerminalNode SEMI(int i)
            {
                return this.GetToken(DotParser.SEMI, i);
            }

            public StatementContext[] statement()
            {
                return this.GetRuleContexts<StatementContext>();
            }

            public StatementContext statement(int i)
            {
                return this.GetRuleContext<StatementContext>(i);
            }
        }

        public class StatementContext : ParserRuleContext
        {
            public StatementContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_statement;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitStatement(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode ASSIGN()
            {
                return this.GetToken(DotParser.ASSIGN, 0);
            }

            public Attribute_statementContext attribute_statement()
            {
                return this.GetRuleContext<Attribute_statementContext>(0);
            }

            public Edge_statementContext edge_statement()
            {
                return this.GetRuleContext<Edge_statementContext>(0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterStatement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitStatement(this);
            }

            public IdContext[] id()
            {
                return this.GetRuleContexts<IdContext>();
            }

            public IdContext id(int i)
            {
                return this.GetRuleContext<IdContext>(i);
            }

            public Node_statementContext node_statement()
            {
                return this.GetRuleContext<Node_statementContext>(0);
            }

            public SubgraphContext subgraph()
            {
                return this.GetRuleContext<SubgraphContext>(0);
            }
        }

        public class SubgraphContext : ParserRuleContext
        {
            public SubgraphContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_subgraph;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as IDotParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitSubgraph(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.EnterSubgraph(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as IDotParserListener;
                if (typedListener != null) typedListener.ExitSubgraph(this);
            }

            public IdContext id()
            {
                return this.GetRuleContext<IdContext>(0);
            }

            public ITerminalNode LBRACE()
            {
                return this.GetToken(DotParser.LBRACE, 0);
            }

            public ITerminalNode RBRACE()
            {
                return this.GetToken(DotParser.RBRACE, 0);
            }

            public Statement_listContext statement_list()
            {
                return this.GetRuleContext<Statement_listContext>(0);
            }

            public ITerminalNode SUBGRAPH()
            {
                return this.GetToken(DotParser.SUBGRAPH, 0);
            }
        }
    }
} // namespace Mobilize.Grammar.Language