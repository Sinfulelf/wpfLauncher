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

namespace torrentLauncher.ViewControls.TitlelBar
{
    /// <summary>
    /// Interaction logic for HamburgerBtn.xaml
    /// </summary>
    public partial class HamburgerBtn : UserControl
    {
        public static readonly DependencyProperty ToggleNavigationPanelCommandProperty =
            DependencyProperty.Register(
                "ToggleNavigationPanelCommand",
                typeof(ICommand),
                typeof(HamburgerBtn));

        public ICommand ToggleNavigationPanelCommand
        {
            get { return (ICommand)GetValue(ToggleNavigationPanelCommandProperty); }
            set { SetValue(ToggleNavigationPanelCommandProperty, value); }
        }

        public static readonly DependencyProperty CheckedStateProperty =
            DependencyProperty.Register(
                "CheckedState",
                typeof(bool),
                typeof(HamburgerBtn));

        public bool CheckedState
        {
            get => (bool)GetValue(CheckedStateProperty);
            set {
                SetValue(CheckedStateProperty, value);
            }
        }

        public HamburgerBtn()
        {
            InitializeComponent();
        }
    }
}
