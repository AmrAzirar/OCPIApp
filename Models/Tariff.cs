using System.ComponentModel.DataAnnotations.Schema;

namespace OCPIApp.Models;

[Table("Tariff")]

public class Tariff
{
    [Column("Id")]
    public int Id { get; set; }
    [Column("c")]
    public string c { get; set; } = "energy"; // energy, time, flat...
    [Column("Price")]
    public decimal Price { get; set; }
    [Column("Unit")]
    public string Unit { get; set; } = "kWh"; // kWh, min, etc.
}
