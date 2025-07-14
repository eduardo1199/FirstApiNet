using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class FirstApiNetController : ControllerBase
    {
        public string Author { get; set; } = "Eduardo Soares";

        [HttpGet("healthy")]
        public IActionResult Healthy()
        {
            return Ok("Its working");
        }

        protected string GetCustomKey ()
        {
            return Request.Headers["MyKey"].ToString();
        }
    }
}
