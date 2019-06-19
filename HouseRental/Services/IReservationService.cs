using System.Threading.Tasks;
using HouseRental.Common;

namespace HouseRental.Api.Services
{
    public interface IReservationService
    {
        Task<ReservationResponse> ReserveHouseAsync(ReservationRequest request);
    }
}
