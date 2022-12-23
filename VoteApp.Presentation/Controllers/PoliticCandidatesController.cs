﻿using Microsoft.AspNetCore.Mvc;
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
            try
            {
                var politics = _service.PoliticCandidateService.GetAllPoliticCandidate(false);
                return Ok(politics);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
