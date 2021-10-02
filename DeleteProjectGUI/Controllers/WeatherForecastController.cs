using DeleteProjectFacade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeleteProjectGUI.Controllers
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
            return _facade.GetStudent(new DeleteProjectResReq.StudentRequest());
        }
    }
}
