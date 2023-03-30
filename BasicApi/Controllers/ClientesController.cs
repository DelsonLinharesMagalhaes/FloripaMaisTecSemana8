using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("Clientex")]
    public class ClientesControllers : Controller
    {
        [HttpGet]
        public ActionResult Metodo ([FromQuery]string nome) {return Ok("Ola " + nome);}
        
    }
}