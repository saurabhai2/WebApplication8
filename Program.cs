using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebApplication8.Database;
using WebApplication8;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<AnantyaDbContext>();

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(120); // Set session timeout to 120 minutes (adjust as needed)
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
        });

        
        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddRazorPages();

        var app = builder.Build();

        
        app.UseSession();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        using (var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
        {
            var context = scope.ServiceProvider.GetService<AnantyaDbContext>();
            DatabaseSeeder.SeedData(context);
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();


        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}");

        app.MapRazorPages();

        app.Run();
    }    
}
