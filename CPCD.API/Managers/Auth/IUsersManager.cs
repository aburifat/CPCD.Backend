using CPCD.Repository.Domains.Requests;
using CPCD.Repository.Domains.Responses;

namespace CPCD.API.Managers;

public interface IUsersManager
{
    Task<CreateUserResponse> CreateUser(CreateUserRequest request);
    Task<bool> UpdateUser(UpdateUserRequest request);
    Task<bool> DeleteUser(long id);
    Task<IEnumerable<GetUserResponse>> GetUserList(GetUserListRequest request);
    Task<GetUserResponse> GetCurrentUser();
    Task<GetUserResponse> GetUserById(long id);
    Task<AuthTokenResponse> SignUp(SignUpRequest request);
    Task<AuthTokenResponse> Signin(SignInRequest request);
    Task<IEnumerable<GetUserRoleResponse>> GetUserRoleList();
    Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest request);
    Task<bool> UpdateUserRole(UpdateUserRoleRequest request);
    Task<bool> DeleteUserRole(long id);
}
