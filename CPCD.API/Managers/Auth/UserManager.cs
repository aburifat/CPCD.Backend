using CPCD.Repository.Domains.Models;
using CPCD.Repository.Domains.Requests;
using CPCD.Repository.Domains.Responses;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using static CPCD.Repository.Constants.Constants;

namespace CPCD.API.Managers;

public class UserManager : IUsersManager
{
    private readonly AppUserManager<User> _appUsersManager;
    public UserManager(
        AppUserManager<User> appUserManager
        )
    {
        _appUsersManager = appUserManager;
    }

    public async Task<CreateUserResponse> CreateUser(CreateUserRequest request)
    {
        var newUser = new User
        {
            FirstName = request.FirstName.Trim(),
            LastName = string.IsNullOrWhiteSpace(request.LastName) ? request.LastName.Trim() : string.Empty,
            UserName = request.Email.Trim(),
            Email = request.Email.Trim(),
            Gender = request.Gender
        };

        var userCreateResult = await _appUsersManager.CreateAsync(newUser, request.Password);
        if (userCreateResult.Succeeded == false)
        {
            throw new Exception("Error Creating User!");
        }

        var result = await _appUsersManager.AddToRoleAsync(user: newUser, role: UserRoles.GetRoleById(request.RoleId));
        var resultClaim = await _appUsersManager.AddClaimAsync(user: newUser, claim: new Claim(ClaimTypes.Role, UserRoles.GetRoleById(request.RoleId)));

        return new CreateUserResponse
        {
            IsOperationSuccessful = result.Succeeded && resultClaim.Succeeded,
            Message = result.Succeeded && resultClaim.Succeeded ? "success" : "error"
        };
    }

    public Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUser(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUserRole(long id)
    {
        throw new NotImplementedException();
    }

    public Task<GetUserResponse> GetCurrentUser()
    {
        throw new NotImplementedException();
    }

    public Task<GetUserResponse> GetUserById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GetUserResponse>> GetUserList(GetUserListRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GetUserRoleResponse>> GetUserRoleList()
    {
        throw new NotImplementedException();
    }

    public Task<AuthTokenResponse> Signin(SignInRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<AuthTokenResponse> SignUp(SignUpRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUser(UpdateUserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateUserRole(UpdateUserRoleRequest request)
    {
        throw new NotImplementedException();
    }
}
