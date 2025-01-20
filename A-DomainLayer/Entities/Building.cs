using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Building : BaseEntity
{
    public string Building_Name { get; set; }
    
    public int BlockId { get; set; }
    [JsonIgnore]
    public Block Block { get; set; }
}