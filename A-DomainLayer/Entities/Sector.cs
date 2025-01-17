namespace ClassLibrary1.Entities;

public class Sector : BaseEntity
{
    public string Sector_Name { get; set; }
    
    public int GovernrateId { get; set; }
    public Governrate Governrate { get; set; }
}