using System;
using System.Threading.Tasks;
using HouseRental.Common;
using HouseRental.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HouseRental.Api.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ILogger<ReservationService> _logger;
        private readonly HouseRentalContext _context;
        private readonly IHouseService _houseService;

        public ReservationService(ILogger<ReservationService> logger, HouseRentalContext context, IHouseService houseService)
        {
            _logger = logger;
            _context = context;
            _houseService = houseService;
        }


        public async Task<ReservationResponse> ReserveHouseAsync(ReservationRequest request)
        {
            //  CheckAvailability(request);

            try
            {
                var house = await _houseService.GetByIdAsync(request.HouseId);
                if(house == null)
                    throw new Exception("House was not found");

                var price = _houseService.CalculatePrice(house, request.FromDate, request.ToDate);
                if (price == null)
                    throw new Exception("Could not calculate price");

                var reservation = new Reservation
                {
                    HouseId = request.HouseId,
                    FromDate = request.FromDate,
                    ToDate = request.ToDate,
                    Email = request.Email,
                    Price = price.Value
                };

                await _context.Reservation.AddAsync(reservation);
                await _context.SaveChangesAsync();

                return new ReservationResponse
                {
                    Price = price.Value,
                    ReservationNumber = reservation.Id
                };
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("ReserveHouse", ex);
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError("ReserveHouse", ex);
                throw;
            }
        }
    }
}
