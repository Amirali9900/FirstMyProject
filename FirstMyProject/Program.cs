using FirstMyProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace FirstMyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<ICakeRepository, CakeRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();

            builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            builder.Services.AddSession();
            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllersWithViews().AddJsonOptions(option =>
            {
                option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

            builder.Services.AddDbContext<CakeShopDbContext>(option =>
            {
                option.UseSqlServer(
                    builder.Configuration["ConnectionStrings:CakeShopDbContextConnection"]);
            });
            var app = builder.Build();

            app.UseStaticFiles();
            app.UseSession();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.MapDefaultControllerRoute();
            app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");

            DbInitializer.Seed(app);
            app.Run();
        }
    }
}
