using FirstMyProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<CakeShopDbContext>(option =>
            {
                option.UseSqlServer(
                    builder.Configuration["ConnectionStrings:CakeShopDbContextConnection"]);
            });

            var app = builder.Build();

            app.UseStaticFiles();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
