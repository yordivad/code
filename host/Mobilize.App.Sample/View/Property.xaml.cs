// ***********************************************************************
// <copyright file="Property.xaml.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.App.Sample.View
{
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for Property.xaml
    /// </summary>
    public partial class Property : UserControl
    {
        /// </summary>
        public static readonly DependencyProperty MyLabelProperty =
            DependencyProperty.Register("MyLabel", typeof(string), typeof(Property));

        public Property()
        {
            this.InitializeComponent();
            
        }
     
        [Bindable(true)]
        public string MyLabel
        {
            get => (string)this.GetValue(MyLabelProperty);
            set => this.SetValue(MyLabelProperty, value);
        }
      
    }

 
}