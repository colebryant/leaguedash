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
                FirstName = "Will",
                LastName = "Captains",
                TeamId = 1,
                PositionId = 2,
                RoleId = 2,
                UserName = "will@will.com",
                NormalizedUserName = "WILL@WILL.COM",
                Email = "will@will.com",
                NormalizedEmail = "WILL@WILL.COM",
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
                TeamId = 2,
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

            ApplicationUser user10 = new ApplicationUser
            {
                FirstName = "Jack",
                LastName = "Sparrow",
                TeamId = 3,
                PositionId = 5,
                RoleId = 2,
                UserName = "jack@jack.com",
                NormalizedUserName = "JACK@JACK.COM",
                Email = "jack@jack.com",
                NormalizedEmail = "JACK@JACK.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash10 = new PasswordHasher<ApplicationUser>();
            user10.PasswordHash = passwordHash10.HashPassword(user10, "IAmCaptain3!");

            ApplicationUser user11 = new ApplicationUser
            {
                FirstName = "Steve",
                LastName = "Rodgers",
                TeamId = 4,
                PositionId = 4,
                RoleId = 2,
                UserName = "steve@steve.com",
                NormalizedUserName = "STEVE@STEVE.COM",
                Email = "steve@steve.com",
                NormalizedEmail = "STEVE@STEVE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash11 = new PasswordHasher<ApplicationUser>();
            user11.PasswordHash = passwordHash11.HashPassword(user11, "IAmCaptain4!");

            ApplicationUser user12 = new ApplicationUser
            {
                FirstName = "Carol",
                LastName = "Danvers",
                TeamId = 5,
                PositionId = 5,
                RoleId = 2,
                UserName = "carol@carol.com",
                NormalizedUserName = "CAROL@CAROL.COM",
                Email = "carol@carol.com",
                NormalizedEmail = "CAROL@CAROL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash12 = new PasswordHasher<ApplicationUser>();
            user12.PasswordHash = passwordHash12.HashPassword(user12, "IAmCaptain5!");

            ApplicationUser user13 = new ApplicationUser
            {
                FirstName = "John",
                LastName = "Miller",
                TeamId = 6,
                PositionId = 3,
                RoleId = 2,
                UserName = "john@john.com",
                NormalizedUserName = "JOHN@JOHN.COM",
                Email = "john@john.com",
                NormalizedEmail = "JOHN@JOHN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash13 = new PasswordHasher<ApplicationUser>();
            user13.PasswordHash = passwordHash13.HashPassword(user13, "IAmCaptain6!");

            ApplicationUser user14 = new ApplicationUser
            {
                FirstName = "James",
                LastName = "Kirk",
                TeamId = 7,
                PositionId = 3,
                RoleId = 2,
                UserName = "james@james.com",
                NormalizedUserName = "JAMES@JAMES.COM",
                Email = "james@james.com",
                NormalizedEmail = "JAMES@JAMES.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash14 = new PasswordHasher<ApplicationUser>();
            user14.PasswordHash = passwordHash14.HashPassword(user14, "IAmCaptain7!");

            ApplicationUser user15 = new ApplicationUser
            {
                FirstName = "Marko",
                LastName = "Ramius",
                TeamId = 8,
                PositionId = 2,
                RoleId = 2,
                UserName = "marko@marko.com",
                NormalizedUserName = "MARKO@MARKO.COM",
                Email = "marko@marko.com",
                NormalizedEmail = "MARKO@MARKO.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash15 = new PasswordHasher<ApplicationUser>();
            user15.PasswordHash = passwordHash15.HashPassword(user15, "IAmCaptain8!");

            ApplicationUser user16 = new ApplicationUser
            {
                FirstName = "Terry",
                LastName = "Captains",
                TeamId = 9,
                PositionId = 1,
                RoleId = 2,
                UserName = "terry@terry.com",
                NormalizedUserName = "TERRY@TERYY.COM",
                Email = "terry@teryy.com",
                NormalizedEmail = "TERRY@TERRY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash16 = new PasswordHasher<ApplicationUser>();
            user16.PasswordHash = passwordHash16.HashPassword(user16, "IAmCaptain9!");

            ApplicationUser user17 = new ApplicationUser
            {
                FirstName = "Juan",
                LastName = "Captains",
                TeamId = 10,
                PositionId = 1,
                RoleId = 2,
                UserName = "juan@juan.com",
                NormalizedUserName = "JUAN@JUAN.COM",
                Email = "juan@juan.com",
                NormalizedEmail = "JUAN@JUAN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash17 = new PasswordHasher<ApplicationUser>();
            user17.PasswordHash = passwordHash17.HashPassword(user16, "IAmCaptain10!");

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2, user3, user4, user5, user6, user7, user8, user9
                user10, user11, user12, user13, user14, user15, user16);

            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    Id = 1,
                    Name = "Nashville SC",
                    CaptainId = user2.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 2,
                    Name = "Junior Wombats",
                    CaptainId = user9.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 3,
                    Name = "Salty Pirates",
                    CaptainId = user10.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 4,
                    Name = "Earth's Mightiest Heroes",
                    CaptainId = user11.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 5,
                    Name = "The New Avengers",
                    CaptainId = user12.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 6,
                    Name = "101st Airborne",
                    CaptainId = user13.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 7,
                    Name = "Space Invaders",
                    CaptainId = user14.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 8,
                    Name = "Red October",
                    CaptainId = user15.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 9,
                    Name = "Tornadoes",
                    CaptainId = user16.Id,
                    DateCreated = DateTime.Now
                },
                new Team()
                {
                    Id = 10,
                    Name = "Predators",
                    CaptainId = user17.Id,
                    DateCreated = DateTime.Now
                }
            );

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
