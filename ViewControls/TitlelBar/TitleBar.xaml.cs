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
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBar : UserControl
    {
        public static readonly DependencyProperty TitleToggleNavigationPanelCommandProperty =
            DependencyProperty.Register(
                "TitleToggleNavigationPanelCommand",
                typeof(ICommand),
                typeof(TitleBar));

        public ICommand TitleToggleNavigationPanelCommand
        {
            get { return (ICommand)GetValue(TitleToggleNavigationPanelCommandProperty); }
            set { SetValue(TitleToggleNavigationPanelCommandProperty, value); }
        }

        public static readonly DependencyProperty HamburgerBtnStateProperty =
            DependencyProperty.Register(
                "HamburgerBtnState",
                typeof(bool),
                typeof(TitleBar));


        public bool HamburgerBtnState
        {
            get { return (bool)GetValue(HamburgerBtnStateProperty); }
            set { SetValue(HamburgerBtnStateProperty, value); }
        }

        public static readonly DependencyProperty ClickTitleBarButtonCommandProperty =
            DependencyProperty.Register(
                "ClickTitleBarButtonCommand",
                typeof(ICommand),
                typeof(TitleBar));

        public ICommand ClickTitleBarButtonCommand
        {
            get { return (ICommand)GetValue(ClickTitleBarButtonCommandProperty); }
            set { SetValue(ClickTitleBarButtonCommandProperty, value); }
        }

        public TitleBar()
        {
            InitializeComponent();
        }
    }
}
