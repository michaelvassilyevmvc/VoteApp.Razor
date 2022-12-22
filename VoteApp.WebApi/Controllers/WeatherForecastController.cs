using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace VoteApp.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("LogInfo");
            return new string[] { "value0", "value1" };
        }
    }
}