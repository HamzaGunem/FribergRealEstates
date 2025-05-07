using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Data;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Data.Interfaces;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FribergRealEstatesAPI.Controllers
{
    //Alla
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IRealtorRepository _realtorRepository;
        private readonly IAgencyRepository _agencyRepository;

        public AuthController(UserManager<ApiUser> userManager, IConfiguration configuration, IRealtorRepository realtorRepository, IAgencyRepository agencyRepository)
        {
            _userManager = userManager;
            _configuration = configuration;
            _realtorRepository = realtorRepository;
            _agencyRepository = agencyRepository;
        }


        // Samuel
        private ApiUser CreateApiUser(RegisterDto regDto)
        {
            ApiUser user = new ApiUser()
            {
                UserName = regDto.Email,
                NormalizedUserName = regDto.Email.ToUpper(),
                Email = regDto.Email,
                NormalizedEmail = regDto.Email.ToUpper(),
                FirstName = regDto.FirstName,
                LastName = regDto.LastName,
                EmailConfirmed = false,
            };
            return user;
        }

        // Samuel
        private Realtor CreateRealtor(RegisterDto regDto)
        {
            Realtor realtor = new Realtor()
            {
                Email = regDto.Email,
                PhoneNumber = regDto.PhoneNumber,
                FirstName = regDto.FirstName,
                LastName = regDto.LastName,
                PictureUrl = regDto.PictureUrl,
                AgencyId = regDto.AgencyId,
            };
            return realtor;
        }

        // Samuel
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegisterDto regDto)
        {
            ApiUser newUser = new();
            Realtor newRealtor = new();
            try
            {
                newUser = CreateApiUser(regDto);
                await _userManager.CreateAsync(newUser, regDto.Password);
                await _userManager.AddToRoleAsync(newUser, ApiRoles.User);
            }
            catch(Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
            }
            
            try
            {
                newRealtor = CreateRealtor(regDto);
                newRealtor.Agency = await _agencyRepository.GetByIdAsync(regDto.AgencyId);
                newRealtor.ApiUserId = newUser.Id;
                newRealtor.ApiUser = newUser;
                await _realtorRepository.AddAsync(newRealtor);

            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
            }

            return Ok();
        }
        /*
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
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
            }
        }
        */
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponse>> Login(LoginUserDto userdto)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(userdto.Email);
                var passwordValid = await _userManager.CheckPasswordAsync(user, userdto.Password);
                if (!passwordValid || user == null)
                {
                    return Unauthorized();
                }
                string tokenString = await GenerateToken(user);
                var response = new AuthResponse
                {
                    Email = userdto.Email,
                    Token = tokenString,
                    UserId = user.Id,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return Problem($"Something Went Wrong in the {nameof(Login)}", statusCode: 500);
            }
        }

        private async Task<string> GenerateToken(ApiUser user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(q => new Claim(ClaimTypes.Role, q)).ToList();
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id),
                //new Claim(ClaimTypes.NameIdentifier, user.Id),
            }
            .Union(roleClaims);

            var token = new JwtSecurityToken(issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
