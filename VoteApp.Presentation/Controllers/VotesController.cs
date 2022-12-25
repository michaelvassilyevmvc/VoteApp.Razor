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
                var votes = _service.VoteService.GetAllVotes(false);
                return Ok(votes);
            
        }

        [HttpGet("byVote")]
        public IActionResult GetVote(Guid userId, Guid candidateId)
        {
            var vote = _service.VoteService.GetVote(userId, candidateId, false);
            return Ok(vote);
        }
    }
}
