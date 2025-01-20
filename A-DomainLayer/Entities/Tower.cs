using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Tower : BaseEntity
{
    
    public string Tower_Name { get; set; }
    
    public int StationId { get; set; }
    [JsonIgnore]
    public Station Station { get; set; }
    
}