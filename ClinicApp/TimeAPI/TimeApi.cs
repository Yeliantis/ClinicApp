using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ClinicApp.TimeAPI
{
    /// <summary>
    /// Класс для соединения с World Time API 
    /// </summary>
   
    public static class TimeApi
    {
        private static readonly string connection = "http://worldtimeapi.org/api";

        public static RestClient GetConnection()
        {
            return new RestClient(connection);
        }
        
    }
}
