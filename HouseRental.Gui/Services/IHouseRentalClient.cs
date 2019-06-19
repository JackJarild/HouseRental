using System.Collections.Generic;
using System.Threading.Tasks;
using HouseRental.Common;

namespace HouseRental.Gui.Services
{
    public interface IHouseRentalClient
    {
        Task<IEnumerable<HouseDto>> GetHousesAsync();
        Task<HouseDto> GetHouseAsync(int id);
        Task<ReservationResponse> PostReservationAsync(ReservationRequest request);
    }
}
