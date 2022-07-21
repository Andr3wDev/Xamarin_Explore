using System;
using System.Globalization;
using Xamarin.Forms;

namespace Travel.Converters
{
    internal class PlusIsVisibleConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            int id = (int)value;

            return id == 4 ? true : (object)false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
