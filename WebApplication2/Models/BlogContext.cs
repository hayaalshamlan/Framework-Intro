using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data source=blog.db");
                //base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 123, Name = "haya", url = "ggg" },
                new Blog { Id = 345, Name = "ahmad", url = "ffff"}
                );
        }
    }
}
