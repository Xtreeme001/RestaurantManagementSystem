using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly DataContext _db;

        public StaffsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllstaffs()
        {
            var staff = _db.Staffs.ToList();
            return Ok(staff);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllstaffs(int id)
        {
            var staff = _db.Staffs.FirstOrDefault(x => x.Id == id);
            if(staff == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(staff);
        }
    }
}
