// ***********************************************************************
// <copyright file="UserViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.ViewModels
{
    using Mobilize.App.Sample.State;

    using ReactiveUI;

    /// <summary>
    /// Class UserViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class UserViewModel : ReactiveObject
    {
        /// <summary>
        /// The store
        /// </summary>
        private ISampleStore store;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel" /> class.
        /// </summary>
        /// <param name="store">The store.</param>
        public UserViewModel(ISampleStore store)
        {
            this.store = store;
        }

        /// <summary>
        /// Gets the add command.
        /// </summary>
        /// <value>The add command.</value>
        public ReactiveCommand AddCommand { get; }

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <value>The delete command.</value>
        public ReactiveCommand RemoveCommand { get; }

        /// <summary>
        /// Gets the redo command.
        /// </summary>
        /// <value>The redo command.</value>
        public ReactiveCommand RedoCommand { get; }

        /// <summary>
        /// Gets the undo command.
        /// </summary>
        /// <value>The undo command.</value>
        public ReactiveCommand UndoCommand { get; }
    }
}