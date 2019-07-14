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
using torrentLauncher.ViewModels.TitlelBar;

namespace torrentLauncher.ViewControls.TitlelBar
{
    /// <summary>
    /// Interaction logic for ControllPopUpBtn.xaml
    /// </summary>
    public partial class ControllPopUpBtn : UserControl
    {
        public static readonly DependencyProperty ClickTitleBarButtonCommandProperty =
            DependencyProperty.Register(
                "ClickTitleBarButtonCommand",
                typeof(ICommand),
                typeof(ControllPopUpBtn));

        public ICommand ClickTitleBarButtonCommand
        {
            get { return (ICommand)GetValue(ClickTitleBarButtonCommandProperty); }
            set { SetValue(ClickTitleBarButtonCommandProperty, value); }
        }

        public ControllPopUpBtn()
        {
            InitializeComponent();
        }
    }
}
