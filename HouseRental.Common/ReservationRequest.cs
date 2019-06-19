using System;

namespace HouseRental.Common
{
    public class ReservationRequest
    {
        public int HouseId { get; set; }
        public string Email { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
