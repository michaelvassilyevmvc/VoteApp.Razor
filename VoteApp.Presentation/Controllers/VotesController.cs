using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace VoteApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/votes")]
    public class VotesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public VotesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetVotes()
        {
            try
            {
                var votes = _service.VoteService.GetAllVotes(false);
                return Ok(votes);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
