using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace InitBlaz.Client.Services.Http
{
    public class HttpsWeatherService : IHttpsWeatherService
    {
        private readonly HttpClient _httpClient;

        public HttpsWeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetWeatherForcasts()
        {
            var req = new HttpRequestMessage(HttpMethod.Get, $"{Constants.URL_Base}api/SampleData/WeatherForecats");
            return await _httpClient.SendAsync(req);
        }
    }
}
