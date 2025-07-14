using FirstApiNet.Requests;
using FirstApiNet.Response;
using Microsoft.AspNetCore.Mvc;

namespace FirstApiNet.Controllers
{
    public class UserController : FirstApiNetController
    { 
       [HttpGet]
       [Route("{id}")]
       [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
       [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new User
            {
                Name = "Eduardo",
                Age = 25,
                Id = 1
            };

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
        {
            var response = new ResponseRegisterUserJson
            {
                Id = 5,
                Name = request.Name,
            };

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestUpdateUserProfile request)
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>),StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var response = new List<User>()
            {
               new() { Id = 1, Age = 25, Name = "Eduardo" },
               new() { Id = 2, Age = 25, Name = "Gabriel" },
            };

            var key = GetCustomKey();

            return Ok(response);
        }

        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
        {
            return NoContent();
        }
    }
}
