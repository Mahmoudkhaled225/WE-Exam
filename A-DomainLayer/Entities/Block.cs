using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Block : BaseEntity
{
    public string Block_Name { get; set; }

    public int CableId { get; set; }
    [JsonIgnore] 
    public Cable Cable { get; set; }

}