using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data
{
    //Auth: Hamza
    public class ApiDbContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Residence> Residences { get; set; }
        public DbSet<Commun> Communs { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

        public ApiDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Residence>()
                .HasOne(r => r.Realtor)
                .WithMany(re => re.ActiveResidences)
                .HasForeignKey(r => r.RealtorId);
        }
    }
}
