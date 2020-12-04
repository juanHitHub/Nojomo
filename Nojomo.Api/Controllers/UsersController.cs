using Microsoft.AspNetCore.Mvc;
using Nojomo.Core.Entities;
using Nojomo.Core.Interfaces;
using Nojomo.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace Nojomo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _userRepository;
        public UsersController(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // POST: api/Users
        [HttpPost("Login")]
        public async Task<ActionResult<UserWithToken>> Login([FromBody] Usuario user)
        {
            UserWithToken userWithToken = await _userRepository.Login(user);
            if (userWithToken == null)
            {
                return NotFound();
            }
            return userWithToken;


        }

        // POST: api/Users
        [HttpPost("RegisterUser")]
        public async Task<ActionResult<UserWithToken>> RegisterUser([FromBody] Usuario user)
        {
            UserWithToken userWithToken = await _userRepository.RegisterUser(user);
           
            if (userWithToken == null)
            {
                return NotFound();
            }

            return userWithToken;
        }

        // GET: api/Users
        [HttpPost("RefreshToken")]
        public async Task<ActionResult<UserWithToken>> RefreshToken([FromBody] RefreshRequest refreshRequest)
        {
           return await _userRepository.RefreshToken(refreshRequest);
        }

        // GET: api/Users
        [HttpPost("GetUserByAccessToken")]
        public async Task<ActionResult<Usuario>> GetUserByAccessToken([FromBody] string accessToken)
        {
            return await _userRepository.GetUserByAccessToken(accessToken);
        }

       

    }
}
