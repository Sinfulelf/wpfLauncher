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
using torrentLauncher.Models.NavigationPanel;

namespace torrentLauncher.ViewControls.NavigationPanel
{
    /// <summary>
    /// Interaction logic for NavigationMenuGroup.xaml
    /// </summary>
    public partial class NavigationMenuGroup : UserControl
    {
        public static readonly DependencyProperty ClickNavigationMenuButtonCommandProperty =
            DependencyProperty.Register(
                "ClickNavigationMenuButtonCommand",
                typeof(ICommand),
                typeof(NavigationMenuGroup));

        public ICommand ClickNavigationMenuButtonCommand
        {
            get { return (ICommand)GetValue(ClickNavigationMenuButtonCommandProperty); }
            set { SetValue(ClickNavigationMenuButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty SelectedNavigationButtonProperty =
           DependencyProperty.Register(
               "SelectedNavigationButton",
               typeof(NavigationButtons),
               typeof(NavigationMenuGroup));

        public NavigationButtons SelectedNavigationButton
        {
            get { return (NavigationButtons)GetValue(SelectedNavigationButtonProperty); }
            set { SetValue(SelectedNavigationButtonProperty, value); }
        }

        public NavigationMenuGroup()
        {
            InitializeComponent();
        }
    }
}
