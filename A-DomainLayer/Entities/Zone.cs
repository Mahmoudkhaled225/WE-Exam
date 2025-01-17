namespace ClassLibrary1.Entities;

public class Zone : BaseEntity
{
    
    public string Zone_Name { get; set; }
    
    public int SectorId { get; set; }
    public Sector Sector { get; set; }
}