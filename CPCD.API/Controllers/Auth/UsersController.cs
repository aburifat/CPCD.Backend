using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace CPCD.API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var result = await _userManager.CreateUser(request);
            return Ok(result);
        }

        [Authorize]
        [HttpPut("updateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserProfileRequest request)
        {
            var result = await _userManager.UpdateUserProfile(request);
            return Ok(result);
        }

        [HttpGet("getUsers")]
        public async Task<IActionResult> GetUserList([FromQuery] GetUsersRequest request)
        {
            var result = await _userManager.GetUsers(request);
            return Ok(result);
        }

        [Authorize]
        [HttpGet("getCurrentUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var result = await _userManager.GetUserProfile();
            return Ok(result);
        }

        [HttpGet("getUserById")]
        public async Task<IActionResult> getUserById([FromQuery] long id)
        {
            var result = await _userManager.GetUserProfileById(id);
            return Ok(result);
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest request)
        {
            TokenViewModel result = await _userManager.SignUp(request);
            return Ok(result);
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromBody] SignInRequest request)
        {
            TokenViewModel result = await _userManager.Signin(request);
            return Ok(result);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("getUserRoles")]
        public async Task<IActionResult> GetUserRoles()
        {
            var result = await _userManager.GetUserRoles();
            return Ok(result);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("createUserRole")]
        public async Task<IActionResult> CreateUserRole()
        {
            var result = await _userManager.GetUserRoles();
            return Ok(result);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("updateUserRole")]
        public async Task<IActionResult> UpdateUserRole()
        {
            var result = await _userManager.GetUserRoles();
            return Ok(result);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpGet("deleteUserRole")]
        public async Task<IActionResult> DeleteUserRole()
        {
            var result = await _userManager.GetUserRoles();
            return Ok(result);
        }
    }
}
