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
using torrentLauncher.ViewModels.NavigationPanel;

namespace torrentLauncher.ViewControls.NavigationPanel
{
    /// <summary>
    /// Interaction logic for NavigationMenuItem.xaml
    /// </summary>
    public partial class NavigationMenuItem : UserControl
    {
        public static readonly DependencyProperty ClickNavigationMenuButtonCommandProperty =
           DependencyProperty.Register(
               "ClickNavigationMenuButtonCommand",
               typeof(ICommand),
               typeof(NavigationMenuItem));


        public ICommand ClickNavigationMenuButtonCommand
        {
            get { return (ICommand)GetValue(ClickNavigationMenuButtonCommandProperty); }
            set { SetValue(ClickNavigationMenuButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty SelectedNavigationButtonProperty =
           DependencyProperty.Register(
               "SelectedNavigationButton",
               typeof(NavigationButtons),
               typeof(NavigationMenuItem),
               new PropertyMetadata(OnSelectedNavigationButtonChangedCallBack));

        public NavigationButtons SelectedNavigationButton
        {
            get { return (NavigationButtons)GetValue(SelectedNavigationButtonProperty); }
            set { SetValue(SelectedNavigationButtonProperty, value); }
        }

        private static void OnSelectedNavigationButtonChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NavigationMenuItem c = d as NavigationMenuItem;
            if (c != null)
            {
                (c.DataContext as NavigationMenuItemViewModel).ToggleNavigationMenuItemCommand.Execute(c.SelectedNavigationButton);
            }
        }

        public NavigationMenuItem()
        {
            InitializeComponent();
        }
    }
}
