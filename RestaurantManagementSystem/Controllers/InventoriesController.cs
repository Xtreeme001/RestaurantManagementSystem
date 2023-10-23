using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly DataContext _db;

        public InventoriesController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllinventories()
        {
            var inventory = _db.Inventories.ToList();
            return Ok(inventory);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllinventories(int id)
        {
            var inventory = _db.Inventories.FirstOrDefault(x => x.Id == id);
            if (inventory == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(inventory);
        }
    }
}
