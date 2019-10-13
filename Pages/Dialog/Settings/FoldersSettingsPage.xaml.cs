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
using torrentLauncher.PageInterfaces;

namespace torrentLauncher.Pages.Dialog.Settings
{
    /// <summary>
    /// Interaction logic for FoldersSettingsPage.xaml
    /// </summary>
    public partial class FoldersSettingsPage : Page, ISingletonPage
    {
        private static FoldersSettingsPage instance;
        public static FoldersSettingsPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoldersSettingsPage();
                }
                return instance;
            }
            protected set => instance = value;
        }

        private FoldersSettingsPage()
        {
            InitializeComponent();
        }

        public void ClearInstance()
        {
            if (Instance != null)
                Instance = null;
        }
    }
}
