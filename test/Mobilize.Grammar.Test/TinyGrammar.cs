// ***********************************************************************
// <copyright file="TinyGrammar.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Test
{
    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Mobilize.Quality.Core;
    using Mobilize.Quality.Core.Annotations;
    using Mobilize.Quality.Core.Embedded;

    /// <summary>
    ///     Class TinyGrammar.
    /// </summary>
    /// <seealso cref="Mobilize.Quality.Core.Feature" />
    [TestClass]
    [Feature("Tiny Grammar Studie")]
    public class TinyGrammar : Feature
    {
        /// <summary>
        ///     Parses the program.
        /// </summary>
        [TestMethod]
        [Scenario("Parsing the program")]
        public void ParseProgram()
        {
            this.RunScenario(given => this.LoadProgram(), when => this.ParseTheProgram(), then => this.ParserWorks());
        }

        /// <summary>
        ///     Loads the program.
        /// </summary>
        private void LoadProgram()
        {
            this.Scenario["program"] = Content.ReadEmbeddedFile("iter.tiny");
        }

        /// <summary>
        ///     Then the parser works.
        /// </summary>
        private void ParserWorks()
        {
            var parser = this.Scenario.Get<Tiny>("parser");
            parser.HasErrors.Should().BeFalse();
        }

        /// <summary>
        ///     Parses the program.
        /// </summary>
        private void ParseTheProgram()
        {
            var parser = new Tiny();
            this.Scenario["parser"] = parser;
            var tree = parser.Tree(this.Scenario.Get<string>("program"));
        }
    }
}