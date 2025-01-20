using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Network_Element : BaseEntity
{
    
    public string Network_Element_Name { get; set; }
    
    public int Network_Element_Type_Id { get; set; }
    
    
    public int? Parent_Network_Element_Id { get; set; }
    [JsonIgnore]
    public Network_Element? Parent_Network_Element { get; set; }
    
}