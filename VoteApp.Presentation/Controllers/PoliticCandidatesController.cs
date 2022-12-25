using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace VoteApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/politics")]
    public class PoliticCandidatesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PoliticCandidatesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPolitics()
        {
            
                var politics = _service.PoliticCandidateService.GetAllPoliticCandidate(false);
                return Ok(politics);
            
        }

        [HttpGet("{politicId:guid}")]
        public IActionResult GetPolitic(Guid politicId)
        {
            var politic = _service.PoliticCandidateService.GetPoliticCandidate(politicId, false);
            return Ok(politic);
        }
    }
}
