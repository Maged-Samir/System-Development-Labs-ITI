using ITI.Revision.WebAPI.DTO.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ITI.Revision.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUser> UserManager;

        public IConfiguration Configuration { get; }
        public UsersController(IConfiguration configuration,
            UserManager<IdentityUser> userManager)
        {
            Configuration = configuration;
            UserManager = userManager;
        }

       

        [HttpPost]
        [Route("StaticLogin")]
        public ActionResult<TokenDTO> Login(LoginDTO credentials)
        {
            if(credentials.UserName != "admin" || credentials.Password !="Pass123")
            {
                return Unauthorized();
            }

            var claimsList = new List<Claim>
            {
                new Claim ("Any Key","Some Value"),
                new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Email,"Somemail.gmail.com")
            };

            //Generate SecretKey
            var SecritKeySting = Configuration.GetValue<string>("SecritKey") ??string.Empty;
            var SecritKeyInBytes = Encoding.ASCII.GetBytes(SecritKeySting);
            var SecritKey = new SymmetricSecurityKey(SecritKeyInBytes);

            //combination Secrte Key , Hashing Algo
            var SigningCredentials = new SigningCredentials(SecritKey,
                SecurityAlgorithms.HmacSha256Signature);

            //then Install-Package System.IdentityModel.Tokens.Jwt
            //this package will generate our token 

            var expiry = DateTime.Now.AddDays(1);

            var token = new JwtSecurityToken(
                claims: claimsList,
                expires: expiry,
                signingCredentials: SigningCredentials); 

            var tokenHandler=new JwtSecurityTokenHandler();
            var tokenString =tokenHandler.WriteToken(token);

            return new TokenDTO(tokenString);
        }



        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDto registerDto)
        {
            var UserToAdd = new IdentityUser
            {
                UserName=registerDto.UserName,
                Email=registerDto.Email,
            };

            var result = await UserManager.CreateAsync(UserToAdd, registerDto.Password);
            if(!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,UserToAdd.Id),
                new Claim("Role","Manager"),
            };

            await UserManager.AddClaimsAsync(UserToAdd, claims);

            return NoContent();

        }



        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDTO>> LoginJWT(LoginDTO credentials)
        {
            var user = await UserManager.FindByNameAsync(credentials.UserName);
            if(user == null)
            {
                return NotFound();
            }

            var isAuthenticated= await UserManager.CheckPasswordAsync(user, credentials.Password);
            if(!isAuthenticated)
            {
                return Unauthorized();
            }

            var claimsList = await UserManager.GetClaimsAsync(user);
            

            //Generate SecretKey
            var SecritKeySting = Configuration.GetValue<string>("SecritKey") ?? string.Empty;
            var SecritKeyInBytes = Encoding.ASCII.GetBytes(SecritKeySting);
            var SecritKey = new SymmetricSecurityKey(SecritKeyInBytes);

            //combination Secrte Key , Hashing Algo
            var SigningCredentials = new SigningCredentials(SecritKey,
                SecurityAlgorithms.HmacSha256Signature);

            //then Install-Package System.IdentityModel.Tokens.Jwt
            //this package will generate our token 

            var expiry = DateTime.Now.AddDays(1);

            var token = new JwtSecurityToken(
                claims: claimsList,
                expires: expiry,
                signingCredentials: SigningCredentials);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenString = tokenHandler.WriteToken(token);

            return new TokenDTO(tokenString);
        
        }


    }
}
