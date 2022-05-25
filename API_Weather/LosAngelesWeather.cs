using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace API_Weather
{
    public class LosAngelesWeather : Weather
    {
        private HttpClient _client;

        public LosAngelesWeather(HttpClient client)
        {
            _client = client;
        }

        public double Temp { get ; set ; }
        public double FeelsLike { get ; set ; }
        public double TempMin { get ; set ; }
        public double TempMax { get ; set ; }
        public int Pressure { get ; set ; }
        public int Humidity { get ; set ; }

        public JToken GetWeather()
        {
            var client = new HttpClient();
            var losAngelesWeather = "https://api.openweathermap.org/data/2.5/weather?q=Los%20Angeles&appid=32d0592a167fee87c9aefeb49119e2f7";
            var weatherResponse = client.GetStringAsync(losAngelesWeather).Result;

            JObject weatherParse = JObject.Parse(weatherResponse);

            var temp1 = weatherParse["list"][0]["main"]["temp"];
            Console.WriteLine(temp1);

            return temp1;
        }
    }
}
