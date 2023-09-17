using ClinicApp.TimeAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.EntityModels
{
    //Класс для десериализации json-данных, получаемых с внешнего сервиса
    public class ActualDate
    {
        [JsonProperty("datetime")]
        public DateTime Date { get; set; }
    }
}
