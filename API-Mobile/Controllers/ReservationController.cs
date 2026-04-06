using Microsoft.AspNetCore.Mvc;

namespace API_Mobile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private static List<Reservation> reservations = new List<Reservation>
        {
            new Reservation(1, 1, "Messine → Palerme",  "2026-01-10", "2026-02-17", "Passée"),
            new Reservation(2, 1, "Palerme → Trapani","2026-05-20", "2026-05-27", "En attente"),
            new Reservation(3, 1, "Trapani → Messine",      "2026-06-15", "2026-06-22", "Confirmée"),
        };
            
        [HttpGet("client/{idClient}")]
        public IActionResult GetByClient(int idClient)
        {
            var result = reservations.Where(r => r.IdClient == idClient).ToList();
            return Ok(result);
        }
    }
}