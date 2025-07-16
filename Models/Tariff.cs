namespace OCPIApp.Models;

public class Tariff
{
    public int Id { get; set; }
    public string Type { get; set; } = "energy"; // energy, time, flat...
    public decimal Price { get; set; }
    public string Unit { get; set; } = "kWh"; // kWh, min, etc.
}
