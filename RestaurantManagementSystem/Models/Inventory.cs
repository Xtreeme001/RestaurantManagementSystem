namespace RestaurantManagementSystem.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string SupplierInfo { get; set; }
        public string ExpiryDate { get; set; }
    }
}
