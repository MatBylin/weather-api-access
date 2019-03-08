using System;


namespace WeatherRestApi
{
    public class ConvertClass
    {
        public static double MPerSecToKmPerHour(double value)
        {
            return Math.Round(value * 3.6, 1);
        }
    }
}
