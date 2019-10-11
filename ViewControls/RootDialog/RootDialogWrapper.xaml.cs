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
using torrentLauncher.ViewModels.RootDialog;

namespace torrentLauncher.ViewControls.RootDialog
{
    /// <summary>
    /// Interaction logic for RootDialogWrapper.xaml
    /// </summary>
    public partial class RootDialogWrapper : UserControl
    {
        public RootDialogWrapper(TitleBarButtons button)
        {            
            InitializeComponent();

            Routing.RoutingManager.SwitchDialogContent(this.DialogFrame, button);
            this.DataContext = new RootDialogWrapperViewModel(button);            
        }
    }
}
