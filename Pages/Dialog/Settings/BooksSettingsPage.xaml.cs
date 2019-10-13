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
    /// Interaction logic for BooksSettingsSingletonPage.xaml.xaml
    /// </summary>
    public partial class BooksSettingsPage : Page, ISingletonPage
    {
        private static BooksSettingsPage instance;

        public static BooksSettingsPage Instance {
            get {
                if (instance == null)
                {
                    instance = new BooksSettingsPage();
                }
                return instance;
            }
            protected set => instance = value;
        }

        private BooksSettingsPage()
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
