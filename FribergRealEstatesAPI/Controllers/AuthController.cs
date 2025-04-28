using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Data;
using FribergRealEstatesAPI.Data.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FribergRealEstatesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;

        public AuthController(UserManager<ApiUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        [Route("register")]

        public async Task<IActionResult> Register(UserDto userDto)
        {
            try
            {
                ApiUser user = new ApiUser()
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName
                };

                var result = await _userManager.CreateAsync(user, userDto.Password);

                if (result.Succeeded == false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                await _userManager.AddToRoleAsync(user, ApiRoles.User);
                return Accepted();
            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode : 500);
            }
        }
    }
}
