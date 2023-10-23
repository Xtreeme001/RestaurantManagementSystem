using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly DataContext _db;

        public OrdersController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllorders()
        {
            var order = _db.Orders.ToList();
            return Ok(order);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllorders(int id)
        {
            var order = _db.Orders.FirstOrDefault(o => o.Id == id);
            if(order == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(order);
        }
    }
}
