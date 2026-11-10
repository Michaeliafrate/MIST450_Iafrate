using BooksMVC_MIST450sec01.Models;

namespace BooksMVC_MIST450sec01.Services
{
    public interface IBookRecommendationService
    {
        List<string> GetRecommendedGenres(WeatherData weather);
    }
}
