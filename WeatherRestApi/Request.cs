using RestSharp;


namespace WeatherRestApi
{
    public class Request
    {
        public static string GetResponse(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute(new RestRequest());
            return response.Content;
        }
    }
}
