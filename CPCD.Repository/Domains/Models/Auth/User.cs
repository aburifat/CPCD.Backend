using CPCD.Repository.Domains.Enums;
using Microsoft.AspNetCore.Identity;
using System;

namespace CPCD.Repository.Domains.Models;

public class User : IdentityUser<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime JoinedAt { get; set; }
    public Gender? Gender { get; set; }
}
