using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Subscription : BaseEntity
{
    public int FlatId { get; set; }
    [JsonIgnore]
    public Flat Flat { get; set; }
    
    public int BuildingId { get; set; }
    [JsonIgnore]
    public Building Building { get; set; }
    
    /// ????
    public int Meter_Key { get; set; }
    public int Paiet_Key { get; set; }

    
}