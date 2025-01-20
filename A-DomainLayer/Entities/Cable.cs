using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Cable : BaseEntity
{
    public string Cable_Name { get; set; }

    public int CabinId { get; set; }
    [JsonIgnore] 
    public Cabin Cabin { get; set; }

}