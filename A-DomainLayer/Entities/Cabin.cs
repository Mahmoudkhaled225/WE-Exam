using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Cabin : BaseEntity
{
    public string Cabin_Name { get; set; }
    
    public int TowerId { get; set; }
    [JsonIgnore]
    public Tower Tower { get; set; }
    
}