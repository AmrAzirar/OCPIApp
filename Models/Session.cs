using System.ComponentModel.DataAnnotations.Schema;

namespace OCPIApp.Models;

[Table("Session")]
public class Session
{
    [Column("Id")] 
    public int Id { get; set; }
    [Column("StationId")]
    public int StationId { get; set; }
    [Column("StartTime")]
    public DateTime StartTime { get; set; }
    [Column("EndTime")]
    public DateTime? EndTime { get; set; }
    [Column("EnergyConsumed")]
    public double EnergyConsumed { get; set; }
}
