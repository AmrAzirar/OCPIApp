using OCPIApp.Models;
using OCPIApp.Repositories;

namespace OCPIApp.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        
        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<Reservation>> GetReservationsAsync()
        {
            return await _reservationRepository.GetAllReservationsAsync();
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            

            return await _reservationRepository.GetReservationByIdAsync(id);
        }

        public async Task<Reservation> CreateReservationAsync(Reservation reservation)
        {
            return await _reservationRepository.AddReservationAsync(reservation);
        }

        public async Task<bool> UpdateReservationAsync(int id, Reservation reservation)
        {
            return await _reservationRepository.UpdateReservationAsync(id, reservation);
        }

        public async Task<bool> DeleteReservationAsync(int id)
        {
            return await _reservationRepository.DeleteReservationAsync(id);
        }
    }
}
