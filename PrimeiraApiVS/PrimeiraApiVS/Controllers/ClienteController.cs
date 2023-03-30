using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApiVS.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class ClienteController : ControllerBase
    {

        [HttpGet("path")]
        public string Get()
        {
            return "Texto";
        }
    }
}