using Microsoft.AspNetCore.Mvc;

namespace API_Mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet("{pseudo}/{pass}")]
        public bool Get(string pseudo, string pass)
        {
            var user = UserController.GetUser();

            if (pseudo == user.Identifiant && pass == user.Password)
            {
                return true;
            }

            return false;
        }
    }
}