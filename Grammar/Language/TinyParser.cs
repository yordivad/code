// ***********************************************************************
// <copyright file="TinyParser.cs" company="Mobilize">
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
    public class TinyParser : Parser
    {
        public const int RULE_unit = 0;

        public const int RULE_method = 1;

        public const int RULE_parameter = 2;

        public const int RULE_block = 3;

        public const int RULE_statement = 4;

        public const int RULE_declaration = 5;

        public const int RULE_expression = 6;

        public const int RULE_term = 7;

        public const int RULE_id = 8;

        public const int RULE_integer = 9;

        public const int VAR = 1;

        public const int WHILE = 2;

        public const int RETURN = 3;

        public const int LPAREN = 4;

        public const int RPAREN = 5;

        public const int LBRACE = 6;

        public const int RBRACE = 7;

        public const int LBRACK = 8;

        public const int RBRACK = 9;

        public const int SEMI = 10;

        public const int COMMA = 11;

        public const int DOT = 12;

        public const int ASSIGN = 13;

        public const int GT = 14;

        public const int LT = 15;

        public const int BANG = 16;

        public const int TILDE = 17;

        public const int QUESTION = 18;

        public const int COLON = 19;

        public const int EQUAL = 20;

        public const int LE = 21;

        public const int GE = 22;

        public const int NOTEQUAL = 23;

        public const int AND = 24;

        public const int OR = 25;

        public const int INC = 26;

        public const int DEC = 27;

        public const int ADD = 28;

        public const int SUB = 29;

        public const int MUL = 30;

        public const int DIV = 31;

        public const int BITAND = 32;

        public const int BITOR = 33;

        public const int CARET = 34;

        public const int MOD = 35;

        public const int WS = 36;

        public const int COMMENT = 37;

        public const int LINE_COMMENT = 38;

        public const int STRING = 39;

        public const int INT = 40;

        private static readonly char[] _serializedATN =
            {
                '\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', '\x5964', '\x3', '*', 'h',
                '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t',
                '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x4', '\t', '\t',
                '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x3', '\x2', '\x6', '\x2', '\x18', '\n', '\x2',
                '\r', '\x2', '\xE', '\x2', '\x19', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3',
                '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', '\'',
                '\n', '\x4', '\f', '\x4', '\xE', '\x4', '*', '\v', '\x4', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', '.',
                '\n', '\x5', '\f', '\x5', '\xE', '\x5', '\x31', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6',
                '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3',
                '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', '\x6', '\x41', '\n', '\x6', '\x3', '\a', '\x3',
                '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'J', '\n', '\a',
                '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b',
                '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\a', '\b',
                '[', '\n', '\b', '\f', '\b', '\xE', '\b', '^', '\v', '\b', '\x3', '\t', '\x3', '\t', '\x5', '\t',
                '\x62', '\n', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x2', '\x3',
                '\xE', '\f', '\x2', '\x4', '\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x14', '\x2', '\x5', '\x3',
                '\x2', '\x1E', '\x1F', '\x4', '\x2', ' ', '!', '%', '%', '\x4', '\x2', '\x10', '\x11', '\x17', '\x18',
                '\x2', 'i', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x4', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x6',
                '#', '\x3', '\x2', '\x2', '\x2', '\b', '+', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', '\x2', '\x2',
                '\x2', '\f', 'I', '\x3', '\x2', '\x2', '\x2', '\xE', 'K', '\x3', '\x2', '\x2', '\x2', '\x10', '\x61',
                '\x3', '\x2', '\x2', '\x2', '\x12', '\x63', '\x3', '\x2', '\x2', '\x2', '\x14', '\x65', '\x3', '\x2',
                '\x2', '\x2', '\x16', '\x18', '\x5', '\x4', '\x3', '\x2', '\x17', '\x16', '\x3', '\x2', '\x2', '\x2',
                '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x17', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A',
                '\x3', '\x2', '\x2', '\x2', '\x1A', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', '\a', '\x2',
                '\x2', '\x3', '\x1C', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1E', '\x5', '\x12', '\n', '\x2',
                '\x1E', '\x1F', '\a', '\x6', '\x2', '\x2', '\x1F', ' ', '\x5', '\x6', '\x4', '\x2', ' ', '!', '\a',
                '\a', '\x2', '\x2', '!', '\"', '\x5', '\b', '\x5', '\x2', '\"', '\x5', '\x3', '\x2', '\x2', '\x2', '#',
                '(', '\x5', '\x12', '\n', '\x2', '$', '%', '\a', '\r', '\x2', '\x2', '%', '\'', '\x5', '\x12', '\n',
                '\x2', '&', '$', '\x3', '\x2', '\x2', '\x2', '\'', '*', '\x3', '\x2', '\x2', '\x2', '(', '&', '\x3',
                '\x2', '\x2', '\x2', '(', ')', '\x3', '\x2', '\x2', '\x2', ')', '\a', '\x3', '\x2', '\x2', '\x2', '*',
                '(', '\x3', '\x2', '\x2', '\x2', '+', '/', '\a', '\b', '\x2', '\x2', ',', '.', '\x5', '\n', '\x6',
                '\x2', '-', ',', '\x3', '\x2', '\x2', '\x2', '.', '\x31', '\x3', '\x2', '\x2', '\x2', '/', '-', '\x3',
                '\x2', '\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '\x32', '\x3', '\x2', '\x2',
                '\x2', '\x31', '/', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', '\a', '\t', '\x2', '\x2', '\x33', '\t',
                '\x3', '\x2', '\x2', '\x2', '\x34', '\x41', '\x5', '\b', '\x5', '\x2', '\x35', '\x41', '\x5', '\f',
                '\a', '\x2', '\x36', '\x37', '\a', '\x4', '\x2', '\x2', '\x37', '\x38', '\a', '\x6', '\x2', '\x2',
                '\x38', '\x39', '\x5', '\xE', '\b', '\x2', '\x39', ':', '\a', '\a', '\x2', '\x2', ':', ';', '\x5', '\n',
                '\x6', '\x2', ';', '\x41', '\x3', '\x2', '\x2', '\x2', '<', '=', '\a', '\x5', '\x2', '\x2', '=', '>',
                '\x5', '\xE', '\b', '\x2', '>', '?', '\a', '\f', '\x2', '\x2', '?', '\x41', '\x3', '\x2', '\x2', '\x2',
                '@', '\x34', '\x3', '\x2', '\x2', '\x2', '@', '\x35', '\x3', '\x2', '\x2', '\x2', '@', '\x36', '\x3',
                '\x2', '\x2', '\x2', '@', '<', '\x3', '\x2', '\x2', '\x2', '\x41', '\v', '\x3', '\x2', '\x2', '\x2',
                '\x42', '\x43', '\x5', '\xE', '\b', '\x2', '\x43', '\x44', '\a', '\f', '\x2', '\x2', '\x44', 'J', '\x3',
                '\x2', '\x2', '\x2', '\x45', '\x46', '\a', '\x3', '\x2', '\x2', '\x46', 'G', '\x5', '\xE', '\b', '\x2',
                'G', 'H', '\a', '\f', '\x2', '\x2', 'H', 'J', '\x3', '\x2', '\x2', '\x2', 'I', '\x42', '\x3', '\x2',
                '\x2', '\x2', 'I', '\x45', '\x3', '\x2', '\x2', '\x2', 'J', '\r', '\x3', '\x2', '\x2', '\x2', 'K', 'L',
                '\b', '\b', '\x1', '\x2', 'L', 'M', '\x5', '\x10', '\t', '\x2', 'M', '\\', '\x3', '\x2', '\x2', '\x2',
                'N', 'O', '\f', '\x6', '\x2', '\x2', 'O', 'P', '\a', '\xF', '\x2', '\x2', 'P', '[', '\x5', '\xE', '\b',
                '\a', 'Q', 'R', '\f', '\x5', '\x2', '\x2', 'R', 'S', '\t', '\x2', '\x2', '\x2', 'S', '[', '\x5', '\xE',
                '\b', '\x6', 'T', 'U', '\f', '\x4', '\x2', '\x2', 'U', 'V', '\t', '\x3', '\x2', '\x2', 'V', '[', '\x5',
                '\xE', '\b', '\x5', 'W', 'X', '\f', '\x3', '\x2', '\x2', 'X', 'Y', '\t', '\x4', '\x2', '\x2', 'Y', '[',
                '\x5', '\xE', '\b', '\x4', 'Z', 'N', '\x3', '\x2', '\x2', '\x2', 'Z', 'Q', '\x3', '\x2', '\x2', '\x2',
                'Z', 'T', '\x3', '\x2', '\x2', '\x2', 'Z', 'W', '\x3', '\x2', '\x2', '\x2', '[', '^', '\x3', '\x2',
                '\x2', '\x2', '\\', 'Z', '\x3', '\x2', '\x2', '\x2', '\\', ']', '\x3', '\x2', '\x2', '\x2', ']', '\xF',
                '\x3', '\x2', '\x2', '\x2', '^', '\\', '\x3', '\x2', '\x2', '\x2', '_', '\x62', '\x5', '\x12', '\n',
                '\x2', '`', '\x62', '\x5', '\x14', '\v', '\x2', '\x61', '_', '\x3', '\x2', '\x2', '\x2', '\x61', '`',
                '\x3', '\x2', '\x2', '\x2', '\x62', '\x11', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', ')',
                '\x2', '\x2', '\x64', '\x13', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\a', '*', '\x2', '\x2',
                '\x66', '\x15', '\x3', '\x2', '\x2', '\x2', '\n', '\x19', '(', '/', '@', 'I', 'Z', '\\', '\x61'
            };

        public static readonly ATN _ATN = new ATNDeserializer().Deserialize(_serializedATN);

        private static readonly string[] _LiteralNames =
            {
                null, "'var'", "'while'", "'return'", "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'",
                "'='", "'>'", "'<'", "'!'", "'~'", "'?'", "':'", "'=='", "'<='", "'>='", "'!='", "'&&'", "'||'", "'++'",
                "'--'", "'+'", "'-'", "'*'", "'/'", "'&'", "'|'", "'^'", "'%'"
            };

        private static readonly string[] _SymbolicNames =
            {
                null, "VAR", "WHILE", "RETURN", "LPAREN", "RPAREN", "LBRACE", "RBRACE", "LBRACK", "RBRACK", "SEMI",
                "COMMA", "DOT", "ASSIGN", "GT", "LT", "BANG", "TILDE", "QUESTION", "COLON", "EQUAL", "LE", "GE",
                "NOTEQUAL", "AND", "OR", "INC", "DEC", "ADD", "SUB", "MUL", "DIV", "BITAND", "BITOR", "CARET", "MOD",
                "WS", "COMMENT", "LINE_COMMENT", "STRING", "INT"
            };

        public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

        public static readonly string[] ruleNames =
            {
                "unit", "method", "parameter", "block", "statement", "declaration", "expression", "term", "id",
                "integer"
            };

        protected static DFA[] decisionToDFA;

        protected static PredictionContextCache sharedContextCache = new PredictionContextCache();

        static TinyParser()
        {
            decisionToDFA = new DFA[_ATN.NumberOfDecisions];
            for (var i = 0; i < _ATN.NumberOfDecisions; i++)
            {
                decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
            }
        }

        public TinyParser(ITokenStream input)
            : this(input, Console.Out, Console.Error)
        {
        }

        public TinyParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
            this.Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
        }

        public override string GrammarFileName
        {
            get
            {
                return "TinyParser.g4";
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
        public BlockContext block()
        {
            var _localctx = new BlockContext(this.Context, this.State);
            this.EnterRule(_localctx, 6, RULE_block);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 41;
                    this.Match(LBRACE);
                    this.State = 45;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    while ((((_la) & ~0x3f) == 0
                            && ((1L << _la) & ((1L << VAR) | (1L << WHILE) | (1L << RETURN) | (1L << LBRACE)
                                               | (1L << STRING) | (1L << INT))) != 0))
                    {
                        {
                            {
                                this.State = 42;
                                this.statement();
                            }
                        }

                        this.State = 47;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }

                    this.State = 48;
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
        public DeclarationContext declaration()
        {
            var _localctx = new DeclarationContext(this.Context, this.State);
            this.EnterRule(_localctx, 10, RULE_declaration);
            try
            {
                this.State = 71;
                this.ErrorHandler.Sync(this);
                switch (this.TokenStream.LA(1))
                {
                    case STRING:
                    case INT:
                        this.EnterOuterAlt(_localctx, 1);
                        {
                            this.State = 64;
                            this.expression(0);
                            this.State = 65;
                            this.Match(SEMI);
                        }

                        break;
                    case VAR:
                        this.EnterOuterAlt(_localctx, 2);
                        {
                            this.State = 67;
                            this.Match(VAR);
                            this.State = 68;
                            this.expression(0);
                            this.State = 69;
                            this.Match(SEMI);
                        }

                        break;
                    default:
                        throw new NoViableAltException(this);
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
        public ExpressionContext expression()
        {
            return this.expression(0);
        }

        [RuleVersion(0)]
        public IdContext id()
        {
            var _localctx = new IdContext(this.Context, this.State);
            this.EnterRule(_localctx, 16, RULE_id);
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 97;
                    this.Match(STRING);
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
        public IntegerContext integer()
        {
            var _localctx = new IntegerContext(this.Context, this.State);
            this.EnterRule(_localctx, 18, RULE_integer);
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 99;
                    this.Match(INT);
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
        public MethodContext method()
        {
            var _localctx = new MethodContext(this.Context, this.State);
            this.EnterRule(_localctx, 2, RULE_method);
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 27;
                    this.id();
                    this.State = 28;
                    this.Match(LPAREN);
                    this.State = 29;
                    this.parameter();
                    this.State = 30;
                    this.Match(RPAREN);
                    this.State = 31;
                    this.block();
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
        public ParameterContext parameter()
        {
            var _localctx = new ParameterContext(this.Context, this.State);
            this.EnterRule(_localctx, 4, RULE_parameter);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 33;
                    this.id();
                    this.State = 38;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    while (_la == COMMA)
                    {
                        {
                            {
                                this.State = 34;
                                this.Match(COMMA);
                                this.State = 35;
                                this.id();
                            }
                        }

                        this.State = 40;
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

        public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex)
        {
            switch (ruleIndex)
            {
                case 6: return this.expression_sempred((ExpressionContext)_localctx, predIndex);
            }

            return true;
        }

        [RuleVersion(0)]
        public StatementContext statement()
        {
            var _localctx = new StatementContext(this.Context, this.State);
            this.EnterRule(_localctx, 8, RULE_statement);
            try
            {
                this.State = 62;
                this.ErrorHandler.Sync(this);
                switch (this.TokenStream.LA(1))
                {
                    case LBRACE:
                        this.EnterOuterAlt(_localctx, 1);
                        {
                            this.State = 50;
                            this.block();
                        }

                        break;
                    case VAR:
                    case STRING:
                    case INT:
                        this.EnterOuterAlt(_localctx, 2);
                        {
                            this.State = 51;
                            this.declaration();
                        }

                        break;
                    case WHILE:
                        this.EnterOuterAlt(_localctx, 3);
                        {
                            this.State = 52;
                            this.Match(WHILE);
                            this.State = 53;
                            this.Match(LPAREN);
                            this.State = 54;
                            this.expression(0);
                            this.State = 55;
                            this.Match(RPAREN);
                            this.State = 56;
                            this.statement();
                        }

                        break;
                    case RETURN:
                        this.EnterOuterAlt(_localctx, 4);
                        {
                            this.State = 58;
                            this.Match(RETURN);
                            this.State = 59;
                            this.expression(0);
                            this.State = 60;
                            this.Match(SEMI);
                        }

                        break;
                    default:
                        throw new NoViableAltException(this);
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
        public TermContext term()
        {
            var _localctx = new TermContext(this.Context, this.State);
            this.EnterRule(_localctx, 14, RULE_term);
            try
            {
                this.State = 95;
                this.ErrorHandler.Sync(this);
                switch (this.TokenStream.LA(1))
                {
                    case STRING:
                        this.EnterOuterAlt(_localctx, 1);
                        {
                            this.State = 93;
                            this.id();
                        }

                        break;
                    case INT:
                        this.EnterOuterAlt(_localctx, 2);
                        {
                            this.State = 94;
                            this.integer();
                        }

                        break;
                    default:
                        throw new NoViableAltException(this);
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
        public UnitContext unit()
        {
            var _localctx = new UnitContext(this.Context, this.State);
            this.EnterRule(_localctx, 0, RULE_unit);
            int _la;
            try
            {
                this.EnterOuterAlt(_localctx, 1);
                {
                    this.State = 21;
                    this.ErrorHandler.Sync(this);
                    _la = this.TokenStream.LA(1);
                    do
                    {
                        {
                            {
                                this.State = 20;
                                this.method();
                            }
                        }

                        this.State = 23;
                        this.ErrorHandler.Sync(this);
                        _la = this.TokenStream.LA(1);
                    }
                    while (_la == STRING);

                    this.State = 25;
                    this.Match(Eof);
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

        private ExpressionContext expression(int _p)
        {
            var _parentctx = this.Context;
            var _parentState = this.State;
            var _localctx = new ExpressionContext(this.Context, _parentState);
            var _prevctx = _localctx;
            var _startState = 12;
            this.EnterRecursionRule(_localctx, 12, RULE_expression, _p);
            int _la;
            try
            {
                int _alt;
                this.EnterOuterAlt(_localctx, 1);
                {
                    {
                        this.State = 74;
                        this.term();
                    }

                    this.Context.Stop = this.TokenStream.LT(-1);
                    this.State = 90;
                    this.ErrorHandler.Sync(this);
                    _alt = this.Interpreter.AdaptivePredict(this.TokenStream, 6, this.Context);
                    while (_alt != 2 && _alt != ATN.INVALID_ALT_NUMBER)
                    {
                        if (_alt == 1)
                        {
                            if (this.ParseListeners != null) this.TriggerExitRuleEvent();
                            _prevctx = _localctx;
                            {
                                this.State = 88;
                                this.ErrorHandler.Sync(this);
                                switch (this.Interpreter.AdaptivePredict(this.TokenStream, 5, this.Context))
                                {
                                    case 1:
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            this.PushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            this.State = 76;
                                            if (!(this.Precpred(this.Context, 4)))
                                                throw new FailedPredicateException(this, "Precpred(Context, 4)");
                                            this.State = 77;
                                            this.Match(ASSIGN);
                                            this.State = 78;
                                            this.expression(5);
                                        }

                                        break;
                                    case 2:
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            this.PushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            this.State = 79;
                                            if (!(this.Precpred(this.Context, 3)))
                                                throw new FailedPredicateException(this, "Precpred(Context, 3)");
                                            this.State = 80;
                                            _localctx.bop = this.TokenStream.LT(1);
                                            _la = this.TokenStream.LA(1);
                                            if (!(_la == ADD || _la == SUB))
                                            {
                                                _localctx.bop = this.ErrorHandler.RecoverInline(this);
                                            }
                                            else
                                            {
                                                this.ErrorHandler.ReportMatch(this);
                                                this.Consume();
                                            }

                                            this.State = 81;
                                            this.expression(4);
                                        }

                                        break;
                                    case 3:
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            this.PushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            this.State = 82;
                                            if (!(this.Precpred(this.Context, 2)))
                                                throw new FailedPredicateException(this, "Precpred(Context, 2)");
                                            this.State = 83;
                                            _localctx.bop = this.TokenStream.LT(1);
                                            _la = this.TokenStream.LA(1);
                                            if (!((((_la) & ~0x3f) == 0
                                                   && ((1L << _la) & ((1L << MUL) | (1L << DIV) | (1L << MOD))) != 0)))
                                            {
                                                _localctx.bop = this.ErrorHandler.RecoverInline(this);
                                            }
                                            else
                                            {
                                                this.ErrorHandler.ReportMatch(this);
                                                this.Consume();
                                            }

                                            this.State = 84;
                                            this.expression(3);
                                        }

                                        break;
                                    case 4:
                                        {
                                            _localctx = new ExpressionContext(_parentctx, _parentState);
                                            this.PushNewRecursionContext(_localctx, _startState, RULE_expression);
                                            this.State = 85;
                                            if (!(this.Precpred(this.Context, 1)))
                                                throw new FailedPredicateException(this, "Precpred(Context, 1)");
                                            this.State = 86;
                                            _localctx.bop = this.TokenStream.LT(1);
                                            _la = this.TokenStream.LA(1);
                                            if (!((((_la) & ~0x3f) == 0
                                                   && ((1L << _la) & ((1L << GT) | (1L << LT) | (1L << LE) | (1L << GE))
                                                      ) != 0)))
                                            {
                                                _localctx.bop = this.ErrorHandler.RecoverInline(this);
                                            }
                                            else
                                            {
                                                this.ErrorHandler.ReportMatch(this);
                                                this.Consume();
                                            }

                                            this.State = 87;
                                            this.expression(2);
                                        }

                                        break;
                                }
                            }
                        }

                        this.State = 92;
                        this.ErrorHandler.Sync(this);
                        _alt = this.Interpreter.AdaptivePredict(this.TokenStream, 6, this.Context);
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
                this.UnrollRecursionContexts(_parentctx);
            }

            return _localctx;
        }

        private bool expression_sempred(ExpressionContext _localctx, int predIndex)
        {
            switch (predIndex)
            {
                case 0: return this.Precpred(this.Context, 4);
                case 1: return this.Precpred(this.Context, 3);
                case 2: return this.Precpred(this.Context, 2);
                case 3: return this.Precpred(this.Context, 1);
            }

            return true;
        }

        public class BlockContext : ParserRuleContext
        {
            public BlockContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_block;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitBlock(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterBlock(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitBlock(this);
            }

            public ITerminalNode LBRACE()
            {
                return this.GetToken(TinyParser.LBRACE, 0);
            }

            public ITerminalNode RBRACE()
            {
                return this.GetToken(TinyParser.RBRACE, 0);
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

        public class DeclarationContext : ParserRuleContext
        {
            public DeclarationContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_declaration;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitDeclaration(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterDeclaration(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitDeclaration(this);
            }

            public ExpressionContext expression()
            {
                return this.GetRuleContext<ExpressionContext>(0);
            }

            public ITerminalNode SEMI()
            {
                return this.GetToken(TinyParser.SEMI, 0);
            }

            public ITerminalNode VAR()
            {
                return this.GetToken(TinyParser.VAR, 0);
            }
        }

        public class ExpressionContext : ParserRuleContext
        {
            public IToken bop;

            public ExpressionContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_expression;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitExpression(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode ADD()
            {
                return this.GetToken(TinyParser.ADD, 0);
            }

            public ITerminalNode ASSIGN()
            {
                return this.GetToken(TinyParser.ASSIGN, 0);
            }

            public ITerminalNode DIV()
            {
                return this.GetToken(TinyParser.DIV, 0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterExpression(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitExpression(this);
            }

            public ExpressionContext[] expression()
            {
                return this.GetRuleContexts<ExpressionContext>();
            }

            public ExpressionContext expression(int i)
            {
                return this.GetRuleContext<ExpressionContext>(i);
            }

            public ITerminalNode GE()
            {
                return this.GetToken(TinyParser.GE, 0);
            }

            public ITerminalNode GT()
            {
                return this.GetToken(TinyParser.GT, 0);
            }

            public ITerminalNode LE()
            {
                return this.GetToken(TinyParser.LE, 0);
            }

            public ITerminalNode LT()
            {
                return this.GetToken(TinyParser.LT, 0);
            }

            public ITerminalNode MOD()
            {
                return this.GetToken(TinyParser.MOD, 0);
            }

            public ITerminalNode MUL()
            {
                return this.GetToken(TinyParser.MUL, 0);
            }

            public ITerminalNode SUB()
            {
                return this.GetToken(TinyParser.SUB, 0);
            }

            public TermContext term()
            {
                return this.GetRuleContext<TermContext>(0);
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
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitId(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterId(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitId(this);
            }

            public ITerminalNode STRING()
            {
                return this.GetToken(TinyParser.STRING, 0);
            }
        }

        public class IntegerContext : ParserRuleContext
        {
            public IntegerContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_integer;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitInteger(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterInteger(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitInteger(this);
            }

            public ITerminalNode INT()
            {
                return this.GetToken(TinyParser.INT, 0);
            }
        }

        public class MethodContext : ParserRuleContext
        {
            public MethodContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_method;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitMethod(this);
                return visitor.VisitChildren(this);
            }

            public BlockContext block()
            {
                return this.GetRuleContext<BlockContext>(0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterMethod(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitMethod(this);
            }

            public IdContext id()
            {
                return this.GetRuleContext<IdContext>(0);
            }

            public ITerminalNode LPAREN()
            {
                return this.GetToken(TinyParser.LPAREN, 0);
            }

            public ParameterContext parameter()
            {
                return this.GetRuleContext<ParameterContext>(0);
            }

            public ITerminalNode RPAREN()
            {
                return this.GetToken(TinyParser.RPAREN, 0);
            }
        }

        public class ParameterContext : ParserRuleContext
        {
            public ParameterContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_parameter;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitParameter(this);
                return visitor.VisitChildren(this);
            }

            public ITerminalNode[] COMMA()
            {
                return this.GetTokens(TinyParser.COMMA);
            }

            public ITerminalNode COMMA(int i)
            {
                return this.GetToken(TinyParser.COMMA, i);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterParameter(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitParameter(this);
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
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitStatement(this);
                return visitor.VisitChildren(this);
            }

            public BlockContext block()
            {
                return this.GetRuleContext<BlockContext>(0);
            }

            public DeclarationContext declaration()
            {
                return this.GetRuleContext<DeclarationContext>(0);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterStatement(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitStatement(this);
            }

            public ExpressionContext expression()
            {
                return this.GetRuleContext<ExpressionContext>(0);
            }

            public ITerminalNode LPAREN()
            {
                return this.GetToken(TinyParser.LPAREN, 0);
            }

            public ITerminalNode RETURN()
            {
                return this.GetToken(TinyParser.RETURN, 0);
            }

            public ITerminalNode RPAREN()
            {
                return this.GetToken(TinyParser.RPAREN, 0);
            }

            public ITerminalNode SEMI()
            {
                return this.GetToken(TinyParser.SEMI, 0);
            }

            public StatementContext statement()
            {
                return this.GetRuleContext<StatementContext>(0);
            }

            public ITerminalNode WHILE()
            {
                return this.GetToken(TinyParser.WHILE, 0);
            }
        }

        public class TermContext : ParserRuleContext
        {
            public TermContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_term;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitTerm(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterTerm(this);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitTerm(this);
            }

            public IdContext id()
            {
                return this.GetRuleContext<IdContext>(0);
            }

            public IntegerContext integer()
            {
                return this.GetRuleContext<IntegerContext>(0);
            }
        }

        public class UnitContext : ParserRuleContext
        {
            public UnitContext(ParserRuleContext parent, int invokingState)
                : base(parent, invokingState)
            {
            }

            public override int RuleIndex
            {
                get
                {
                    return RULE_unit;
                }
            }

            public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor)
            {
                var typedVisitor = visitor as ITinyParserVisitor<TResult>;
                if (typedVisitor != null) return typedVisitor.VisitUnit(this);
                return visitor.VisitChildren(this);
            }

            public override void EnterRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.EnterUnit(this);
            }

            public ITerminalNode Eof()
            {
                return this.GetToken(TinyParser.Eof, 0);
            }

            public override void ExitRule(IParseTreeListener listener)
            {
                var typedListener = listener as ITinyParserListener;
                if (typedListener != null) typedListener.ExitUnit(this);
            }

            public MethodContext[] method()
            {
                return this.GetRuleContexts<MethodContext>();
            }

            public MethodContext method(int i)
            {
                return this.GetRuleContext<MethodContext>(i);
            }
        }
    }
} // namespace Mobilize.Grammar.Language