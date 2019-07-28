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

namespace torrentLauncher.Pages
{
    /// <summary>
    /// Interaction logic for BrickGamesPage.xaml
    /// </summary>
    public partial class BrickGamesPage : Page
    {
        public static readonly DependencyProperty SelectedNavigationButtonNameProperty =
           DependencyProperty.Register(
               "SelectedNavigationButtonName",
               typeof(string),
               typeof(BrickGamesPage));

        public string SelectedNavigationButtonName
        {
            get { return (string)GetValue(SelectedNavigationButtonNameProperty); }
            set { SetValue(SelectedNavigationButtonNameProperty, value); }
        }

        public static readonly DependencyProperty SelectedNavigationButtonProperty =
           DependencyProperty.Register(
               "SelectedNavigationButton",
               typeof(NavigationButtons),
               typeof(BrickGamesPage),
               new PropertyMetadata(OnSelectedNavigationButtonChangedCallBack));

        public NavigationButtons SelectedNavigationButton
        {
            get { return (NavigationButtons)GetValue(SelectedNavigationButtonProperty); }
            set { SetValue(SelectedNavigationButtonProperty, value); }
        }

        private static void OnSelectedNavigationButtonChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            BrickGamesPage c = d as BrickGamesPage;
            if (c != null)
            {
                c.SelectedNavigationButtonName = ((NavigationButtons)e.NewValue).ToString();
            }
        }

        public BrickGamesPage()
        {
            InitializeComponent();
        }
    }
}
