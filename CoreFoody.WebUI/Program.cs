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
            builder.Services.AddScoped<IAboutDal, EfAboutDal>();
            builder.Services.AddScoped<IAboutService, AboutManager>(); 
            builder.Services.AddScoped<IAboutItemDal, EfAboutItemDal>();
            builder.Services.AddScoped<IAboutItemService, AboutItemManager>();

            WebApplication app = builder.Build();

            app.UseStatusCodePages(async page =>
            {
                if(page.HttpContext.Response.StatusCode == 404)
                {
                    page.HttpContext.Response.Redirect("/ErrorPages/ErrorPage404");
                }
            });
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/ErrorPages/ErrorPage404");
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