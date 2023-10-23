using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly DataContext _db;

        public MenusController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllmenus()
        {
            var menu = _db.Menus.ToList();
            return Ok(menu);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllmenus(int id)
        {
            var menu = _db.Menus.FirstOrDefault(x => x.Id == id);
            if(menu == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(menu);
        }
    }
}
