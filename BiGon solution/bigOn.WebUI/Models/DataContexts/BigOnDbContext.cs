using bigOn.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace bigOn.WebUI.Models.DataContexts
{
    public class BigOnDbContext:DbContext
    {
        public BigOnDbContext(DbContextOptions options)
            : base(options)
        {

        }
      public DbSet<Category> Categories { get; set; }
      public DbSet<ContactPost> ContactPosts { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<ProductColor> ProductColors { get; set; }
      public DbSet<ProductSize> ProductSize { get; set; }
      public DbSet<ProductMaterial> ProductMaterials { get; set; }
      public DbSet<Brand> Brands { get; set; }
      public DbSet<ProductType> ProductTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
