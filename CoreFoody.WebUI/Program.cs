using CoreFoody.BusinessLayer.Abstract;
using CoreFoody.BusinessLayer.Concrete;
using CoreFoody.DataAccessLayer.Abstract;
using CoreFoody.DataAccessLayer.Context;
using CoreFoody.DataAccessLayer.EntityFramework;
using System.Reflection;

namespace CoreFoody.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FoodyDbContext>();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();
            builder.Services.AddScoped<IProductDal, EfProductDal>();
            builder.Services.AddScoped<IProductService, ProductManager>();
            builder.Services.AddScoped<ISliderDal, EfSliderDal>();
            builder.Services.AddScoped<ISliderService, SliderManager>();

            WebApplication app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Categories}/{action=Index}/{id?}");

            app.Run();
        }
    }
}