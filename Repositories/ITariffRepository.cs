using OCPIApp.Models;

namespace OCPIApp.Repositories
{
    public interface ITariffRepository
    {
        Task<List<Tariff>> GetAllTariffsAsync();
        Task<Tariff> GetTariffByIdAsync(int id);
        Task<Tariff> AddTariffAsync(Tariff tariff);
        Task<bool> UpdateTariffAsync(int id, Tariff tariff);
        Task<bool> DeleteTariffAsync(int id);
    }
}
