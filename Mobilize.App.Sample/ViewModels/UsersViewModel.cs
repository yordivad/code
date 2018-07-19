// ***********************************************************************
// <copyright file="UsersViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using Mobilize.App.Sample.State;

    using ReactiveUI;

    /// <summary>
    /// Class UsersViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class UsersViewModel : ReactiveObject
    {
        /// <summary>
        /// The store
        /// </summary>
        private ISampleStore store;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersViewModel"/> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public UsersViewModel(ISampleStore store)
        {
            this.store = store;
        }
    }
}