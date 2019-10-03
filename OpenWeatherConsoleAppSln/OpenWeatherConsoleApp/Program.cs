using System;
using System.Threading.Tasks;
using OpenWeatherConsoleAppLibrary;

namespace OpenWeatherConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GetWeather weather = new GetWeather();
            string weatherNow = await weather.GetWeatherAsync();
            Console.WriteLine(weatherNow);
        }
    }
}
