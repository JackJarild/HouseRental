using System;
using System.Threading.Tasks;
using HouseRental.Common;

namespace HouseRental.Api.Services
{
    public interface IHouseService
    {
        Task<HouseDto> GetByIdAsync(int id);
        Task<HouseDto[]> GetAllAsync();
        double? CalculatePrice(HouseDto house, DateTime fromDate, DateTime toDate);
    }
}
