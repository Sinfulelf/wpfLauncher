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
    /// Interaction logic for EmulatorsSettingsPage.xaml
    /// </summary>
    public partial class EmulatorsSettingsPage : Page, ISingletonPage
    {
        private static EmulatorsSettingsPage instance;
        public static EmulatorsSettingsPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmulatorsSettingsPage();
                }
                return instance;
            }
            protected set => instance = value;
        }

        private EmulatorsSettingsPage()
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
