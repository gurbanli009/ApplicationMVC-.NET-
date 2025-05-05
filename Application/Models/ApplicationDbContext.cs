using Microsoft.EntityFrameworkCore;

namespace Application.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}