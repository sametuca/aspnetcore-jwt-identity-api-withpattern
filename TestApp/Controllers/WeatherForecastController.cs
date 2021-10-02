using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TestApp.Command;
using TestApp.Facade;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IFacade _facade;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IFacade facade)
        {
            _logger = logger;
            _facade = facade;
        }

        [HttpGet]
        public Task<StudentResponse> Get()
        {
            var response = _facade.GetStudent(new StudentRequest { });
            return response;
        }
    }
}
