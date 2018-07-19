// ***********************************************************************
// <copyright file="GraphViewModel.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Graph.ViewModel
{
    using Mobilize.App.Graph.Model;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    /// <summary>
    /// Class GraphViewModel.
    /// </summary>
    public class GraphViewModel : ReactiveObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraphViewModel"/> class.
        /// </summary>
        public GraphViewModel()
        {
            var model = new Login();
            this.LoginCommand = ReactiveCommand.Create<string, bool>(s => model.User == "Roy");
            this.WhenAnyValue(c => c.UserName).BindTo(model, l => l.User);
        }

        /// <summary>
        /// Gets the login command.
        /// </summary>
        public ReactiveCommand<string, bool> LoginCommand { get; }

        /// <summary>
        /// Gets or sets the Password
        /// </summary>
        [Reactive]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [Reactive]
        public string UserName { get; set; }
    }
}