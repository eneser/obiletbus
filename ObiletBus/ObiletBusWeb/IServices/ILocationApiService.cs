using ObiletBus.Core.DTOs.Location;

namespace ObiletBusWeb.IServices
{
    public interface ILocationApiService
    {
        Task<GetBusLocationResponseDto> GetBusLocation(GetBusLocationRequestDto model);
    }
}
