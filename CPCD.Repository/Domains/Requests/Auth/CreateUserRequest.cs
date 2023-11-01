using CPCD.Repository.Domains.Enums;

namespace CPCD.Repository.Domains.Requests;

public class CreateUserRequest
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public Gender? Gender { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }

    public long RoleId { get; set; }
}
