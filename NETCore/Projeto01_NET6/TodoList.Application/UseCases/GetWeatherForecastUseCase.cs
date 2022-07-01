using TodoList.Core.DTOs;
using TodoList.Core.Services;

namespace TodoList.Application.UseCases
{
    public class GetWeatherForecastUseCase : IUseCaseAsync<string, WeatherDTO>
    {
        public readonly IWeatherService _weatherService;

        public GetWeatherForecastUseCase(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<WeatherDTO> ExecuteAsync(string request)
        {
            return await _weatherService.ReadWeather();
        }
    }
}
