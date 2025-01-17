namespace ClassLibrary1.Entities;

public class City : BaseEntity
{
    
    public string City_Name { get; set; }
    
    public int ZoneId { get; set; }
    public Zone Zone { get; set; }    
}