// ***********************************************************************
// <copyright file="UserList.xaml.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.View
{
    using System;
    using System.ComponentModel;
    using System.Reactive.Linq;
    using System.Windows;
    using System.Windows.Controls;

    using Mobilize.App.Sample.ViewModels;

    using ReactiveUI;

    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : UserControl, IViewFor<UserListViewModel>
    {
        /// <summary>
        /// The view model property
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(UserListViewModel), typeof(UserList));

        /// <summary>
        /// The items property
        /// </summary>
        private static readonly DependencyProperty MyLabelProperty = DependencyProperty.Register(
            "MyLabel",
            typeof(string),
            typeof(UserList));

        /// <summary>
        /// Initializes a new instance of the <see cref="UserList"/> class.
        /// </summary>
        public UserList()
        {
            this.InitializeComponent();

            // this.Bind(this.ViewModel, vm => vm.Users, v => v.Items);
            // this.Bind(this.ViewModel, vm => vm.Label, v => v.MyLabel)
            //this.WhenActivated(
            //    disposable => disposable(
            //        this.WhenAnyValue(x => x.MyLabel).Select(x => x != null).BindTo(this.ViewModel, vm => vm.Label)));
        }

        /// <summary>
        /// Occurs when [selected user].
        /// </summary>
        public event EventHandler SelectedUser;

        ///// <summary>
        ///// Gets or sets the items.
        ///// </summary>
        ///// <value>The items.</value>
        // [Bindable(true)]
        // public IEnumerable<Model.User> Items
        // {
        // get => (IEnumerable<Model.User>)this.GetValue(ItemsProperty);
        // set => this.SetValue(ItemsProperty, value);
        // }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [Bindable(true)]
        public string MyLabel
        {
            get => (string)this.GetValue(MyLabelProperty);
            set => this.SetValue(MyLabelProperty, value);
        }

        /// <summary>
        /// Gets or sets The ViewModel corresponding to this specific View. This should be
        /// a DependencyProperty if you're using XAML.
        /// </summary>
        /// <value>The view model.</value>
        public UserListViewModel ViewModel { get; set; }

        /// <summary>
        /// Gets or sets The ViewModel corresponding to this specific View. This should be
        /// a DependencyProperty if you're using XAML.
        /// </summary>
        /// <value>The view model.</value>
        object IViewFor.ViewModel
        {
            get => this.ViewModel;
            set => this.ViewModel = (UserListViewModel)value;
        }
    }
}