using Newtonsoft.Json;
using WeatherRestApi.FiveDayWeather;

namespace WeatherRestApi
{
    public class GetWeatherData
    {
        public static CurrentWeatherData GetCurrentWeatherData(string weather_request)
        {
            string result = WeatherRestApi.Request.GetResponse(weather_request);
            CurrentWeatherData data = JsonConvert.DeserializeObject<CurrentWeatherData>(result);

            return data;
        }

        public static FiveDayWeatherData GetFiveDayWeatherData(string weather_request)
        {
            string result = WeatherRestApi.Request.GetResponse(weather_request);
            FiveDayWeatherData data = JsonConvert.DeserializeObject<FiveDayWeatherData>(result);

            return data;
        }
    }
}
