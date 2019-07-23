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
using torrentLauncher.ViewModels.NavigationPanel;

namespace torrentLauncher.ViewControls.NavigationPanel
{
    /// <summary>
    /// Interaction logic for NavigationMenu.xaml
    /// </summary>
    public partial class NavigationMenu : UserControl
    {
        public static readonly DependencyProperty ToggleStateProperty =
            DependencyProperty.Register(
                "ToggleState",
                typeof(bool),
                typeof(NavigationMenu));


        public bool ToggleState
        {
            get { return (bool)GetValue(ToggleStateProperty); }
            set { SetValue(ToggleStateProperty, value); }
        }

        public static readonly DependencyProperty ClickNavigationMenuButtonCommandProperty =
            DependencyProperty.Register(
                "ClickNavigationMenuButtonCommand",
                typeof(ICommand),
                typeof(NavigationMenu));

        public ICommand ClickNavigationMenuButtonCommand
        {
            get { return (ICommand)GetValue(ClickNavigationMenuButtonCommandProperty); }
            set { SetValue(ClickNavigationMenuButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty SelectedNavigationButtonProperty =
           DependencyProperty.Register(
               "SelectedNavigationButton",
               typeof(NavigationButtons),
               typeof(NavigationMenu));

        public NavigationButtons SelectedNavigationButton
        {
            get { return (NavigationButtons)GetValue(SelectedNavigationButtonProperty); }
            set { SetValue(SelectedNavigationButtonProperty, value); }
        }

        public NavigationMenu()
        {
            InitializeComponent();
        }
    }
}
