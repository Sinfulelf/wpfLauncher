using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using torrentLauncher.Enums;
using torrentLauncher.Pages.Dialog.Settings;
using torrentLauncher.Routing;

namespace torrentLauncher.Converters.ViewControls
{
    class SettingsDialogRoutingConverter : MarkupExtension, IValueConverter
    {
        private static SettingsDialogRoutingConverter _instance;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var typedValue = (SettingNavigationItems)Enum.Parse(typeof(SettingNavigationItems), value.ToString());

            return RoutingManager.SwitchSettingDialogContent(typedValue);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new SettingsDialogRoutingConverter());
        }
    }
}
