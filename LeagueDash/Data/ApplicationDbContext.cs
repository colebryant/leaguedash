using System;
using LeagueDash.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeagueDash.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Game>()
                .Property(b => b.GameTime)
                .HasDefaultValueSql("GETDATE()");

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Rodger",
                LastName = "Commish",
                RoleId = 3,
                UserName = "rodger@rodger.com",
                NormalizedUserName = "RODGER@RODGER.COM",
                Email = "rodger@rodger.com",
                NormalizedEmail = "RODGER@RODGER.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "IAmCommish1!");

            ApplicationUser user2 = new ApplicationUser
            {
                FirstName = "Steve",
                LastName = "Captains",
                RoleId = 2,
                UserName = "steve@steve.com",
                NormalizedUserName = "STEVE@STEVE.COM",
                Email = "steve@steve.com",
                NormalizedEmail = "STEVE@STEVE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash2 = new PasswordHasher<ApplicationUser>();
            user2.PasswordHash = passwordHash2.HashPassword(user2, "IAmCaptain1!");

            ApplicationUser user3 = new ApplicationUser
            {
                FirstName = "Julia",
                LastName = "Players",
                RoleId = 1,
                UserName = "julia@julia.com",
                NormalizedUserName = "JULIA@JULIA.COM",
                Email = "julia@julia.com",
                NormalizedEmail = "JULIA@JULIA.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash3 = new PasswordHasher<ApplicationUser>();
            user3.PasswordHash = passwordHash3.HashPassword(user3, "IAmPlayer1!");

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2, user3);

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = 1,
                    Name = "Player"
                },
                new Role()
                {
                    Id = 2,
                    Name = "Captain"
                },
                new Role()
                {
                    Id = 3,
                    Name = "Commissioner"
                }
            );
        }
    }
}
