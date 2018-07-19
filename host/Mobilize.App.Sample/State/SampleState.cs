// ***********************************************************************
// <copyright file="SampleState.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.State
{
    using System.Collections.Generic;

    using Mobilize.App.Sample.Model;

    /// <summary>
    /// Class SampleState.
    /// </summary>
    public class SampleState
    {
        /// <summary>
        /// Gets or sets the Companies
        /// </summary>
        public IEnumerable<Company> Companies { get; set; }

        /// <summary>
        /// Gets the user store.
        /// </summary>
        public IEnumerable<User> Users { get; }
    }
}