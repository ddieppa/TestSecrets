using Microsoft.AspNetCore.Mvc;

namespace TestSecrets.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TestController : Controller
    {
        private readonly SampleService _sampleService;

        public TestController(SampleService sampleService)
        {
            _sampleService = sampleService;
        }
        // GET
        [HttpGet]
        public string Index()
        {
            return $"ApiKey: {_sampleService.ApiKey}";
        }
    }
}