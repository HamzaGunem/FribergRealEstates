using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FribergRealEstatesAPI.Data
{
    //Auth: Hamza
    // Minor addition: Robert
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Commun> Communs { get; set; }
        public DbSet<Realtor> Realtors { get; set; }
        public DbSet<Advert> Adverts { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Advert>()
                .HasOne(a => a.Residence)
                .WithOne(r => r.Advert)
                .HasForeignKey<Advert>(a => a.ResidenceId);

            modelBuilder.Entity<Advert>()
                .HasOne(a => a.Realtor)
                .WithMany(r => r.ActiveAdverts)
                .HasForeignKey(a => a.RealtorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Residence>()
                .HasOne(r => r.Address)
                .WithOne(a => a.Residence)
                .HasForeignKey<Residence>(r => r.AddressId);

            //Bostad till kommun
            modelBuilder.Entity<Address>()
                .HasOne(a => a.Commun)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CommunId)
                .OnDelete(DeleteBehavior.Restrict);

            //Mäklare till Byrå
            modelBuilder.Entity<Realtor>()
                .HasOne(r => r.Agency)
                .WithMany(a => a.Realtors)
                .HasForeignKey(r => r.AgencyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = ApiRoles.User,
                    NormalizedName = ApiRoles.User,
                    Id = "8dbf5e67-e5dc-4fa5-a41b-3be035b70d2c"
                },
                new IdentityRole
                {
                    Name = ApiRoles.Admin,
                    NormalizedName = ApiRoles.Admin,
                    Id = "896dfa0e-3035-4dd1-9f6b-061896a10140"
                },
                new IdentityRole
                {
                    Name = ApiRoles.SuperAdmin,
                    NormalizedName = ApiRoles.SuperAdmin,
                    Id = "65161035-f041-4293-aabf-557b9bafc89c"
                },
                new IdentityRole
                {
                    Name = ApiRoles.Realtor,
                    NormalizedName = ApiRoles.Realtor,
                    Id = "d8a759ea-8753-4e78-b8f0-1130af4c0691"
                }
                );
            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "f866bbe6-a717-4958-9134-9f30a8113360",
                    Email = "admin@api.com",
                    NormalizedEmail = "ADMIN@API.COM",
                    UserName = "admin@api.com",
                    NormalizedUserName = "ADMIN@API.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true,
                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "896dfa0e-3035-4dd1-9f6b-061896a10140",
                    UserId = "f866bbe6-a717-4958-9134-9f30a8113360"
                });



        }
    }
}
