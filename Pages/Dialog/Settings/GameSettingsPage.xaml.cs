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
    /// Interaction logic for GameSettingsPage.xaml
    /// </summary>
    public partial class GameSettingsPage : Page, ISingletonPage
    {
        private static GameSettingsPage instance;
        public static GameSettingsPage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameSettingsPage();
                }
                return instance;
            }
            protected set => instance = value;
        }

        private GameSettingsPage()
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
