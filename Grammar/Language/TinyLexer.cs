// ***********************************************************************
// <copyright file="TinyLexer.cs" company="Mobilize">
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

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [CLSCompliant(false)]
    public class TinyLexer : Lexer
    {
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
                '\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', '\x5964', '\x2', '*',
                '\xD6', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4',
                '\x4', '\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b',
                '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f',
                '\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t',
                '\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', '\x13', '\x4',
                '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', '\x16', '\t', '\x16', '\x4', '\x17', '\t',
                '\x17', '\x4', '\x18', '\t', '\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4',
                '\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', '\x1D', '\x4', '\x1E', '\t',
                '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', ' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t',
                '\"', '\x4', '#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', '\t', '&', '\x4',
                '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', '\t', ')', '\x3', '\x2', '\x3', '\x2', '\x3',
                '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3',
                '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3',
                '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b',
                '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f',
                '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3',
                '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3',
                '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3',
                '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3',
                '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3',
                '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3',
                '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!',
                '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', '\x6', '%',
                '\xAE', '\n', '%', '\r', '%', '\xE', '%', '\xAF', '\x3', '%', '\x3', '%', '\x3', '&', '\x3', '&', '\x3',
                '&', '\x3', '&', '\a', '&', '\xB8', '\n', '&', '\f', '&', '\xE', '&', '\xBB', '\v', '&', '\x3', '&',
                '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '\'',
                '\a', '\'', '\xC6', '\n', '\'', '\f', '\'', '\xE', '\'', '\xC9', '\v', '\'', '\x3', '\'', '\x3', '\'',
                '\x3', '(', '\x6', '(', '\xCE', '\n', '(', '\r', '(', '\xE', '(', '\xCF', '\x3', ')', '\x6', ')',
                '\xD3', '\n', ')', '\r', ')', '\xE', ')', '\xD4', '\x3', '\xB9', '\x2', '*', '\x3', '\x3', '\x5', '\x4',
                '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f',
                '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13',
                '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33',
                '\x1B', '\x35', '\x1C', '\x37', '\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"',
                '\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', 'Q', '*', '\x3', '\x2',
                '\x6', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', '\x2', '\f', '\f', '\xF', '\xF',
                '\x3', '\x2', '\x63', '|', '\x3', '\x2', '\x32', ';', '\x2', '\xDA', '\x2', '\x3', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t',
                '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2',
                '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3',
                '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!',
                '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+',
                '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2',
                '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', '\x3',
                '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2',
                '\x2', '?', '\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3',
                '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2',
                '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3',
                '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2',
                '\x3', 'S', '\x3', '\x2', '\x2', '\x2', '\x5', 'W', '\x3', '\x2', '\x2', '\x2', '\a', ']', '\x3', '\x2',
                '\x2', '\x2', '\t', '\x64', '\x3', '\x2', '\x2', '\x2', '\v', '\x66', '\x3', '\x2', '\x2', '\x2', '\r',
                'h', '\x3', '\x2', '\x2', '\x2', '\xF', 'j', '\x3', '\x2', '\x2', '\x2', '\x11', 'l', '\x3', '\x2',
                '\x2', '\x2', '\x13', 'n', '\x3', '\x2', '\x2', '\x2', '\x15', 'p', '\x3', '\x2', '\x2', '\x2', '\x17',
                'r', '\x3', '\x2', '\x2', '\x2', '\x19', 't', '\x3', '\x2', '\x2', '\x2', '\x1B', 'v', '\x3', '\x2',
                '\x2', '\x2', '\x1D', 'x', '\x3', '\x2', '\x2', '\x2', '\x1F', 'z', '\x3', '\x2', '\x2', '\x2', '!',
                '|', '\x3', '\x2', '\x2', '\x2', '#', '~', '\x3', '\x2', '\x2', '\x2', '%', '\x80', '\x3', '\x2', '\x2',
                '\x2', '\'', '\x82', '\x3', '\x2', '\x2', '\x2', ')', '\x84', '\x3', '\x2', '\x2', '\x2', '+', '\x87',
                '\x3', '\x2', '\x2', '\x2', '-', '\x8A', '\x3', '\x2', '\x2', '\x2', '/', '\x8D', '\x3', '\x2', '\x2',
                '\x2', '\x31', '\x90', '\x3', '\x2', '\x2', '\x2', '\x33', '\x93', '\x3', '\x2', '\x2', '\x2', '\x35',
                '\x96', '\x3', '\x2', '\x2', '\x2', '\x37', '\x99', '\x3', '\x2', '\x2', '\x2', '\x39', '\x9C', '\x3',
                '\x2', '\x2', '\x2', ';', '\x9E', '\x3', '\x2', '\x2', '\x2', '=', '\xA0', '\x3', '\x2', '\x2', '\x2',
                '?', '\xA2', '\x3', '\x2', '\x2', '\x2', '\x41', '\xA4', '\x3', '\x2', '\x2', '\x2', '\x43', '\xA6',
                '\x3', '\x2', '\x2', '\x2', '\x45', '\xA8', '\x3', '\x2', '\x2', '\x2', 'G', '\xAA', '\x3', '\x2',
                '\x2', '\x2', 'I', '\xAD', '\x3', '\x2', '\x2', '\x2', 'K', '\xB3', '\x3', '\x2', '\x2', '\x2', 'M',
                '\xC1', '\x3', '\x2', '\x2', '\x2', 'O', '\xCD', '\x3', '\x2', '\x2', '\x2', 'Q', '\xD2', '\x3', '\x2',
                '\x2', '\x2', 'S', 'T', '\a', 'x', '\x2', '\x2', 'T', 'U', '\a', '\x63', '\x2', '\x2', 'U', 'V', '\a',
                't', '\x2', '\x2', 'V', '\x4', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 'y', '\x2', '\x2', 'X', 'Y',
                '\a', 'j', '\x2', '\x2', 'Y', 'Z', '\a', 'k', '\x2', '\x2', 'Z', '[', '\a', 'n', '\x2', '\x2', '[',
                '\\', '\a', 'g', '\x2', '\x2', '\\', '\x6', '\x3', '\x2', '\x2', '\x2', ']', '^', '\a', 't', '\x2',
                '\x2', '^', '_', '\a', 'g', '\x2', '\x2', '_', '`', '\a', 'v', '\x2', '\x2', '`', '\x61', '\a', 'w',
                '\x2', '\x2', '\x61', '\x62', '\a', 't', '\x2', '\x2', '\x62', '\x63', '\a', 'p', '\x2', '\x2', '\x63',
                '\b', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', '*', '\x2', '\x2', '\x65', '\n', '\x3', '\x2',
                '\x2', '\x2', '\x66', 'g', '\a', '+', '\x2', '\x2', 'g', '\f', '\x3', '\x2', '\x2', '\x2', 'h', 'i',
                '\a', '}', '\x2', '\x2', 'i', '\xE', '\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', '\x7F', '\x2', '\x2',
                'k', '\x10', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', ']', '\x2', '\x2', 'm', '\x12', '\x3', '\x2',
                '\x2', '\x2', 'n', 'o', '\a', '_', '\x2', '\x2', 'o', '\x14', '\x3', '\x2', '\x2', '\x2', 'p', 'q',
                '\a', '=', '\x2', '\x2', 'q', '\x16', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', '.', '\x2', '\x2',
                's', '\x18', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\a', '\x30', '\x2', '\x2', 'u', '\x1A', '\x3',
                '\x2', '\x2', '\x2', 'v', 'w', '\a', '?', '\x2', '\x2', 'w', '\x1C', '\x3', '\x2', '\x2', '\x2', 'x',
                'y', '\a', '@', '\x2', '\x2', 'y', '\x1E', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', '>', '\x2',
                '\x2', '{', ' ', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', '#', '\x2', '\x2', '}', '\"', '\x3', '\x2',
                '\x2', '\x2', '~', '\x7F', '\a', '\x80', '\x2', '\x2', '\x7F', '$', '\x3', '\x2', '\x2', '\x2', '\x80',
                '\x81', '\a', '\x41', '\x2', '\x2', '\x81', '&', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\a', '<',
                '\x2', '\x2', '\x83', '(', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '?', '\x2', '\x2', '\x85',
                '\x86', '\a', '?', '\x2', '\x2', '\x86', '*', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\a', '>',
                '\x2', '\x2', '\x88', '\x89', '\a', '?', '\x2', '\x2', '\x89', ',', '\x3', '\x2', '\x2', '\x2', '\x8A',
                '\x8B', '\a', '@', '\x2', '\x2', '\x8B', '\x8C', '\a', '?', '\x2', '\x2', '\x8C', '.', '\x3', '\x2',
                '\x2', '\x2', '\x8D', '\x8E', '\a', '#', '\x2', '\x2', '\x8E', '\x8F', '\a', '?', '\x2', '\x2', '\x8F',
                '\x30', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\a', '(', '\x2', '\x2', '\x91', '\x92', '\a', '(',
                '\x2', '\x2', '\x92', '\x32', '\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\a', '~', '\x2', '\x2',
                '\x94', '\x95', '\a', '~', '\x2', '\x2', '\x95', '\x34', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97',
                '\a', '-', '\x2', '\x2', '\x97', '\x98', '\a', '-', '\x2', '\x2', '\x98', '\x36', '\x3', '\x2', '\x2',
                '\x2', '\x99', '\x9A', '\a', '/', '\x2', '\x2', '\x9A', '\x9B', '\a', '/', '\x2', '\x2', '\x9B', '\x38',
                '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', '\a', '-', '\x2', '\x2', '\x9D', ':', '\x3', '\x2', '\x2',
                '\x2', '\x9E', '\x9F', '\a', '/', '\x2', '\x2', '\x9F', '<', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1',
                '\a', ',', '\x2', '\x2', '\xA1', '>', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', '\a', '\x31', '\x2',
                '\x2', '\xA3', '@', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\a', '(', '\x2', '\x2', '\xA5', '\x42',
                '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA7', '\a', '~', '\x2', '\x2', '\xA7', '\x44', '\x3', '\x2',
                '\x2', '\x2', '\xA8', '\xA9', '\a', '`', '\x2', '\x2', '\xA9', '\x46', '\x3', '\x2', '\x2', '\x2',
                '\xAA', '\xAB', '\a', '\'', '\x2', '\x2', '\xAB', 'H', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAE', '\t',
                '\x2', '\x2', '\x2', '\xAD', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\x3', '\x2', '\x2',
                '\x2', '\xAF', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', '\x2', '\xB0',
                '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB2', '\b', '%', '\x2', '\x2', '\xB2', 'J', '\x3', '\x2',
                '\x2', '\x2', '\xB3', '\xB4', '\a', '\x31', '\x2', '\x2', '\xB4', '\xB5', '\a', ',', '\x2', '\x2',
                '\xB5', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB8', '\v', '\x2', '\x2', '\x2', '\xB7', '\xB6',
                '\x3', '\x2', '\x2', '\x2', '\xB8', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\x3', '\x2',
                '\x2', '\x2', '\xB9', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBC', '\x3', '\x2', '\x2', '\x2',
                '\xBB', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xBC', '\xBD', '\a', ',', '\x2', '\x2', '\xBD', '\xBE',
                '\a', '\x31', '\x2', '\x2', '\xBE', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', '\b', '&',
                '\x2', '\x2', '\xC0', 'L', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC2', '\a', '\x31', '\x2', '\x2',
                '\xC2', '\xC3', '\a', '\x31', '\x2', '\x2', '\xC3', '\xC7', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC6',
                '\n', '\x3', '\x2', '\x2', '\xC5', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC9', '\x3', '\x2',
                '\x2', '\x2', '\xC7', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', '\x2', '\x2', '\x2',
                '\xC8', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xC7', '\x3', '\x2', '\x2', '\x2', '\xCA', '\xCB',
                '\b', '\'', '\x2', '\x2', '\xCB', 'N', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCE', '\t', '\x4', '\x2',
                '\x2', '\xCD', '\xCC', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF',
                '\xCD', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xD0', 'P', '\x3',
                '\x2', '\x2', '\x2', '\xD1', '\xD3', '\t', '\x5', '\x2', '\x2', '\xD2', '\xD1', '\x3', '\x2', '\x2',
                '\x2', '\xD3', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD4',
                '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD5', 'R', '\x3', '\x2', '\x2', '\x2', '\b', '\x2', '\xAF',
                '\xB9', '\xC7', '\xCF', '\xD4', '\x3', '\x2', '\x3', '\x2'
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
                "VAR", "WHILE", "RETURN", "LPAREN", "RPAREN", "LBRACE", "RBRACE", "LBRACK", "RBRACK", "SEMI", "COMMA",
                "DOT", "ASSIGN", "GT", "LT", "BANG", "TILDE", "QUESTION", "COLON", "EQUAL", "LE", "GE", "NOTEQUAL",
                "AND", "OR", "INC", "DEC", "ADD", "SUB", "MUL", "DIV", "BITAND", "BITOR", "CARET", "MOD", "WS",
                "COMMENT", "LINE_COMMENT", "STRING", "INT"
            };

        public static string[] channelNames = { "DEFAULT_TOKEN_CHANNEL", "HIDDEN" };

        public static string[] modeNames = { "DEFAULT_MODE" };

        protected static DFA[] decisionToDFA;

        protected static PredictionContextCache sharedContextCache = new PredictionContextCache();

        static TinyLexer()
        {
            decisionToDFA = new DFA[_ATN.NumberOfDecisions];
            for (var i = 0; i < _ATN.NumberOfDecisions; i++)
            {
                decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
            }
        }

        public TinyLexer(ICharStream input)
            : this(input, Console.Out, Console.Error)
        {
        }

        public TinyLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
            this.Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
        }

        public override string[] ChannelNames
        {
            get
            {
                return channelNames;
            }
        }

        public override string GrammarFileName
        {
            get
            {
                return "TinyLexer.g4";
            }
        }

        public override string[] ModeNames
        {
            get
            {
                return modeNames;
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
    }
} // namespace Mobilize.Grammar.Language