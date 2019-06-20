namespace HouseRental.Common
{
    public class HouseDto
    {
        public int Id { get; set; }
        public HouseType HouseType { get; set; }
        public double BaseDayFee { get; set; }
        public string ImageUrl { get; set; }
    }
}
