using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var respones = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}c0587efd0e3e6352dd7338426614842b"));
            return JsonConvert.DeserializeObject<Root>(respones);
        }
        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var respones = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q=Taichung{0}&lon={1}c0587efd0e3e6352dd7338426614842b"));
            return JsonConvert.DeserializeObject<Root>(respones);
        }
    }
}
