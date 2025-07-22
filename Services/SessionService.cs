using OCPIApp.Models;
using OCPIApp.Repositories;

namespace OCPIApp.Services
{
    public class SessionService : ISessionService
    {
        private readonly ISessionRepository _sessionRepository;

        public SessionService(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public async Task<List<Session>> GetSessionsAsync()
        {
            return await _sessionRepository.GetAllSessionsAsync();
        }
        
        public async Task<Session> GetSessionByIdAsync(int id)
        {
            return await _sessionRepository.GetSessionByIdAsync(id);
        }

        public async Task<Session> CreateSessionAsync(Session session)
        {
            return await _sessionRepository.AddSessionAsync(session);
        }

        public async Task<bool> UpdateSessionAsync(int id, Session session)
        {
            return await _sessionRepository.UpdateSessionAsync(id, session);
        }

        public async Task<bool> DeleteSessionAsync(int id)
        {
            return await _sessionRepository.DeleteSessionAsync(id);
        }
    }
}
