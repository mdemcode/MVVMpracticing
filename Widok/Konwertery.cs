using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MVVMtest.Widok {
    public class DecimalToWalutaKonw : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return string.Format("{0:0.00}",value) + " zł";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
    public class SkladoweDoSumyKonw : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            return string.Format("{0:0.00}", ((decimal)values[0]+(decimal)values[1]+(decimal)values[2]))+ " zł";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
