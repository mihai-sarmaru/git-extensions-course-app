using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace GitExtensionsCourseApp.Converters {
    public class BoolToVisibilityConverter : IValueConverter {

        public bool Reverse { get; set; } = false;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return ConvertVisibility(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return ConvertVisibility(value);
        }

        private Visibility ConvertVisibility(object value) {
            Visibility visibility = (bool)value ? Visibility.Visible : Visibility.Collapsed;
            return !Reverse ? visibility : Visibility.Collapsed;
        }
    }
}
