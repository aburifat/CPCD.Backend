using CPCD.API.Managers;
using CPCD.Repository.Domains.Requests;
using CPCD.Repository.Domains.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CPCD.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersManager _userManager;
        public UsersController(IUsersManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var result = await _userManager.CreateUser(request);
            return Ok(result);
        }

        [HttpPut("updateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserRequest request)
        {
            var result = await _userManager.UpdateUser(request);
            return Ok(result);
        }

        [HttpGet("getUserList")]
        public async Task<IActionResult> GetUserList([FromQuery] GetUserListRequest request)
        {
            var result = await _userManager.GetUserList(request);
            return Ok(result);
        }

        [HttpGet("getCurrentUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var result = await _userManager.GetCurrentUser();
            return Ok(result);
        }

        [HttpGet("getUserById")]
        public async Task<IActionResult> GetUserById([FromQuery] long id)
        {
            var result = await _userManager.GetUserById(id);
            return Ok(result);
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest request)
        {
            AuthTokenResponse result = await _userManager.SignUp(request);
            return Ok(result);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequest request)
        {
            AuthTokenResponse result = await _userManager.Signin(request);
            return Ok(result);
        }

        [HttpGet("getUserRoleList")]
        public async Task<IActionResult> GetUserRoleList()
        {
            var result = await _userManager.GetUserRoleList();
            return Ok(result);
        }

        [HttpGet("createUserRole")]
        public async Task<IActionResult> CreateUserRole([FromBody] CreateUserRoleRequest request)
        {
            var result = await _userManager.CreateUserRole(request);
            return Ok(result);
        }

        [HttpGet("updateUserRole")]
        public async Task<IActionResult> UpdateUserRole([FromBody] UpdateUserRoleRequest request)
        {
            var result = await _userManager.UpdateUserRole(request);
            return Ok(result);
        }

        [HttpGet("deleteUserRole")]
        public async Task<IActionResult> DeleteUserRole([FromQuery] long id)
        {
            var result = await _userManager.DeleteUserRole(id);
            return Ok(result);
        }
    }
}
