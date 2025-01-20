using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Netwoek_element_Type : BaseEntity
{
    
    public string Netwoek_element_Type_Name { get; set; }
    
    public int? Network_Element_Type_Parent_Id { get; set; }
    [JsonIgnore]
    public Netwoek_element_Type? Network_Element_Type_Parent { get; set; }
    
    public int Network_Element_Hierarchy_Path_Key { get; set; }
    
    
    
}