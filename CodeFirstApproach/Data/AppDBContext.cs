using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // Connection String

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
