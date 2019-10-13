using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;
using torrentLauncher.DataStorage;

namespace torrentLauncher.Converters
{
    public class PropertyToItemConverterParameter
    {
        public List<dynamic> Source { get; set; }
        public string PropertyName { get; set; }
    }

    public class PropertyToItemConverter : MarkupExtension, IValueConverter
    {
        private static PropertyToItemConverter _instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var p = (parameter as PropertyToItemConverterParameter);

            return p.Source.FirstOrDefault(d => (dynamic)(d.GetType().GetProperty(p.PropertyName).GetValue(d, null)) == (dynamic)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var p = (parameter as PropertyToItemConverterParameter);

            return value.GetType().GetProperty(p.PropertyName).GetValue(value, null);
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new PropertyToItemConverter());
        }
    }
}
