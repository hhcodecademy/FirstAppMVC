using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class CustomDbContext:DbContext
    {
        public CustomDbContext(DbContextOptions<CustomDbContext> options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
