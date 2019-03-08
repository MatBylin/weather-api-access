using System;


namespace WeatherRestApi
{
    public class WeatherIcons
    {
        public static string GetCurrentIcon(string id)
        {
            return @"http://openweathermap.org/img/w/" + id + ".png";
        }
    }
}
