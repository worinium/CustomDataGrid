using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace CustomDataGrid
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (string)value;
            Brush brush = null;
            switch (color)
            {
                case "Active":
                    brush = Brushes.Green;
                    break;
                case "Overdue":
                    brush = Brushes.Red;
                    break;
                   
                case "Abandoned":
                    brush = Brushes.Yellow;
                    break;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public enum StatusColors
    {
        Active,
        Abandoned,
        Overdue
    }
}
