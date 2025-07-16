using OCPIApp.Models;
using OCPIApp.Repositories;

namespace OCPIApp.Services
{
    public class StationService : IStationService
    {
        private readonly IStationRepository _stationRepository;

        public StationService(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public async Task<List<Station>> GetStationsAsync()
        {
            return await _stationRepository.GetAllStationsAsync();
        }

        public async Task<Station> GetStationByIdAsync(int id)
        {
            return await _stationRepository.GetStationByIdAsync(id);
        }

        public async Task<Station> CreateStationAsync(Station station)
        {
            return await _stationRepository.AddStationAsync(station);
        }

        public async Task<bool> UpdateStationAsync(int id, Station station)
        {
            return await _stationRepository.UpdateStationAsync(id, station);
        }

        public async Task<bool> DeleteStationAsync(int id)
        {
            return await _stationRepository.DeleteStationAsync(id);
        }
    }
}
