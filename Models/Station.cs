using System.ComponentModel.DataAnnotations.Schema;

namespace OCPIApp.Models;
[Table("Station")]
public class Station
{
    [Column("Id")]
    public int Id { get; set; }
    [Column("Name")]
    public string Name { get; set; } = "";
    [Column("Location")]
    public string Location { get; set; } = "";
    [Column("IsAvailable")]
    public bool IsAvailable { get; set; }
}
