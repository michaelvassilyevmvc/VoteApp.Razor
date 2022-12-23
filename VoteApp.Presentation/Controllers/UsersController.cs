using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace VoteApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UsersController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = _service.UserService.GetAllUsers(false);
                return Ok(users);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
