using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace VoteApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductCandidatesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductCandidatesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProductCandidates()
        {

            var products = _service.ProductCandidateService.GetAllProductCandidate(false);
            return Ok(products);

        }

        [HttpGet("{productId:guid}")]
        public IActionResult GetProductCandidate(Guid productId)
        {
            var product = _service.ProductCandidateService.GetProductCandidate(productId, false);
            return Ok(product);
        }

    }
}
