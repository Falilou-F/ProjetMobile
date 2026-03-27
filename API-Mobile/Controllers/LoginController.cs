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
            if (pseudo == "Salim" && pass == "123")
            {
                return true;
            }

            return false;
        }
    }
}