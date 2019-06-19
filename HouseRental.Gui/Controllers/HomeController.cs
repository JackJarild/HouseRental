using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HouseRental.Gui.Models;
using HouseRental.Gui.Services;

namespace HouseRental.Gui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHouseRentalClient _houseRentalClient;

        public HomeController(IHouseRentalClient houseRentalClient)
        {
            _houseRentalClient = houseRentalClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _houseRentalClient.GetHousesAsync();

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
