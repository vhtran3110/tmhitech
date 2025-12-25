using System.Data.Entity;
using TMHitech.Models;

namespace TMHitech.MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=TMHitechDb;Integrated Security=True;MultipleActiveResultSets=True")
        {
            Database.SetInitializer<AppDbContext>(null);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}