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
    /// <seealso cref="Mobilize.App.Sample.State.ISampleState" />
    /// <seealso cref="ISampleState" />
    public class SampleState 
    {
        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        /// <value>The companies.</value>
        public IEnumerable<Company> Companies { get; set; }

        /// <summary>
        /// Gets the user store.
        /// </summary>
        /// <value>The user store.</value>
        public IEnumerable<User> Users { get; }
    }
}