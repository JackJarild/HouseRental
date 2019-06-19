using System.Collections;
using System.Collections.Generic;

namespace HouseRental.Entities
{
    public class House
    {
        public int Id { get; set; }
        public HouseType HouseType { get; set; }
        public double BaseDayFee { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }

    public enum HouseType
    {
        None = 0,
        Apartment = 2,
        Bungalow = 4
    }
}
