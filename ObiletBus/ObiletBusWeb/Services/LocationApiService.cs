using Newtonsoft.Json;
using ObiletBus.Core.DTOs.Location;
using ObiletBusWeb.IServices;
using RestSharp;
using System.Text.Json;

namespace ObiletBusWeb.Services
{
    public class LocationApiService : ILocationApiService
    {
        private readonly IConfiguration _configuration;
        private readonly RestClient _apiClient;

        public LocationApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiClient = new RestClient(_configuration.GetValue<string>("BaseUrl"));
            _apiClient.AddDefaultHeader("Content-Type", "application/json");
            _apiClient.AddDefaultHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
        }
        public async Task<GetBusLocationResponseDto> GetBusLocation(GetBusLocationRequestDto model)
        {

            var request = new RestRequest("/api/location/getbuslocations", Method.Post);
            request.AddJsonBody(JsonConvert.SerializeObject(model), "application/json");
            var response = await _apiClient.PostAsync<GetBusLocationResponseDto>(request);

            response.data = response.data.Where(x => x.name.Trim() != "()").ToList();
                

            return response;
        }
    }
}
