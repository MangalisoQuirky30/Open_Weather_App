using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherConsoleAppLibrary
{
    public class GetWeather
    {
        public async Task<string> GetWeatherAsync()
        {
            HttpClient client = new HttpClient();
            string weatherStr = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=c2e137ef3b94bf7e57de55287a9ec335");

            WeatherDetails weatherObj = JsonConvert.DeserializeObject<WeatherDetails>(weatherStr);

            string mainWeatherDetails = $"/Humidity: {weatherObj.main.humidity}/Pressure: { weatherObj.main.pressure}/Temprature: {weatherObj.main.temp}/Temprature-Max:{ weatherObj.main.temp_max}/Temprature-Min: {weatherObj.main.temp_min}";
            mainWeatherDetails = mainWeatherDetails.Replace("/",  System.Environment.NewLine);
            string minorWeatherDetails = string.Empty;




            foreach (var detail in weatherObj.weather)
            {
                minorWeatherDetails += $"Icon: {detail.icon}/id: {detail.id}/Main:{detail.main}";
            }

            minorWeatherDetails = minorWeatherDetails.Replace("/", System.Environment.NewLine);
            string allWeatherDetails = minorWeatherDetails + "     "+ mainWeatherDetails;

            return allWeatherDetails;
        }
    }
}
