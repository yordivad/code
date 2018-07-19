// ***********************************************************************
// <copyright file="Specs.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.Middleware.Specification
{
    using System.Collections.Generic;

    using Mobilize.App.Sample.Model;
    using Mobilize.App.Sample.State;

    /// <summary>
    /// Class Specs.
    /// </summary>
    public static class Specs
    {
        /// <summary>
        /// Gets the companies.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>The companies .</returns>
        public static IEnumerable<Company> GetCompanies(SampleState state)
        {
            return state.Companies;
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>the list of the users.</returns>
        public static IEnumerable<User> GetUsers(SampleState state)
        {
            return state.Users;
        }
    }
}