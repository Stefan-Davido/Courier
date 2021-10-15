using DistantPointTest.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DistantPointTest.Data
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Package> Packages{ get; set; }
        public DbSet<Courier> Courier{ get; set; }
        public DbSet<PricePerCourier> PricePerCourier{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ***** Data Seed *****

            #region Admin and Roles

            const string ADMIN_ID = "b4280b6a-0613-4cbd-a9e6-f1701e926e73";
            const string ROLE_ID = ADMIN_ID;
            const string password = "Admin123!";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN"
                }
                //,new IdentityRole
                //{
                //    Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e75",
                //    Name = "guest",
                //    NormalizedName = "GUEST"
                //}
                );

            var hashPassword = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = ADMIN_ID,
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "ballerscoutmk@gmail.com",
                    NormalizedEmail = "BALLERSCOUTMK@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hashPassword.HashPassword(null, password),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "c8554266 -b401-4519-9aeb-a9283053fc58"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                });

            #endregion
            #region Couriers
            //modelBuilder.Entity<Courier>().HasData(
            //    new Courier{ 
            //        CourierId = 1,
            //        CourierName = "ShipFaster",
            //        MaxDimensions = 1700,
            //        MinDimensions = 0,
            //        MinWeight = 10,
            //        MaxWeight = 30,
            //        OrdersMade = 0 
            //    },
            //    new Courier{ 
            //        CourierId = 1,
            //        CourierName = "Cargo4You",
            //        MaxDimensions = 2000,
            //        MinDimensions = 0,
            //        MinWeight = 0,
            //        MaxWeight = 20,
            //        OrdersMade = 0 
            //    },
            //    new Courier{ 
            //        CourierId = 1,
            //        CourierName = "MaltaShip",
            //        MaxDimensions = 10000000000000,
            //        MinDimensions = 500,
            //        MinWeight = 10,
            //        MaxWeight = 10000000000000,
            //        OrdersMade = 0 
            //    }
            //);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
