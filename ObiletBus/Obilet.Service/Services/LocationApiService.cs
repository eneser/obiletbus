using System.Net.Http.Json;

namespace ObiletBusWeb.Services
{
    public class LocationApiService
    {
        private readonly HttpClient _httpClient;

        //constracture
        public LocationApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
      
    }
}
