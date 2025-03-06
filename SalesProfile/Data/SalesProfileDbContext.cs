using Microsoft.EntityFrameworkCore;
using SalesProfile.Models;

namespace SalesProfile.Data
{
    public class SalesProfileDbContext : DbContext
    {
        public SalesProfileDbContext(DbContextOptions<SalesProfileDbContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasKey(p => p.Id);
            modelBuilder.Entity<Certificate>().HasKey(c => c.Id);
            modelBuilder.Entity<Project>().HasKey(p => p.Id);
            modelBuilder.Entity<Experience>().HasKey(e => e.Id);
        }
    }
}
