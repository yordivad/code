// ***********************************************************************
// <copyright file="UserListViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Linq;

    using Mobilize.App.Sample.Middleware.Specification;
    using Mobilize.App.Sample.State;

    using ReactiveUI;

    /// <summary>
    /// Class UserListViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class UserListViewModel : ReactiveObject
    {
        /// <summary>
        /// The store
        /// </summary>
        private ISampleStore store;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListViewModel"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public UserListViewModel(ISampleStore store)
        {
            this.store = store;
            this.store.State.Select(Specs.GetUsers).Subscribe(c => this.Users = c.Select(u => new UserViewModel(u)));
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>The users.</value>
        public IEnumerable<UserViewModel> Users { get; set; }
    }
}