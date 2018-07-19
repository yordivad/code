// ***********************************************************************
// <copyright file="UserViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using System;
    using System.Collections.Generic;

    using Mobilize.App.Sample.Model;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    /// <summary>
    /// Class UserViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class UserViewModel : ReactiveObject
    {
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        public UserViewModel(User user)
        {

            this.WhenAnyValue(c => c.Name).BindTo(user, m => m.Name);
            this.WhenAnyValue(c => c.LastName).BindTo(user, m => m.LastName);
        }

        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        /// <value>The birth date.</value>
        [Reactive]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>The code.</value>
        public string Code => this.Name.Substring(1) + this.LastName.Substring(2);

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        /// <value>The companies.</value>
        [Reactive]
        public IEnumerable<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the company.
        /// </summary>
        /// <value>The company.</value>
        [Reactive]
        public Company Company { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        /// <value><c>true</c> if this instance is selected; otherwise, <c>false</c>.</value>
        [Reactive]
        public bool IsSelected { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [Reactive]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [Reactive]
        public string Name { get; set; }
    }
}