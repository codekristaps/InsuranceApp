using InsuranceApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext() : base()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<InsuranceCustomer> InsuranceCustomer { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<InsuranceProduct> InsuranceProducts { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for the identity we need this one piece of line
            base.OnModelCreating(modelBuilder);

            // Configure the column type for the Price property
            modelBuilder.Entity<InsuranceProduct>()
                        .Property(p => p.Price)
                        .HasColumnType("decimal(18,2)"); // Example: Decimal with precision 18 and scale 2

            modelBuilder.Entity<Cart>().HasNoKey();

            // Entity<Order>() returns an object that can be used to configure the Order entity.
            modelBuilder.Entity<Order>()
                        .Property(o => o.Status) // Property() returns an object that can be used to configure the Status property.
                        .HasConversion<string>(); // HasConversion() returns an object that can be used to configure the conversion for the Status property.

            modelBuilder.Entity<Insurance>().HasData(
                new Insurance
                {
                    InsuranceId = new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"),
                    Name = "Life Insurance"
                },
                new Insurance
                {
                    InsuranceId = new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"),
                    Name = "Health Insurance"
                },
                new Insurance
                {
                    InsuranceId = new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"),
                    Name = "Car Insurance"
                },
                new Insurance
                {
                    InsuranceId = new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"),
                    Name = "Home Insurance"
                },
                new Insurance
                {
                    InsuranceId = new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"),
                    Name = "Travel Insurance"
                }
            );

            modelBuilder.Entity<InsuranceProduct>().HasData(
                new InsuranceProduct
                {
                    InsuranceProductId = new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"),
                    Name = "Life Insurance - Basic",
                    Description = "Basic coverage for life insurance.",
                    Price = 1000,
                    Discount = 10,
                    InsuranceId = new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"),
                    ImageUrl = "https://images.pexels.com/photos/35160/pexels-photo.jpg?auto=compress&cs=tinysrgb&w=600"
                },
                new InsuranceProduct
                {
                    InsuranceProductId = new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"),
                    Name = "Health Insurance - Premium",
                    Description = "Premium coverage for health insurance.",
                    Price = 2000,
                    Discount = 15,
                    InsuranceId = new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"),
                    ImageUrl = "https://images.pexels.com/photos/1346347/pexels-photo-1346347.jpeg?auto=compress&cs=tinysrgb&w=600"
                },
                new InsuranceProduct
                {
                    InsuranceProductId = new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"),
                    Name = "Car Insurance - Full Coverage",
                    Description = "Full coverage for car insurance.",
                    Price = 1500,
                    Discount = 20,
                    InsuranceId = new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"),
                    ImageUrl = "https://images.pexels.com/photos/2262628/pexels-photo-2262628.jpeg?auto=compress&cs=tinysrgb&w=600"
                },
                new InsuranceProduct
                {
                    InsuranceProductId = new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"),
                    Name = "Home Insurance - Comprehensive",
                    Description = "Comprehensive coverage for home insurance.",
                    Price = 1200,
                    Discount = 10,
                    InsuranceId = new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"),
                    ImageUrl = "https://images.pexels.com/photos/9646747/pexels-photo-9646747.jpeg?auto=compress&cs=tinysrgb&w=600"
                },
                new InsuranceProduct
                {
                    InsuranceProductId = new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"),
                    Name = "Travel Insurance - Global",
                    Description = "Global coverage for travel insurance.",
                    Price = 800,
                    Discount = 15,
                    InsuranceId = new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"),
                    ImageUrl = "https://images.pexels.com/photos/1076240/pexels-photo-1076240.jpeg?auto=compress&cs=tinysrgb&w=600"
                }
            );
        }
    }
}
