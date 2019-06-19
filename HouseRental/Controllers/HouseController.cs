using System.Threading.Tasks;
using HouseRental.Api.Services;
using HouseRental.Common;
using Microsoft.AspNetCore.Mvc;

namespace HouseRental.Api.Controllers
{
    [Route("api/house")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet("get")]
        public async Task<ActionResult<HouseDto>> Get(int id)
        {
            return await _houseService.GetByIdAsync(id);
        }

        [HttpGet("getall")]
        public async Task<ActionResult<HouseDto[]>> GetAll()
        {
            var result = await _houseService.GetAllAsync();
            return result;
        }
    }
}