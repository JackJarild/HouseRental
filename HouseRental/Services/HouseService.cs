using System;
using System.Linq;
using System.Threading.Tasks;
using HouseRental.Common;
using HouseRental.Entities;
using Microsoft.EntityFrameworkCore;
using HouseType = HouseRental.Common.HouseType;

namespace HouseRental.Api.Services
{
    public class HouseService : IHouseService
    {
        private readonly HouseRentalContext _context;

        public HouseService(HouseRentalContext context)
        {
            _context = context;
        }

        public async Task<HouseDto> GetByIdAsync(int id)
        {
            var house = await _context.House.FindAsync(id);

            return new HouseDto
            {
                Id = house.Id,
                HouseType = (HouseType)house.HouseType,
                BaseDayFee = house.BaseDayFee
            };
        }

        public async Task<HouseDto[]> GetAllAsync()
        {
            return await _context.House.Select(h => new HouseDto
            {
                Id = h.Id,
                HouseType = (HouseType)h.HouseType,
                BaseDayFee = h.BaseDayFee
            }).ToArrayAsync();
        }

        public double? CalculatePrice(HouseDto house, DateTime fromDate, DateTime toDate)
        {
            var numberOfDays = (toDate - fromDate).Days;

            double? price = null;
            switch (house.HouseType)
            {
                case HouseType.Apartment:
                    price = house.BaseDayFee * numberOfDays;
                    break;
                case HouseType.Bungalow:
                    price = (house.BaseDayFee * numberOfDays) * 1.5;
                    break;
                default:
                    break;
            }

            return price;
        }
    }
}
