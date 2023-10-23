using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly DataContext _db;

        public ReservationsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllreservations()
        {
            var reservation = _db.Reservations.ToList();
            return Ok(reservation);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllreservations(int id)
        {
            var reservation = _db.Reservations.FirstOrDefault   (x => x.Id == id);
            if(reservation == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(reservation);
        }


    }
}
