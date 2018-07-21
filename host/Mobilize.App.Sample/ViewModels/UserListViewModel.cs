// ***********************************************************************
// <copyright file="UserListViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using System.Collections.Generic;

    using Mobilize.App.Sample.Model;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    /// <summary>
    /// Class UserListViewModel.
    /// </summary>
    public class UserListViewModel : ReactiveObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListViewModel"/> class.
        /// </summary>
        public UserListViewModel()
        {
            this.Label = "Good";
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>The users.</value>
        [Reactive]
        public IEnumerable<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [Reactive]
        public string Label { get; set; }
    }
}