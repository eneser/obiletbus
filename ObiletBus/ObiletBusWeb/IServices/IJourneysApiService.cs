using ObiletBus.Core.DTOs.Journeys;
using ObiletBus.Core.DTOs.Location;

namespace ObiletBusWeb.IServices
{
    public interface IJourneysApiService
    {
        Task<JourneysResponseDto> GetBusJourneys(JourneysRequestDto model);
    }
}
