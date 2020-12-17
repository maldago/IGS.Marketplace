using IntelligentGrowthSolutions.Marketplace.Data.Configurations;
using IntelligentGrowthSolutions.Marketplace.Models;
using Microsoft.EntityFrameworkCore;

namespace IntelligentGrowthSolutions.Marketplace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            // Get Configurations Defined in this assembly
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<Product> Products { get; set; }
    }
}