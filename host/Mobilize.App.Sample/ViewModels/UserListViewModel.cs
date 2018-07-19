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
            this.store.State.Select(Specs.GetUsers)
                .Subscribe(c => this.Users = c.Select(u => new UserDetailViewModel(u)));
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
        public IEnumerable<UserDetailViewModel> Users { get; set; }
    }
}