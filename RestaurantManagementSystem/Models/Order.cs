namespace RestaurantManagementSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string CustomerName { get; set; }
        public string ItemsOrdered { get; set; }
        public string Amount { get; set; }
    }
}
