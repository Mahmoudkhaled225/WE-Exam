namespace ClassLibrary1.Entities;

public class Station : BaseEntity
{
    
    public string Station_Name { get; set; }
    
    public int CityId { get; set; }
    public City City { get; set; }
    
}