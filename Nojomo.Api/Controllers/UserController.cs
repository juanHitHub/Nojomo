using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nojomo.Core.Entities;
using Nojomo.Core.Interfaces;
using System.Threading.Tasks;

namespace Nojomo.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserId(int id)
        {
            var user = await _userRepository.GetUser(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Usuario(Usuario user)
        {
           var res= await _userRepository.InsertUser(user);
            return Ok(res);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id,Usuario user)
        {
            await _userRepository.UpdateUser(id,user);
            return Ok(user);
            
        }

       
    }
}
