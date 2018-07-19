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
    using System.Reactive.Linq;

    using Mobilize.App.Sample.Model;
    using Mobilize.App.Sample.State;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    /// <summary>
    /// Class UserListViewModel.
    /// </summary>
    public class UserListViewModel : ReactiveObject
    {
        /// <summary>
        /// The store
        /// </summary>
        private readonly ISampleStore store;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListViewModel"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public UserListViewModel(ISampleStore store = null)
        {
            this.store = store;
            store.State.Select(this.GetUsers).Subscribe(users => this.Users = users);
        }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>The filter.</value>
        [Reactive]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or sets the Users
        /// </summary>
        public IEnumerable<User> Users { get; set; }

        /// <summary>
        /// Gets the users view model.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>The collection of the users.</returns>
        private IEnumerable<User> GetUsers(SampleState state) => state.Users;
    }
}