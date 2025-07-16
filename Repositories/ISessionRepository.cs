using OCPIApp.Models;

namespace OCPIApp.Repositories
{
    public interface ISessionRepository
    {
        Task<List<Session>> GetAllSessionsAsync();
        Task<Session> GetSessionByIdAsync(int id);
        Task<Session> AddSessionAsync(Session session);
        Task<bool> UpdateSessionAsync(int id, Session session);
        Task<bool> DeleteSessionAsync(int id);
    }
}
