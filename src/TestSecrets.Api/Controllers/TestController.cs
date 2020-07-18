using Microsoft.AspNetCore.Mvc;

namespace TestSecrets.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : Controller
    {
        private readonly SampleService _sampleService;
        private readonly MovieSettings _movieSettings;

        public TestController(SampleService sampleService, MovieSettings movieSettings)
        {
            _sampleService = sampleService;
            _movieSettings = movieSettings;
        }
        // GET
        [HttpGet]
        public string Get()
        {
            var serviceApiKey = $"ApiKey: {_sampleService.ApiKey}";
            var movieApiKey = $"Movies ApiKey: {_movieSettings.ServiceApiKey}";
            var movieConnection = $"Movies Connection String: {_movieSettings.ConnectionString}";
            return $"{movieApiKey}\n{movieConnection}";
            
        }
    }
}