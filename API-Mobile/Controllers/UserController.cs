using Microsoft.AspNetCore.Mvc;

namespace API_Mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public static User user = new User(1, "Hamidou.Salim", "Hamidou", "Salim", "Salim.Hamidou@gmail.com", "123");

        // Méthode ajoutée pour que LoginController puisse y accéder
        public static User GetUser() => user;

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(user);
        }

        [HttpPost("Update")]
        public IActionResult Update([FromBody] User updatedUser)
        {
            user.Identifiant = updatedUser.Identifiant;
            user.Email = updatedUser.Email;
            user.Password = updatedUser.Password;
            return Ok(user);
        }
    }
}