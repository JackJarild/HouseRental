using System.Threading.Tasks;
using HouseRental.Common;
using HouseRental.Gui.Models;
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
            var vm = new HouseViewModel
            {
                Id = result.Id,
                ImageUrl = result.ImageUrl,
                HouseType = result.HouseType,
                BaseDayFee = result.BaseDayFee
            };
            return View(vm);
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