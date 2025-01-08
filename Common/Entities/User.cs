using Microsoft.AspNetCore.Identity;

namespace Common.Entities;

public class User : IdentityUser
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
}