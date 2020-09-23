using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantTracker.Models;

namespace RestaurantTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Table> Table { get; set; }
        public DbSet<Waiter> Waiter { get; set; }

        public DbSet<ApplicationUser> User { get; set; }

        public DbSet<Restaurant> Restaurant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Restaurant>()
               .HasMany(r => r.Waiters)
               .WithOne(w => w.Restaurant)
               .OnDelete(DeleteBehavior.Restrict);

        }

        }
}
