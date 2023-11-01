using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace CPCD.API.Managers;

public interface IUsersManager
{
    Task<CreateUserResponse> CreateUser(CreateUserRequest request);
    Task<bool> UpdateUser(UpdateUserRequest request);
    Task<IEnumerable<GetUserResponse>> GetUserList(GetUserListRequest request);
    Task<GetUserResponse> GetCurrentUser();
    Task<GetUserResponse> getUserById(long id);
    Task<TokenViewModel> SignUp(SignUpRequest request);
    Task<TokenViewModel> Signin(SignInRequest request);
    Task<IEnumerable<GetUserRoleResponse>> GetUserRoles();
    Task<bool> CreateUserRole(CreateUserRoleRequest request);
    Task<bool> UpdateUserRole(UpdateUserRoleRequest request);
    Task<bool> DeleteUserRole(DeleteUserRoleRequest request);
}
