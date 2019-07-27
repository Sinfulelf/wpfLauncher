using System;
using System.Collections.Generic;
using System.Reflection;
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

namespace torrentLauncher.ViewControls.ContentPages
{
    /// <summary>
    /// Interaction logic for ContentWrapper.xaml
    /// </summary>
    public partial class ContentWrapper : UserControl
    {
        public Frame ContentFrame { get; private set; }

        public static readonly DependencyProperty SelectedNavigationButtonProperty =
           DependencyProperty.Register(
               "SelectedNavigationButton",
               typeof(NavigationButtons),
               typeof(ContentWrapper),
               new PropertyMetadata(OnSelectedNavigationButtonChangedCallBack));

        public NavigationButtons SelectedNavigationButton
        {
            get { return (NavigationButtons)GetValue(SelectedNavigationButtonProperty); }
            set { SetValue(SelectedNavigationButtonProperty, value); }
        }

        private static void OnSelectedNavigationButtonChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContentWrapper c = d as ContentWrapper;
            if (c != null)
            {
                if (c.ContentFrame == null){
                    c.ContentFrame = (c.FindName("contentFrame") as Frame);
                }
                Routing.RoutingManager.SwitchPage(c.ContentFrame, c.SelectedNavigationButton);
            }
        }

        public ContentWrapper()
        {
            InitializeComponent();
        }
    }
}
