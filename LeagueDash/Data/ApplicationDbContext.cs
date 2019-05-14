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
            user.PasswordHash = passwordHash.HashPassword(user, "Abc123!");

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
            user2.PasswordHash = passwordHash2.HashPassword(user2, "Abc123!");

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
            user3.PasswordHash = passwordHash3.HashPassword(user3, "Abc123!");

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
            user4.PasswordHash = passwordHash4.HashPassword(user4, "Abc123!");

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
            user5.PasswordHash = passwordHash5.HashPassword(user5, "Abc123!");

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
            user6.PasswordHash = passwordHash6.HashPassword(user6, "Abc123!");

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
            user7.PasswordHash = passwordHash7.HashPassword(user7, "Abc123!");

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
            user8.PasswordHash = passwordHash8.HashPassword(user8, "Abc123!");

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
            user9.PasswordHash = passwordHash9.HashPassword(user9, "Abc123!");

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
            user10.PasswordHash = passwordHash10.HashPassword(user10, "Abc123!");

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
            user11.PasswordHash = passwordHash11.HashPassword(user11, "Abc123!");

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
            user12.PasswordHash = passwordHash12.HashPassword(user12, "Abc123!");

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
            user13.PasswordHash = passwordHash13.HashPassword(user13, "Abc123!");

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
            user14.PasswordHash = passwordHash14.HashPassword(user14, "Abc123!");

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
            user15.PasswordHash = passwordHash15.HashPassword(user15, "Abc123!");

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
            user16.PasswordHash = passwordHash16.HashPassword(user16, "Abc123!");

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
            user17.PasswordHash = passwordHash17.HashPassword(user16, "Abc123!");

            modelBuilder.Entity<ApplicationUser>().HasData(user, user2, user3, user4, user5, user6, user7, user8, user9,
                user10, user11, user12, user13, user14, user15, user16, user17);

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

            modelBuilder.Entity<Game>().HasData(
                new Game()
                {
                    Id = 1,
                    TeamAId = 1,
                    TeamBId = 2,
                    TeamAScore = 4,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 21, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 2,
                    TeamAId = 1,
                    TeamBId = 3,
                    TeamAScore = 2,
                    TeamBScore = 0,
                    GameTime = new DateTime(2019, 5, 26, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 3,
                    TeamAId = 1,
                    TeamBId = 4,
                    TeamAScore = 5,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 28, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 4,
                    TeamAId = 1,
                    TeamBId = 5,
                    TeamAScore = 2,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 5, 30, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 5,
                    TeamAId = 1,
                    TeamBId = 6,
                    TeamAScore = 4,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 6, 4, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 6,
                    TeamAId = 1,
                    TeamBId = 7,
                    TeamAScore = 5,
                    TeamBScore = 4,
                    GameTime = new DateTime(2019, 6, 6, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 7,
                    TeamAId = 2,
                    TeamBId = 3,
                    TeamAScore = 4,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 21, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 8,
                    TeamAId = 2,
                    TeamBId = 4,
                    TeamAScore = 1,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 26, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 9,
                    TeamAId = 2,
                    TeamBId = 5,
                    TeamAScore = 4,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 28, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 10,
                    TeamAId = 2,
                    TeamBId = 6,
                    TeamAScore = 2,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 5, 30, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 11,
                    TeamAId = 2,
                    TeamBId = 7,
                    TeamAScore = 4,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 6, 4, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 12,
                    TeamAId = 2,
                    TeamBId = 8,
                    TeamAScore = 5,
                    TeamBScore = 4,
                    GameTime = new DateTime(2019, 6, 6, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 13,
                    TeamAId = 3,
                    TeamBId = 4,
                    TeamAScore = 0,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 21, 19, 45, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 14,
                    TeamAId = 3,
                    TeamBId = 5,
                    TeamAScore = 1,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 26, 19, 45, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 15,
                    TeamAId = 3,
                    TeamBId = 6,
                    TeamAScore = 4,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 28, 19, 45, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 16,
                    TeamAId = 3,
                    TeamBId = 7,
                    TeamAScore = 2,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 5, 30, 19, 45, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 17,
                    TeamAId = 3,
                    TeamBId = 8,
                    TeamAScore = 4,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 6, 4, 19, 45, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 18,
                    TeamAId = 3,
                    TeamBId = 9,
                    TeamAScore = 5,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 6, 6, 19, 45, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 19,
                    TeamAId = 4,
                    TeamBId = 5,
                    TeamAScore = 7,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 21, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 20,
                    TeamAId = 4,
                    TeamBId = 6,
                    TeamAScore = 5,
                    TeamBScore = 6,
                    GameTime = new DateTime(2019, 5, 26, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 21,
                    TeamAId = 4,
                    TeamBId = 7,
                    TeamAScore = 4,
                    TeamBScore = 4,
                    GameTime = new DateTime(2019, 5, 28, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 22,
                    TeamAId = 4,
                    TeamBId = 8,
                    TeamAScore = 1,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 30, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 23,
                    TeamAId = 4,
                    TeamBId = 9,
                    TeamAScore = 2,
                    TeamBScore = 1,
                    GameTime = new DateTime(2019, 6, 4, 19, 15, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 24,
                    TeamAId = 4,
                    TeamBId = 10,
                    TeamAScore = 4,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 6, 6, 19, 15, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 25,
                    TeamAId = 5,
                    TeamBId = 6,
                    TeamAScore = 3,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 21, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 26,
                    TeamAId = 5,
                    TeamBId = 7,
                    TeamAScore = 5,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 26, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 27,
                    TeamAId = 5,
                    TeamBId = 8,
                    TeamAScore = 2,
                    TeamBScore = 5,
                    GameTime = new DateTime(2019, 5, 28, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 28,
                    TeamAId = 5,
                    TeamBId = 9,
                    TeamAScore = 2,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 5, 30, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 29,
                    TeamAId = 5,
                    TeamBId = 10,
                    TeamAScore = 3,
                    TeamBScore = 2,
                    GameTime = new DateTime(2019, 6, 4, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 30,
                    TeamAId = 5,
                    TeamBId = 1,
                    TeamAScore = 2,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 6, 6, 19, 30, 0),
                    Location = "West Park"
                },
                new Game()
                {
                    Id = 31,
                    TeamAId = 9,
                    TeamBId = 10,    
                    TeamAScore = 2,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 21, 19, 30, 0),
                    Location = "Elmington Park"
                },
                new Game()
                {
                    Id = 32,
                    TeamAId = 10,
                    TeamBId = 8,
                    TeamAScore = 2,
                    TeamBScore = 3,
                    GameTime = new DateTime(2019, 5, 23, 19, 30, 0),
                    Location = "West Park"
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
