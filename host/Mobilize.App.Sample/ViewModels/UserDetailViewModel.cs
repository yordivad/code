// ***********************************************************************
// <copyright file="UserDetailViewModel.cs" company="Mobilize">
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
    /// Class UserDetailViewModel.
    /// </summary>
    public class UserDetailViewModel : ReactiveObject
    {
        /// <summary>
        /// Gets or sets the birth date.
        /// </summary>
        [Reactive]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets the Code
        /// </summary>
        public string Code => this.Name.Substring(1) + this.LastName.Substring(2);

        /// <summary>
        /// Gets or sets the Companies
        /// </summary>
        [Reactive]
        public IEnumerable<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the SelectedCompany
        /// </summary>
        [Reactive]
        public Company SelectedCompany { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is selected.
        /// </summary>
        [Reactive]
        public bool IsSelected { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Reactive]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [Reactive]
        public string Name { get; set; }
    }
}