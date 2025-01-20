using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Flat : BaseEntity
{
    public string Flat_Name { get; set; }
    
    public int BuildingId { get; set; }
    [JsonIgnore]
    public Building Building { get; set; }
}