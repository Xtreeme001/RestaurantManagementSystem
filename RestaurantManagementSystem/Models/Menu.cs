namespace RestaurantManagementSystem.Models
{
    public class Menu
    {
        public int  Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }

    }
}
