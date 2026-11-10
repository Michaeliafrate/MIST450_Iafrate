using BooksMVC_MIST450sec01.Data;
using BooksMVC_MIST450sec01.Services;
using Microsoft.EntityFrameworkCore;

namespace BooksMVC_MIST450sec01;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

          var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

      builder.Services.AddDbContext<BooksDbContext>(options => options.UseSqlServer(connectionString));

        //weather service registration
        builder.Services.AddHttpClient<INOAAWeatherService, NOAAWeatherService>();

        //register the book recommendation service
        builder.Services.AddScoped<IBookRecommendationService, BookRecommendationService>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();

        app.Run();
    }
}
