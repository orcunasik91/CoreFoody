using CoreFoody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreFoody.DataAccessLayer.Context;
public class FoodyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CoreFoodyDb;User ID=sa;Password=Password1;");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<AboutItem> AboutItems { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Review> Reviews { get; set; }
}