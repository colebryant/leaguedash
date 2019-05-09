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
        public DbSet<Position> Position { get; set; }
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
                PositionId = 1, 
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
                PositionId = 2,
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
                PositionId = 5,
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

            ApplicationUser user4 = new ApplicationUser
            {
                FirstName = "Lionel",
                LastName = "Messi",
                PositionId = 5,
                RoleId = 1,
                UserName = "lionel@lionel.com",
                NormalizedUserName = "LIONEL@LIONEL.COM",
                Email = "lionel@lionel.com",
                NormalizedEmail = "LIONEL@LIONEL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash4 = new PasswordHasher<ApplicationUser>();
            user4.PasswordHash = passwordHash4.HashPassword(user4, "IAmPlayer2!");

            ApplicationUser user5 = new ApplicationUser
            {
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                PositionId = 4,
                RoleId = 1,
                UserName = "cristiano@cristiano.com",
                NormalizedUserName = "CRISTIANO@CRISTIANO.COM",
                Email = "cristiano@cristiano.com",
                NormalizedEmail = "CRISTIANO@CRISTIANO.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash5 = new PasswordHasher<ApplicationUser>();
            user5.PasswordHash = passwordHash5.HashPassword(user5, "IAmPlayer3!");

            ApplicationUser user6 = new ApplicationUser
            {
                FirstName = "Sergio",
                LastName = "Ramos",
                PositionId = 3,
                RoleId = 1,
                UserName = "sergio@sergio.com",
                NormalizedUserName = "SERGIO@SERGIO.COM",
                Email = "sergio@sergio.com",
                NormalizedEmail = "SERGIO@SERGIO.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash6 = new PasswordHasher<ApplicationUser>();
            user6.PasswordHash = passwordHash6.HashPassword(user6, "IAmPlayer4!");

            ApplicationUser user7 = new ApplicationUser
            {
                FirstName = "Thomas",
                LastName = "Muller",
                PositionId = 4,
                RoleId = 1,
                UserName = "thomas@thomas.com",
                NormalizedUserName = "THOMAS@THOMAS.COM",
                Email = "thomas@thomas.com",
                NormalizedEmail = "THOMAS@THOMAS.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash7 = new PasswordHasher<ApplicationUser>();
            user7.PasswordHash = passwordHash7.HashPassword(user7, "IAmPlayer5!");

            ApplicationUser user8 = new ApplicationUser
            {
                FirstName = "Bastion",
                LastName = "Schweinsteiger",
                PositionId = 4,
                RoleId = 1,
                UserName = "bastion@bastion.com",
                NormalizedUserName = "BASTION@BASTION.COM",
                Email = "bastion@bastion.com",
                NormalizedEmail = "BASTION@BASTION.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash8 = new PasswordHasher<ApplicationUser>();
            user8.PasswordHash = passwordHash8.HashPassword(user8, "IAmPlayer6!");

            ApplicationUser user9 = new ApplicationUser
            {
                FirstName = "Billy",
                LastName = "Captains",
                PositionId = 2,
                RoleId = 2,
                UserName = "billy@billy.com",
                NormalizedUserName = "BILLY@BILLY.COM",
                Email = "billy@billy.com",
                NormalizedEmail = "BILLY@BILLY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash9 = new PasswordHasher<ApplicationUser>();
            user9.PasswordHash = passwordHash9.HashPassword(user9, "IAmCaptain2!");

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2, user3, user4, user5, user6, user7, user8, user9);

            modelBuilder.Entity<Position>().HasData(
                new Position()
                {
                    Id = 1,
                    Name = "No Preference"
                },
                new Position()
                {
                    Id = 2,
                    Name = "Goalkeeper"
                },
                new Position()
                {
                    Id = 3,
                    Name = "Defender"
                },
                new Position()
                {
                    Id = 4,
                    Name = "Midfielder"
                },
                new Position()
                {
                    Id = 5,
                    Name = "Forward"
                }
            );

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
