using Microsoft.AspNetCore.Mvc;
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Repositories.Abstract;

namespace ZambarakUz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        private readonly IRepository<UserGroup> _userGroupRepository;

        public UserGroupController(IRepository<UserGroup> userGroupRepository)
        {
            _userGroupRepository = userGroupRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserGroups()
        {
            var userGroups = await _userGroupRepository.GetAll();
            return Ok(userGroups);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserGroupById(Guid id)
        {
            var userGroup = await _userGroupRepository.GetById(id);
            if (userGroup == null)
            {
                return NotFound();
            }
            return Ok(userGroup);
        }

        [HttpPost]
        public IActionResult CreateUserGroup(UserGroup userGroup)
        {
            _userGroupRepository.Add(userGroup);
            return CreatedAtAction(nameof(GetUserGroupById), new { id = userGroup.UID }, userGroup);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserGroup(Guid id, UserGroup userGroup)
        {
            if (id != userGroup.UID)
            {
                return BadRequest();
            }

            _userGroupRepository.Update(userGroup);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserGroup(Guid id)
        {
            var existingUserGroup = _userGroupRepository.GetById(id).Result;
            if (existingUserGroup == null)
            {
                return NotFound();
            }

            _userGroupRepository.Delete(existingUserGroup);
            return NoContent();
        }
    }
}
