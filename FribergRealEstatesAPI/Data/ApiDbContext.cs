using FribergRealEstatesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data
{
    //Auth: Hamza
    public class ApiDbContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public ApiDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
