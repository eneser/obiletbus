
using Newtonsoft.Json;
using ObiletBus.Core.DTOs.Session;
using ObiletBusWeb.IServices;
using RestSharp;

namespace ObiletBusWeb.Services
{
    public class SessionApiService : ISessionApiService
    {
        private readonly IConfiguration _configuration;
        private readonly RestClient _apiClient;

        public SessionApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _apiClient = new RestClient(_configuration.GetValue<string>("BaseUrl"));
            _apiClient.AddDefaultHeader("Content-Type", "application/json");
            _apiClient.AddDefaultHeader("Authorization", "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1");
        }

        public async Task<GetSessionResponseDto> GetSession(GetSessionRequestDto model)
        {
            var request = new RestRequest("/api/client/getsession", Method.Post);
            request.AddJsonBody(JsonConvert.SerializeObject(model), "application/json");
            var session = await _apiClient.PostAsync<GetSessionResponseDto>(request);

            return session;
        }


    }
}
