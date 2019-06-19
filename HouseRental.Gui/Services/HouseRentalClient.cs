using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HouseRental.Common;
using Newtonsoft.Json;

namespace HouseRental.Gui.Services
{
    public class HouseRentalClient : IHouseRentalClient
    {
        private readonly HttpClient _httpClient;

        public HouseRentalClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<HouseDto>> GetHousesAsync()
        {
            var result = await _httpClient.GetStringAsync("/api/house/getall").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<HouseDto>>(result);
        }

        public async Task<HouseDto> GetHouseAsync(int id)
        {
            var result = await _httpClient.GetStringAsync($"/api/house/get?id={id}").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<HouseDto>(result);
        }

        public async Task<ReservationResponse> PostReservationAsync(ReservationRequest request)
        {
            var obj = JsonConvert.SerializeObject(request);
            var stringContent = new StringContent(obj, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/reservation/house", stringContent);
            var content = await response.Content.ReadAsStringAsync();

            var reservationResponse = JsonConvert.DeserializeObject<ReservationResponse>(content);
            return reservationResponse;
        }
    }
}
