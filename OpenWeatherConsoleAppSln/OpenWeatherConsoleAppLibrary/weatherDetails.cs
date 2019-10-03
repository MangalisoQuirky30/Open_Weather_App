using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherConsoleAppLibrary
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class WeatherDetails
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}




/* 
 {
     1"coord":
     {
        "lon":18.42,
        "lat":-33.93
     },



/// 2"weather":
    [
        {
        "id":803,
        "main":"Clouds",
        "description":"broken clouds", 
        "icon":"04d"
        }
     ],
    3"base":"stations",
    4 "main":
     {
        "temp":292.95,
        "pressure":1018,
        "humidity":56,
        "temp_min":292.04,
        "temp_max":293.71
      },
     5 "visibility":10000,
      6"wind":
      {
        "speed":7.2,
        "deg":310
      },
     7 "clouds":
      {
        "all":75
      },
     8 "dt":1570104470,
     9 "sys":
      {
        "type":1,
        "id":1899,
        "message":0.008,
        "country":"ZA",
        "sunrise":1570076463,
        "sunset":1570121384
      },
      10  "timezone":7200,
       11 "id":3369157,
       12 "name":"Cape Town",
       13 "cod":200
   }

    */