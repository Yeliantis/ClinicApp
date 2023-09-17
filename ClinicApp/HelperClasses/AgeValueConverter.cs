using ClinicApp.TimeAPI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Navigation;

namespace ClinicApp.XamlPages
{
    /// <summary>
    /// Конвертер для преобразования свойства DateOofBirth класса PatientCard в возраст для отображения в таблице
    /// </summary>
    public class AgeValueConverter : IValueConverter
    {
        private DateTime asyncDate;
        public AgeValueConverter()
        {
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            asyncDate = await ActualDataGetter.GetDate();
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateOfBirth)
            {
                int age = asyncDate.Year - dateOfBirth.Year;
                if (asyncDate.Month < dateOfBirth.Month 
                    || (asyncDate.Month == dateOfBirth.Month && asyncDate.Day < dateOfBirth.Day))
                {
                    age--;
                }
                return age;
            }
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
