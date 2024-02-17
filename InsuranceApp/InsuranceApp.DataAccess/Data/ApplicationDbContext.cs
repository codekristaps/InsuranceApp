using InsuranceApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<InsuranceCustomer> InsuranceCustomer { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<InsuranceProduct> InsuranceProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for the identity we need this one piece of line
            base.OnModelCreating(modelBuilder);

            // Configure the column type for the Price property
            modelBuilder.Entity<InsuranceProduct>()
                        .Property(p => p.Price)
                        .HasColumnType("decimal(18,2)"); // Example: Decimal with precision 18 and scale 2

            modelBuilder.Entity<Insurance>().HasData(
                new Insurance
                {
                    InsuranceId = Guid.NewGuid(), // Generate a new GUID for the insurance ID
                    Name = "Life Insurance"
                },
                new Insurance
                {
                    InsuranceId = Guid.NewGuid(),
                    Name = "Health Insurance"
                },
                new Insurance
                {
                    InsuranceId = Guid.NewGuid(),
                    Name = "Car Insurance"
                },
                new Insurance
                {
                    InsuranceId = Guid.NewGuid(),
                    Name = "Home Insurance"
                },
                new Insurance
                {
                    InsuranceId = Guid.NewGuid(),
                    Name = "Travel Insurance"
                }
            );

            
        }
    }
}
