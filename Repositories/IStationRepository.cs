using OCPIApp.Models;

namespace OCPIApp.Repositories
{
    public interface IStationRepository
    {
        Task<List<Station>> GetAllStationsAsync();
        Task<Station> GetStationByIdAsync(int id);
        Task<Station> AddStationAsync(Station station);
        Task<bool> UpdateStationAsync(int id, Station station);
        Task<bool> DeleteStationAsync(int id);
    }
}
