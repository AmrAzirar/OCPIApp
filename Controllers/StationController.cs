using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OCPIApp.Data;
using OCPIApp.Models;

namespace OCPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StationController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/stations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Station>>> GetStations()
        {
            var stations = await _context.Stations.ToListAsync();
            if (stations == null || stations.Count == 0)
            {
                return NotFound("No stations found.");
            }

            return Ok(stations); // Renvoie la liste des stations
        }

        // GET: api/stations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Station>> GetStation(int id)
        {
            var station = await _context.Stations.FindAsync(id);

            if (station == null)
            {
                return NotFound();
            }

            return Ok(station); // Renvoie une station spécifique par ID
        }

        // POST: api/stations
        [HttpPost]
        public async Task<ActionResult<Station>> PostStation(Station station)
        {
            _context.Stations.Add(station);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStation", new { id = station.Id }, station); // Crée une nouvelle station
        }

        // PUT: api/stations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStation(int id, Station station)
        {
            if (id != station.Id)
            {
                return BadRequest();
            }

            _context.Entry(station).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Met à jour une station existante
        }

        // DELETE: api/stations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStation(int id)
        {
            var station = await _context.Stations.FindAsync(id);
            if (station == null)
            {
                return NotFound();
            }

            _context.Stations.Remove(station);
            await _context.SaveChangesAsync();

            return NoContent(); // Supprime une station
        }
    }
}
