using Microsoft.IdentityModel.Tokens;
using PokemonModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PokemonApi.Repository
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private IConfiguration configuration;
        public JWTManagerRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        Dictionary<string, string> UsersRecords = new Dictionary<string, string>
        {
            {"user1", "password1" },
            {"user2", "password2" },
            {"user3", "password3" },
        };
        public Tokens Authenticate(User user)
        {
            //checking if the user is available in the Dictionery which will from the database later
            if (!UsersRecords.Any(a => a.Key == user.UserName && a.Value == user.Password))
            {
                return null;
            }
            // else we want generate JWT Token
            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                            new Claim(ClaimTypes.Name, user.UserName)
                    }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
            };

            var token=tokenhandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenhandler.WriteToken(token) };
        }
    }
}
