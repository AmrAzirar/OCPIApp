using OCPIApp.Models;

namespace OCPIApp.Services
{
    public interface ITariffService
    {
        Task<List<Tariff>> GetTariffsAsync();
        Task<Tariff> GetTariffByIdAsync(int id);
        Task<Tariff> CreateTariffAsync(Tariff tariff);
        Task<bool> UpdateTariffAsync(int id, Tariff tariff);
        Task<bool> DeleteTariffAsync(int id);
    }
}
