using Microsoft.AspNetCore.Mvc;
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Repositories.Abstract;

namespace ZambarakUz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            var user = await _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _userRepository.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.UID }, user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, User user)
        {
            if (id != user.UID)
            {
                return BadRequest();
            }

            _userRepository.Update(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Delete(user.Result);
            return NoContent();
        }
    }
}
