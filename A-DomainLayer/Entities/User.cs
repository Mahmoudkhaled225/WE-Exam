using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Entities;

public class User : BaseEntity
{
    public string Name { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Password { get; set; }

}