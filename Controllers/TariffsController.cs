using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OCPIApp.Data;
using OCPIApp.Models;

namespace OCPIApp.Controllers
{
    [Route("ocpi/[controller]")]
    [ApiController]
    public class TariffsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TariffsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /ocpi/tariffs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tariff>>> GetTariffs()
        {
            var tariffs = await _context.Tariffs.ToListAsync();
            return tariffs.Any() ? Ok(tariffs) : NotFound("No tariffs found.");
        }

        // GET: /ocpi/tariffs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tariff>> GetTariff(int id)
        {
            var tariff = await _context.Tariffs.FindAsync(id);
            return tariff != null ? Ok(tariff) : NotFound();
        }

        // POST: /ocpi/tariffs
        [HttpPost]
        public async Task<ActionResult<Tariff>> PostTariff(Tariff tariff)
        {
            _context.Tariffs.Add(tariff);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTariff", new { id = tariff.Id }, tariff);
        }

        // PUT: /ocpi/tariffs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTariff(int id, Tariff tariff)
        {
            if (id != tariff.Id)
                return BadRequest();

            _context.Entry(tariff).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: /ocpi/tariffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTariff(int id)
        {
            var tariff = await _context.Tariffs.FindAsync(id);
            if (tariff == null) return NotFound();
            _context.Tariffs.Remove(tariff);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
