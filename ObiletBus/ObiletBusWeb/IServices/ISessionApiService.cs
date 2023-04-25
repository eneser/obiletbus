using ObiletBus.Core.DTOs.Session;

namespace ObiletBusWeb.IServices
{
    public interface ISessionApiService
    {
        Task<GetSessionResponseDto> GetSession(GetSessionRequestDto model);
    }
}
