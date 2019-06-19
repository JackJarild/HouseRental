using System.Threading.Tasks;
using HouseRental.Common;
using HouseRental.Gui.Services;
using Microsoft.AspNetCore.Mvc;

namespace HouseRental.Gui.Controllers
{
    public class HouseController : Controller
    {
        private readonly IHouseRentalClient _houseRentalClient;

        public HouseController(IHouseRentalClient houseRentalClient)
        {
            _houseRentalClient = houseRentalClient;
        }

        public async Task<IActionResult> Details(int id)
        {
            var result = await _houseRentalClient.GetHouseAsync(id);
            return View(result);
        }

        public IActionResult Reserve(int id)
        {
            var model = new ReservationRequest {HouseId = id};
            return View(model);
        }

        public IActionResult CheckOut(ReservationResponse model)
        {
            return View(model);
        }

        public async Task<IActionResult> ReserveHouse(ReservationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var response = await _houseRentalClient.PostReservationAsync(request);
            return RedirectToAction("CheckOut", response);
        }
    }
}