using Microsoft.AspNetCore.Mvc;

namespace API_Mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static User _user = new User(1, "Hamidou.Salim", "Hamidou", "Salim", "Salim.Hamidou@gmail.com", "123");

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_user);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] User updatedUser)
        {
            _user.Identifiant = updatedUser.Identifiant;
            _user.Email = updatedUser.Email;
            _user.Password = updatedUser.Password;
            return Ok(_user);
        }
    }
}