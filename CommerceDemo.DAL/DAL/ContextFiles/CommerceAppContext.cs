using DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.ContextFiles
{
    public class CommerceAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BURCUALA\EMIRHAZIR; Initial Catalog=CommerceAppDB; uid=sa; pwd=123;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(x => new { x.ProductID, x.CategoryID });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(pc => pc.Categories)
                .HasForeignKey(x => x.ProductID);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Category)
                .WithMany(pc => pc.Products)
                .HasForeignKey(x => x.CategoryID);
        }
    }
}
