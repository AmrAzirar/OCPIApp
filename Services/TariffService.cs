using OCPIApp.Models;
using OCPIApp.Repositories;

namespace OCPIApp.Services
{
    public class TariffService : ITariffService
    {
        private readonly ITariffRepository _tariffRepository;

        public TariffService(ITariffRepository tariffRepository)
        {
            _tariffRepository = tariffRepository;
        }

        public async Task<List<Tariff>> GetTariffsAsync()
        {
            return await _tariffRepository.GetAllTariffsAsync();
        }

        public async Task<Tariff> GetTariffByIdAsync(int id)
        {
            return await _tariffRepository.GetTariffByIdAsync(id);
        }

        public async Task<Tariff> CreateTariffAsync(Tariff tariff)
        {
            return await _tariffRepository.AddTariffAsync(tariff);
        }

        public async Task<bool> UpdateTariffAsync(int id, Tariff tariff)
        {
            return await _tariffRepository.UpdateTariffAsync(id, tariff);
        }

        public async Task<bool> DeleteTariffAsync(int id)
        {
            return await _tariffRepository.DeleteTariffAsync(id);
        }
    }
}
