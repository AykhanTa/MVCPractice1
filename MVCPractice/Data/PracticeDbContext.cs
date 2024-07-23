using Microsoft.EntityFrameworkCore;
using MVCPractice.Models;

namespace MVCPractice.Data
{
    public class PracticeDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public PracticeDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
