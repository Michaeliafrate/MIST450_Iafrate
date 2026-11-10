using BooksMVC_MIST450sec01.Models;

namespace BooksMVC_MIST450sec01.Services
{
    public interface INOAAWeatherService
    {
        Task<WeatherData> GetWeatherAsync(string city);
    }
}
