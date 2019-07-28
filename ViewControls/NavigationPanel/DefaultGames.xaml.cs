using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using torrentLauncher.Enums;

namespace torrentLauncher.ViewControls.NavigationPanel
{
    /// <summary>
    /// Interaction logic for DefaultGames.xaml
    /// </summary>
    public partial class DefaultGames : UserControl
    {
        public static readonly DependencyProperty ClickNavigationMenuButtonProperty =
           DependencyProperty.Register(
               "ClickNavigationMenuButton",
               typeof(ICommand),
               typeof(DefaultGames));

        public ICommand ClickNavigationMenuButton
        {
            get { return (ICommand)GetValue(ClickNavigationMenuButtonProperty); }
            set { SetValue(ClickNavigationMenuButtonProperty, value); }
        }

        public DefaultGames()
        {
            InitializeComponent();
        }
    }
}
