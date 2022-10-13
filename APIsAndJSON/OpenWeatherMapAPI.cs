using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public static class OpenWeatherMapAPI
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var responce = client.GetStringAsync(apiCall).Result;

            var temp = double.Parse(JObject.Parse(responce)["main"]["temp"].ToString());

            return temp;
        }


    }
}