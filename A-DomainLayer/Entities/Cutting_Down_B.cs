using System.Text.Json.Serialization;

namespace ClassLibrary1.Entities;

public class Cutting_Down_B : BaseEntity
{
    public string Cutting_Down_Cable_Name { get; set; }

    public int ProblemTypeId { get; set; }
    [JsonIgnore]
    public ProblemType ProblemType { get; set; }
    
    public DateTime? EndDate { get; set; }


    public bool lsplanned { get; set; }
    public bool lsGlobal { get; set; }
    public DateTime? PlannedStartoTS { get; set; }
    public DateTime? PlannedendDTs { get; set; }
    public bool IsActive { get; set; }

    
    public int CreatedUserId { get; set; }
    [JsonIgnore]
    public User CreatedUser { get; set; }
    
    public int? UpdatedUserId { get; set; }
    [JsonIgnore]
    public User? UpdatedUser { get; set; }
    
    
}