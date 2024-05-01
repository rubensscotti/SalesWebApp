using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalesWebApp.Data;

namespace SalesWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<SalesWebAppContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SalesWebAppContext") ?? throw new InvalidOperationException("Connection string 'SalesWebAppContext' not found.")));

            // Add services to the container.
            builder.Services.AddScoped<SeendingService>();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Use dependency injection to get SalesWebAppContext and call the SeedingService
                using var scope = app.Services.CreateScope();
                var appContext = scope.ServiceProvider.GetRequiredService<SalesWebAppContext>();
                var seedingService = scope.ServiceProvider.GetRequiredService<SeendingService>();
                seedingService.Seed();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
