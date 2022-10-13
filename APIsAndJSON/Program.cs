using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ron vs Kanye

            RonVSKanyeAPI.KayneQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KayneQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KayneQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KayneQuote();

            RonVSKanyeAPI.RonQuote();

            RonVSKanyeAPI.KayneQuote();

            RonVSKanyeAPI.RonQuote();


            #endregion




            #region OpenWeatherMapAPI

            string key = File.ReadAllText("appsettings.json");

            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.Write("Please enter your zipcode: ");

            string zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {OpenWeatherMapAPI.GetTemp(apiCall)}° F in your location.");


            #endregion
        }


    }
}