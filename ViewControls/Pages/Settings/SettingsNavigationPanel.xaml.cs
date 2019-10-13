using System;
using System.Collections.Generic;
using System.Linq;
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
using torrentLauncher.Converters;
using torrentLauncher.DataStorage;
using torrentLauncher.Enums;

namespace torrentLauncher.ViewControls.Pages.Settings
{
    /// <summary>
    /// Interaction logic for SettingsNavigationPanel.xaml
    /// </summary>
    public partial class SettingsNavigationPanel : UserControl
    {
        public static readonly DependencyProperty ClickNavigationSettingMenuButtonCommandProperty =
            DependencyProperty.Register(
                "ClickNavigationSettingMenuButtonCommand",
                typeof(ICommand),
                typeof(SettingsNavigationPanel));

        public ICommand ClickNavigationSettingMenuButtonCommand
        {
            get { return (ICommand)GetValue(ClickNavigationSettingMenuButtonCommandProperty); }
            set { SetValue(ClickNavigationSettingMenuButtonCommandProperty, value); }
        }

        public static readonly DependencyProperty SelectedSettingProperty =
           DependencyProperty.Register(
               "SelectedSetting",
               typeof(SettingNavigationItems),
               typeof(SettingsNavigationPanel));

        public SettingNavigationItems SelectedSetting
        {
            get { return (SettingNavigationItems)GetValue(SelectedSettingProperty); }
            set { SetValue(SelectedSettingProperty, value); }
        }

        public static PropertyToItemConverterParameter ConverterParameter
            => new PropertyToItemConverterParameter()
            {
                Source = SettingsNavigationMenuStorage.MunuItems.Cast<dynamic>().ToList(),
                PropertyName = "Item"
            };

        public SettingsNavigationPanel()
        {
            InitializeComponent();
        }
    }
}
