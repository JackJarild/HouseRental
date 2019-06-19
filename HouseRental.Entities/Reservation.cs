using System;

namespace HouseRental.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Email { get; set; }
        public double Price { get; set; }
        public House House { get; set; }
    }
}
