using OCPIApp.Models;

namespace OCPIApp.Services
{
    public interface ISessionService
    {
        Task<List<Session>> GetSessionsAsync();
        Task<Session> GetSessionByIdAsync(int id);
        Task<Session> CreateSessionAsync(Session session);
        Task<bool> UpdateSessionAsync(int id, Session session);
        Task<bool> DeleteSessionAsync(int id);
    }
}
