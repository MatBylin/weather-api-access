using Newtonsoft.Json;
using WeatherRestApi.ThreeDayWeather;

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

        public static ThreeDayWeatherData GetThreeDayWeatherData(string weather_request)
        {
            string result = WeatherRestApi.Request.GetResponse(weather_request);
            ThreeDayWeatherData data = JsonConvert.DeserializeObject<ThreeDayWeatherData>(result);

            return data;
        }
    }
}
