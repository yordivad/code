// ***********************************************************************
// <copyright file="GraphViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Graph.ViewModel
{
    using System.Threading.Tasks;

    using Mobilize.App.Graph.Model;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    /// <summary>
    /// Class GraphViewModel.
    /// </summary>
    /// <seealso cref="ReactiveUI.ReactiveObject" />
    public class GraphViewModel : ReactiveObject
    {
        /// <summary>
        /// The model
        /// </summary>
        private readonly Login model;

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphViewModel"/> class.
        /// </summary>
        public GraphViewModel()
        {
            this.model = new Login();
            this.WhenAnyValue(c => c.UserName).BindTo(this.model, l => l.User);
            
        }

        /// <summary>
        /// Gets the login command.
        /// </summary>
        /// <value>The login command.</value>
        public ReactiveCommand<string, bool> LoginCommand { get; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [Reactive]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [Reactive]
        public string UserName { get; set; }


        public Task<bool> Authenticate()
        {

        }
    }
}