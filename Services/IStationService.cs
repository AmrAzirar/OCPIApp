using OCPIApp.Models;

namespace OCPIApp.Services
{
    public interface IStationService
    {
        Task<List<Station>> GetStationsAsync();
        Task<Station> GetStationByIdAsync(int id);
        Task<Station> CreateStationAsync(Station station);
        Task<bool> UpdateStationAsync(int id, Station station);
        Task<bool> DeleteStationAsync(int id);
    }
}
