using Newtonsoft.Json;
using TodoList.Core.DTOs;
using TodoList.Core.Services;

namespace TodoList.Infra.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherDTO> ReadWeather()
        {
            using var httpClient = new HttpClient();
            var result = await httpClient
                .GetAsync($"https://api.openweathermap.org/data/2.5/weather?lat=-22.90&lon=-47.06&appid=b39500322b7393a891bdb12d72a35911");

            var response = new WeatherDTO();
            if (result.IsSuccessStatusCode)
            {
                var responseString = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<WeatherDTO>(responseString);
            }

            return response;
        }
    }
}
