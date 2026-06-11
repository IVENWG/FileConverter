
namespace FileConverter.ValueConverters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class ApplicationVersionToApplicationName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is FileConverter.Version))
            {
                return "LessMB Converter";
            }

            FileConverter.Version version = (FileConverter.Version)value;

            return $"LessMB Converter v{version}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
