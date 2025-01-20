using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Zone : BaseEntity
{
    
    public string Zone_Name { get; set; }
    
    public int SectorId { get; set; }
    [JsonIgnore]
    public Sector Sector { get; set; }
}