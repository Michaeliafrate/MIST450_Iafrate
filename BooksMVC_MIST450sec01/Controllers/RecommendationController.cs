using BooksMVC_MIST450sec01.Data;
using BooksMVC_MIST450sec01.Models;
using BooksMVC_MIST450sec01.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksMVC_MIST450sec01.Controllers
{
    public class RecommendationController : Controller
    {
        private readonly BooksDbContext _context;
        private readonly INOAAWeatherService _weatherService;
        private readonly IBookRecommendationService _bookService;

        public RecommendationController(
            BooksDbContext context,
            INOAAWeatherService weatherService,
            IBookRecommendationService bookService)
        {
            _context = context;
            _weatherService = weatherService;
            _bookService = bookService;
        }

        // GET: Recommendation/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: Recommendation/Results
        [HttpPost]
        public async Task<IActionResult> Results(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                ModelState.AddModelError(
                    "city",
                    "Please enter a city.");

                return View("Index");
            }

            try
            {
                // Step 1: Retrieve weather information
                WeatherData weather =
                    await _weatherService.GetWeatherAsync(city);

                // Step 2: Determine recommended genres
                List<string> genres =
                    _bookService.GetRecommendedGenres(weather);

                // Step 3: Retrieve matching books from the database
                List<Book> books = await _context.Books
                    .Where(b => genres.Contains(b.Genre))
                    .ToListAsync();

                // Step 4: Build the ViewModel
                var viewModel = new RecommendationViewModel
                {
                    Weather = weather,
                    SelectedCity = city,
                    RecommendedGenres = genres,
                    RecommendedBooks = books
                };

                // Step 5: Display results
                return View(viewModel);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(
                    "city",
                    $"Unable to retrieve recommendations: {ex.Message}");

                return View("Index");
            }
        }
    }
}
