using Microsoft.EntityFrameworkCore;

namespace RestaurantManagementSystem.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Inventory> Inventories { get; set; }


    }
}
