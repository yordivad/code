// ***********************************************************************
// <copyright file="AddUserAction.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.Middleware.Action
{
    using System;

    using Redux;

    /// <summary>
    /// Class AddUserAction.
    /// </summary>
    /// <value>The birth date.</value>
    /// <seealso cref="Redux.IAction" />
    public class AddUserAction : IAction
    {
        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>The birth date.</value>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}