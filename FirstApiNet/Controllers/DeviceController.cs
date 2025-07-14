using FirstApiNet.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers
{
    public class DeviceController : FirstApiNetController
    {
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var laptop = new Laptop();
            var key = GetCustomKey();

            var model = laptop.GetModel();

            return Ok(key);
        }
    }
}
