// ***********************************************************************
// <copyright file="Company.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class Company.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>The users.</value>
        public IEnumerable<User> Users { get; set; }
    }
}