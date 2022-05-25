using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace API_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var laWeather = new LosAngelesWeather(client);

            Console.WriteLine($"The weather in Los Angeles is: {laWeather.GetWeather()}");


            //var client = new HttpClient();
            //var losAngelesWeather = "https://api.openweathermap.org/data/2.5/weather?q=Los%20Angeles&appid=32d0592a167fee87c9aefeb49119e2f7&units=imperial";
            //var weatherResponse = client.GetStringAsync(losAngelesWeather).Result;
            //var myWeather = JsonConvert.DeserializeObject<IEnumerable<Weather>>(weatherResponse);


            //var weatherParse = JObject.Parse(weatherResponse).GetValue("Temp").ToString();
            //    foreach (var item in myWeather)
            //    {
            //        Console.WriteLine(item.Temp);
            //    }
            //}
        }
    }
}
