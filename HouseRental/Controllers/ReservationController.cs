using System;
using System.Threading.Tasks;
using HouseRental.Api.Services;
using HouseRental.Common;
using Microsoft.AspNetCore.Mvc;

namespace HouseRental.Api.Controllers
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost("house")]
        public async Task<ActionResult<ReservationResponse>> ReserveHouse(ReservationRequest request)
        {
            try
            {
                var response = await _reservationService.ReserveHouseAsync(request);
                return response;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}