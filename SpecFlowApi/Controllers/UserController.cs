using Data.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace SpecFlowApi.Controllers
{
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
        public virtual async Task<ActionResult<User>> Get(int id, CancellationToken cancellationToken)
        {
            return Ok(await _userRepository.GetUserById(id, cancellationToken));
        }
        [HttpPost]
        public virtual async Task<ActionResult> Post([FromBody] User user, CancellationToken cancellationToken)
        {
            await _userRepository.AddUser(user, cancellationToken);
            return Ok();
        }
    }
}
