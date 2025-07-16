using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OCPIApp.Data;
using OCPIApp.Models;

namespace OCPIApp.Controllers
{
    [Route("ocpi/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SessionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /ocpi/sessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Session>>> GetSessions()
        {
            var sessions = await _context.Sessions.ToListAsync();
            if (sessions == null || sessions.Count == 0)
            {
                return NotFound("No sessions found.");
            }

            return Ok(sessions); // Renvoie la liste des sessions
        }

        // GET: /ocpi/sessions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Session>> GetSession(int id)
        {
            var session = await _context.Sessions.FindAsync(id);

            if (session == null)
            {
                return NotFound();
            }

            return Ok(session); // Renvoie une session spécifique par ID
        }

        // POST: /ocpi/sessions
        [HttpPost]
        public async Task<ActionResult<Session>> PostSession(Session session)
        {
            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSession", new { id = session.Id }, session); // Crée une nouvelle session
        }

        // PUT: /ocpi/sessions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSession(int id, Session session)
        {
            if (id != session.Id)
            {
                return BadRequest();
            }

            _context.Entry(session).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Met à jour une session existante
        }

        // DELETE: /ocpi/sessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSession(int id)
        {
            var session = await _context.Sessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }

            _context.Sessions.Remove(session);
            await _context.SaveChangesAsync();

            return NoContent(); // Supprime une session
        }
    }
}
