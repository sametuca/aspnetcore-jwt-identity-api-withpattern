using AuthAndArchitecture.Facade.Abstract;
using AuthAndArchitecture.ResponseRequest.Post.Res;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AuthAndArchitecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPostFacade facade;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPostFacade _facade)
        {
            _logger = logger;
            facade = _facade;
        }

        [HttpGet]
        public Task<GetPostResponse> GetAllPost()
        {
            var respose = facade.GetAllPost(new ResponseRequest.Post.Req.GetPostRequest());
            return respose;
        }

    }
}
