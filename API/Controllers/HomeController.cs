using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Controller]
    [Route("")]
    public class HomeController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World!";
        }
    }
}