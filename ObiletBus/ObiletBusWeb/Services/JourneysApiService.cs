using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ObiletBus.Core.DTOs.Journeys;
using ObiletBus.Core.DTOs.Location;
using ObiletBusWeb.IServices;
using RestSharp;

namespace ObiletBusWeb.Services
{
    public class JourneysApiService : IJourneysApiService
    {
        private readonly IConfiguration _configuration;
        private readonly RestClient _apiClient;

        public JourneysApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiClient = new RestClient(_configuration.GetValue<string>("BaseUrl"));
            _apiClient.AddDefaultHeader("Content-Type", "application/json");
            _apiClient.AddDefaultHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
        }
        [HttpPost]
        public async Task<JourneysResponseDto> GetBusJourneys(JourneysRequestDto model)
        {
            var request = new RestRequest("/api/journey/getbusjourneys", Method.Post);
            request.AddJsonBody(JsonConvert.SerializeObject(model), "application/json");
            var response = await _apiClient.PostAsync<JourneysResponseDto>(request);

            return response;
        }

    }
}
