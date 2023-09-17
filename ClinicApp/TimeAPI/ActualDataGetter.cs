using ClinicApp.EntityModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace ClinicApp.TimeAPI
{
    public class ActualDataGetter
    {
        //Получение актуальной даты по МСК через сервис WorldTime Api
        public static async Task<DateTime> GetDate()
        {  
            var request = new RestRequest("timezone/Europe/Moscow", Method.GET);
            var result = TimeApi.GetConnection()
                .Execute(request)
                .Content;
            
            return JsonConvert
                .DeserializeObject<ActualDate>(result)
                .Date;
           
           
        }
        
    }
}
