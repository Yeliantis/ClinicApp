using ClinicApp.TimeAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.EntityModels
{
    public class DateValidation
    {
        //Сравнение введенной пользователем даты с актуальной
        public static async Task<bool> dateIsValid(DateTime userDate)
        {
            DateTime actualDate = await ActualDataGetter.GetDate();
            if (actualDate.Year - userDate.Year < 110) 
            {
                return true;
            }
            return false;
        }
    }
}
