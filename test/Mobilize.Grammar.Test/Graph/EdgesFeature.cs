// ***********************************************************************
// <copyright file="EdgesFeature.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobilize.Grammar.Graph.Generic;
using Mobilize.Quality.Core;
using Mobilize.Quality.Core.Annotations;

namespace Mobilize.Grammar.Test.Graph
{
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
            RunScenario(
                given => FirstEdge(),
                and => EqualEdge(),
                when => Compare(),
                then => CompareShouldBe(true),
                and => CompareHashCode(),
                then => CompareShouldBe(true),
                and => CompareTheSameEdge(),
                then => CompareShouldBe(true),
                and => CompareIfItIsNotEqual(),
                then => CompareShouldBe(false),
                and => CompareWithNull(),
                then => CompareShouldBe(false),
                and => CompareWithObject(),
                then => CompareShouldBe(true),
                and => CompareWithSameObject(),
                then => CompareShouldBe(true),
                and => CompareWithObjectNull(),
                then => CompareShouldBe(false));
        }

        /// <summary>
        ///     Compares this instance.
        /// </summary>
        private void Compare()
        {
            var edge1 = Scenario.Get<Edge<int>>("edge1");
            var edge2 = Scenario.Get<Edge<int>>("edge2");
            Scenario["compare"] = edge1 == edge2;
        }

        /// <summary>
        ///     Compares the hash code.
        /// </summary>
        private void CompareHashCode()
        {
            var edge1 = Scenario.Get<Edge<int>>("edge1");
            var edge2 = Scenario.Get<Edge<int>>("edge2");

            Scenario["compare"] = edge1.GetHashCode() == edge2.GetHashCode();
        }

        /// <summary>
        ///     Compares if it is not equal.
        /// </summary>
        private void CompareIfItIsNotEqual()
        {
            var edge1 = Scenario.Get<Edge<int>>("edge1");
            var edge2 = Scenario.Get<Edge<int>>("edge1");

            Scenario["compare"] = edge1 != edge2;
        }

        /// <summary>
        ///     Expect  the should be equal.
        /// </summary>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        private void CompareShouldBe(bool expected)
        {
            var response = Scenario.Get<bool>("compare");
            response.Should().Be(expected);
        }

        /// <summary>
        ///     Compares the same edge.
        /// </summary>
        private void CompareTheSameEdge()
        {
            var edge1 = Scenario.Get<Edge<int>>("edge1");
            var edge2 = Scenario.Get<Edge<int>>("edge1");

            Scenario["compare"] = edge1 == edge2;
        }

        /// <summary>
        ///     Compares the with null.
        /// </summary>
        private void CompareWithNull()
        {
            var edge = Scenario.Get<Edge<int>>("edge1");
            Scenario["compare"] = edge.Equals(null);
        }

        /// <summary>
        ///     Compares the with object.
        /// </summary>
        private void CompareWithObject()
        {
            var edge1 = Scenario.Get<Edge<int>>("edge1");
            var edge2 = Scenario.Get<Edge<int>>("edge2");
            Scenario["compare"] = edge1.Equals((object) edge2);
        }

        /// <summary>
        ///     Compares the with object null.
        /// </summary>
        private void CompareWithObjectNull()
        {
            var edge = Scenario.Get<Edge<int>>("edge1");
            Scenario["compare"] = edge.Equals((object) null);
        }

        /// <summary>
        ///     Compares the with same object.
        /// </summary>
        private void CompareWithSameObject()
        {
            var edge = Scenario.Get<Edge<int>>("edge1");
            Scenario["compare"] = edge.Equals((object) edge);
        }

        /// <summary>
        ///     Equals the edge.
        /// </summary>
        private void EqualEdge()
        {
            Scenario["edge2"] = new Edge<int>(1, 2);
        }

        /// <summary>
        ///     Firsts the edge.
        /// </summary>
        private void FirstEdge()
        {
            Scenario["edge1"] = new Edge<int>(1, 2);
        }
    }
}