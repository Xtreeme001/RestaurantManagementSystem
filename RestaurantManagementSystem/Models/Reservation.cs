using Microsoft.VisualBasic;

namespace RestaurantManagementSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ReservationNumber { get; set; }
        public string CustomerName { get; set; }
        public int Date {  get; set; }
        public string PartySize { get; set; }
    }
}
