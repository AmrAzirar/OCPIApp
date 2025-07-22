using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCPIApp.Models;
[Table("Reservation")]
public class Reservation
{
    [Column("Id")]
    public int Id { get; set; }
    [Column("StationId")]
    public int StationId { get; set; }
    [Column("ReservedAt")]
    public DateTime ReservedAt { get; set; }
    [Column("ReservedUnti")]
    public DateTime ReservedUntil { get; set; }
}
