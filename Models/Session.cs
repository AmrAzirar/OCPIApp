namespace OCPIApp.Models;

public class Session
{
    public int Id { get; set; }
    public int StationId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public double EnergyConsumed { get; set; }
}
