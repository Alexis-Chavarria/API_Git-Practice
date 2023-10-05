using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Git_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // GET: api/user/hello
        [HttpGet("hello")]
        public ActionResult<string> GetHelloMessage()
        {
            return "¡Hola, usuario! Esta es una respuesta de texto simple.";
        }
    }
}
