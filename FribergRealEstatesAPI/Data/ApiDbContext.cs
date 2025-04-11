﻿using FribergRealEstatesAPI.Models;
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

            //Bostad till mäklare
            modelBuilder.Entity<Residence>()
                .HasOne(r => r.Realtor)
                .WithMany(re => re.ActiveResidences)
                .HasForeignKey(r => r.RealtorId)
                .OnDelete(DeleteBehavior.Restrict);

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
        }
    }
}
