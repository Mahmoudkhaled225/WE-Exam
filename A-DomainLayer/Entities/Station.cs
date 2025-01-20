using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Station : BaseEntity
{
    
    public string Station_Name { get; set; }
    
    public int CityId { get; set; }
    [JsonIgnore]
    public City City { get; set; }
    
}