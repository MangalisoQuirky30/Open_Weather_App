using System;
using System.Threading.Tasks;
using OpenWeatherConsoleAppLibrary;

namespace OpenWeatherConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            getWeather weather = new getWeather();
            string weatherNow = await weather.getWeatherAsync();
            Console.WriteLine(weatherNow);
        }
    }
}
