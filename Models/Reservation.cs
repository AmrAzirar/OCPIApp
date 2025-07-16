namespace OCPIApp.Models;

public class Reservation
{
    public int Id { get; set; }
    public int StationId { get; set; }
    public DateTime ReservedAt { get; set; }
    public DateTime ReservedUntil { get; set; }
}
