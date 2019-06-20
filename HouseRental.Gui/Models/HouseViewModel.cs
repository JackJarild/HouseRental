using System;
using System.ComponentModel.DataAnnotations;
using HouseRental.Common;

namespace HouseRental.Gui.Models
{
    public class HouseViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }

        public HouseType HouseType { get; set; }
        public double BaseDayFee { get; set; }
        public string ImageUrl { get; set; }
    }
}
