using Microsoft.EntityFrameworkCore;
using OCPIApp.Data;
using OCPIApp.Models;

namespace OCPIApp.Repositories
{
    public class TariffRepository : ITariffRepository
    {
        private readonly AppDbContext _context;

        public TariffRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tariff>> GetAllTariffsAsync()
        {
            return await _context.Tariffs.ToListAsync();
        }

        public async Task<Tariff> GetTariffByIdAsync(int id)
        {
            return await _context.Tariffs.FindAsync(id);
        }

        public async Task<Tariff> AddTariffAsync(Tariff tariff)
        {
            _context.Tariffs.Add(tariff);
            await _context.SaveChangesAsync();
            return tariff;
        }

        public async Task<bool> UpdateTariffAsync(int id, Tariff tariff)
        {
            if (id != tariff.Id)
                return false;

            _context.Entry(tariff).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTariffAsync(int id)
        {
            var tariff = await _context.Tariffs.FindAsync(id);
            if (tariff == null)
                return false;

            _context.Tariffs.Remove(tariff);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
