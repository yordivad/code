// ***********************************************************************
// <copyright file="EdgesFeature.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar.Test.Graph
{
    using FluentAssertions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Mobilize.Grammar.Graph;
    using Mobilize.Quality.Core;
    using Mobilize.Quality.Core.Annotations;

    /// <summary>
    ///     Class EdgesFeature.
    /// </summary>
    /// <seealso cref="Mobilize.Quality.Core.Feature" />
    [TestClass]
    [Feature(@"Edges features")]
    public class EdgesFeature : Feature
    {
        /// <summary>
        ///     Unique this instance.
        /// </summary>
        [Scenario(@"The edges should be unique")]
        [TestMethod]
        public void Unique()
        {
            this.RunScenario(
                given => this.FirstEdge(),
                and => this.EqualEdge(),
                when => this.Compare(),
                then => this.CompareShouldBe(true),
                and => this.CompareHashCode(),
                then => this.CompareShouldBe(true),
                and => this.CompareTheSameEdge(),
                then => this.CompareShouldBe(true),
                and => this.CompareIfItIsNotEqual(),
                then => this.CompareShouldBe(false),
                and => this.CompareWithNull(),
                then => this.CompareShouldBe(false),
                and => this.CompareWithObject(),
                then => this.CompareShouldBe(true),
                and => this.CompareWithSameObject(),
                then => this.CompareShouldBe(true),
                and => this.CompareWithObjectNull(),
                then => this.CompareShouldBe(false));
        }

        /// <summary>
        ///     Compares this instance.
        /// </summary>
        private void Compare()
        {
            var edge1 = this.Scenario.Get<Edge<int>>("edge1");
            var edge2 = this.Scenario.Get<Edge<int>>("edge2");
            this.Scenario["compare"] = edge1 == edge2;
        }

        /// <summary>
        ///     Compares the hash code.
        /// </summary>
        private void CompareHashCode()
        {
            var edge1 = this.Scenario.Get<Edge<int>>("edge1");
            var edge2 = this.Scenario.Get<Edge<int>>("edge2");

            this.Scenario["compare"] = edge1.GetHashCode() == edge2.GetHashCode();
        }

        /// <summary>
        ///     Compares if it is not equal.
        /// </summary>
        private void CompareIfItIsNotEqual()
        {
            var edge1 = this.Scenario.Get<Edge<int>>("edge1");
            var edge2 = this.Scenario.Get<Edge<int>>("edge1");

            this.Scenario["compare"] = edge1 != edge2;
        }

        /// <summary>
        ///     Expect  the should be equal.
        /// </summary>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        private void CompareShouldBe(bool expected)
        {
            var response = this.Scenario.Get<bool>("compare");
            response.Should().Be(expected);
        }

        /// <summary>
        ///     Compares the same edge.
        /// </summary>
        private void CompareTheSameEdge()
        {
            var edge1 = this.Scenario.Get<Edge<int>>("edge1");
            var edge2 = this.Scenario.Get<Edge<int>>("edge1");

            this.Scenario["compare"] = edge1 == edge2;
        }

        /// <summary>
        ///     Compares the with null.
        /// </summary>
        private void CompareWithNull()
        {
            var edge = this.Scenario.Get<Edge<int>>("edge1");
            this.Scenario["compare"] = edge.Equals(null);
        }

        /// <summary>
        ///     Compares the with object.
        /// </summary>
        private void CompareWithObject()
        {
            var edge1 = this.Scenario.Get<Edge<int>>("edge1");
            var edge2 = this.Scenario.Get<Edge<int>>("edge2");
            this.Scenario["compare"] = edge1.Equals((object)edge2);
        }

        /// <summary>
        ///     Compares the with object null.
        /// </summary>
        private void CompareWithObjectNull()
        {
            var edge = this.Scenario.Get<Edge<int>>("edge1");
            this.Scenario["compare"] = edge.Equals((object)null);
        }

        /// <summary>
        ///     Compares the with same object.
        /// </summary>
        private void CompareWithSameObject()
        {
            var edge = this.Scenario.Get<Edge<int>>("edge1");
            this.Scenario["compare"] = edge.Equals((object)edge);
        }

        /// <summary>
        ///     Equals the edge.
        /// </summary>
        private void EqualEdge()
        {
            this.Scenario["edge2"] = new Edge<int>(1, 2);
        }

        /// <summary>
        ///     Firsts the edge.
        /// </summary>
        private void FirstEdge()
        {
            this.Scenario["edge1"] = new Edge<int>(1, 2);
        }
    }
}