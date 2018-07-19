// ***********************************************************************
// <copyright file="UserViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive.Linq;

    using Mobilize.App.Sample.Middleware.Action;
    using Mobilize.App.Sample.Model;
    using Mobilize.App.Sample.State;

    using ReactiveUI;

    /// <summary>
    /// Class UserViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class UserViewModel : ReactiveObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel" /> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public UserViewModel(ISampleStore store)
        {
            this.SelectedUser = new UserDetailViewModel();

            


            this.AddCommand = ReactiveCommand.Create(
                () => store.State.Dispatch(
                    new AddUserAction
                        {
                            Name = this.SelectedUser.Name,
                            LastName = this.SelectedUser.LastName,
                            BirthDate = this.SelectedUser.BirthDate
                        }));
        }

        /// <summary>
        /// Gets the add command.
        /// </summary>
        /// <value>The add command.</value>
        public ReactiveCommand AddCommand { get; }

        /// <summary>
        /// Gets the redo command.
        /// </summary>
        /// <value>The redo command.</value>
        public ReactiveCommand RedoCommand { get; }

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <value>The delete command.</value>
        public ReactiveCommand RemoveCommand { get; }

        /// <summary>
        /// Gets the undo command.
        /// </summary>
        /// <value>The undo command.</value>
        public ReactiveCommand UndoCommand { get; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        public UserDetailViewModel SelectedUser { get; set; }


      

       
    }
}