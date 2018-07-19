// ***********************************************************************
// <copyright file="SelectedCompany.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class SelectedCompany.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets the Address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Users
        /// </summary>
        public IEnumerable<User> Users { get; set; }
    }
}