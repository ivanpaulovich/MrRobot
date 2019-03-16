namespace MrRobot.Infrastructure.EntityFrameworkDataAccess
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using MrRobot.Core.Entities;

    public sealed class MrRobotContext : DbContext
    {
        public MrRobotContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Robot> Robots { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Robot>()
                .ToTable("Robots")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Robot>().Ignore(p => p.CurrentLocation);

            modelBuilder.Entity<Location>()
                .ToTable("Locations")
                .HasKey(u => new 
                { 
                    u.RobotId, 
                    u.X,
                    u.Y 
                });
            ;
        }
    }
}