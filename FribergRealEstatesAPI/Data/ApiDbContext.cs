using FribergRealEstatesAPI.Constants;
using FribergRealEstatesAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
                Id = "",
            },
                new IdentityRole
                {
                    Name = ApiRoles.Admin,
                    NormalizedName = ApiRoles.Admin,
                    Id = "",
                },
                new IdentityRole
                {
                    Name = ApiRoles.SuperAdmin,
                    NormalizedName = ApiRoles.SuperAdmin,
                    Id = "",
                },
                new IdentityRole
                {
                    Name = ApiRoles.Realtor,
                    NormalizedName = ApiRoles.Realtor,
                    Id = "",
                });

            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "",
                    Email = "admin@api.com",
                    NormalizedEmail = "ADMIN@API.COM",
                    UserName = "admin@api.com",
                    NormalizedUserName = "ADMIN@API.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123!"),
                    EmailConfirmed = true
                });
        }
    }
}
