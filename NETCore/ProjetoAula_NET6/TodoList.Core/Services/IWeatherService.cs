using TodoList.Core.DTOs;

namespace TodoList.Core.Services
{
    public interface IWeatherService
    {
        Task<WeatherDTO> ReadWeather();
    }
}
