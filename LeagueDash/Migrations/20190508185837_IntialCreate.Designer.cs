﻿// <auto-generated />
using System;
using LeagueDash.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueDash.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190508185837_IntialCreate")]
    partial class IntialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueDash.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("PositionId");

                    b.Property<int>("RoleId");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("TeamId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "654c333b-a61b-4ce3-a116-08d429217e5f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "26c8b93e-6bb9-4e1b-a7c0-3131ccd3ce9e",
                            Email = "rodger@rodger.com",
                            EmailConfirmed = true,
                            FirstName = "Rodger",
                            LastName = "Commish",
                            LockoutEnabled = false,
                            NormalizedEmail = "RODGER@RODGER.COM",
                            NormalizedUserName = "RODGER@RODGER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDovM3bnjt+HMDUNC2XwPRMFx6l5cbXkbcgFes7IedpZ8yZhxQU24UNj1+B1SQzNUQ==",
                            PhoneNumberConfirmed = false,
                            PositionId = 1,
                            RoleId = 3,
                            SecurityStamp = "0edf4060-05bd-4b88-a97b-e157c7049007",
                            TwoFactorEnabled = false,
                            UserName = "rodger@rodger.com"
                        },
                        new
                        {
                            Id = "8d84e18b-866d-4c4f-86d0-6ddbe93ec055",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0c3d9d24-4834-4839-8c62-abe5cd5a60bb",
                            Email = "steve@steve.com",
                            EmailConfirmed = true,
                            FirstName = "Steve",
                            LastName = "Captains",
                            LockoutEnabled = false,
                            NormalizedEmail = "STEVE@STEVE.COM",
                            NormalizedUserName = "STEVE@STEVE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPEISoXhemGvL287D/GvfPYh9xONBcN5sxhoJOnuJ/KIKd/4/XmSw7OW7ynbDljeTg==",
                            PhoneNumberConfirmed = false,
                            PositionId = 2,
                            RoleId = 2,
                            SecurityStamp = "d3428dd9-e36d-4e40-90c2-86991011b79b",
                            TwoFactorEnabled = false,
                            UserName = "steve@steve.com"
                        },
                        new
                        {
                            Id = "11527770-b80a-4531-9e56-2c4f5e3b65de",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "527a805f-18fd-4c6b-ad13-ba9c6ba73fcb",
                            Email = "julia@julia.com",
                            EmailConfirmed = true,
                            FirstName = "Julia",
                            LastName = "Players",
                            LockoutEnabled = false,
                            NormalizedEmail = "JULIA@JULIA.COM",
                            NormalizedUserName = "JULIA@JULIA.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEU3KtQYD0QDlDDHIZeFDLjv+D9x00WaE1C0igbCOTyBDyRlhDI4hTZ9iBX9/J6sYA==",
                            PhoneNumberConfirmed = false,
                            PositionId = 5,
                            RoleId = 1,
                            SecurityStamp = "d13e5a0c-e9c3-4c97-a101-86ec2feb1aae",
                            TwoFactorEnabled = false,
                            UserName = "julia@julia.com"
                        },
                        new
                        {
                            Id = "8f8ecd9f-b1ef-4975-8830-b3e2df3a08ba",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ec54598-3d6b-497b-8321-6897bb61c3a5",
                            Email = "lionel@lionel.com",
                            EmailConfirmed = true,
                            FirstName = "Lionel",
                            LastName = "Messi",
                            LockoutEnabled = false,
                            NormalizedEmail = "LIONEL@LIONEL.COM",
                            NormalizedUserName = "LIONEL@LIONEL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGbbBLy15+kZXeaEvjq55nF0amgWJAAP641wmhkkatJtVhdfMgw7g4/jMGh5j4ca8g==",
                            PhoneNumberConfirmed = false,
                            PositionId = 5,
                            RoleId = 1,
                            SecurityStamp = "55729465-6c27-4737-8c5e-6d11b9e8041a",
                            TwoFactorEnabled = false,
                            UserName = "lionel@lionel.com"
                        },
                        new
                        {
                            Id = "b6941da7-dfeb-429e-b3ec-28a8bc1df740",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3e698277-a857-4a52-8e61-011894748710",
                            Email = "cristiano@cristiano.com",
                            EmailConfirmed = true,
                            FirstName = "Cristiano",
                            LastName = "Ronaldo",
                            LockoutEnabled = false,
                            NormalizedEmail = "CRISTIANO@CRISTIANO.COM",
                            NormalizedUserName = "CRISTIANO@CRISTIANO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHqnXGaLA85lZPkAQQzSmWIvWaYXzNWDNZ25KYG+2nNJQaikxWPr3FaZHk4Vi6haYw==",
                            PhoneNumberConfirmed = false,
                            PositionId = 4,
                            RoleId = 1,
                            SecurityStamp = "a64d02c8-5e04-43ab-9a86-3fece849966c",
                            TwoFactorEnabled = false,
                            UserName = "cristiano@cristiano.com"
                        },
                        new
                        {
                            Id = "bd4fd247-f33e-423e-b1dc-1abd15e1b314",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b05e98a-551b-4127-b21a-7432c605e085",
                            Email = "sergio@sergio.com",
                            EmailConfirmed = true,
                            FirstName = "Sergio",
                            LastName = "Ramos",
                            LockoutEnabled = false,
                            NormalizedEmail = "SERGIO@SERGIO.COM",
                            NormalizedUserName = "SERGIO@SERGIO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGw9JCjQTb3/XVl/4qKFSrYNev8qkTBZsTxKBe2DdXrKyVxCsf1dJn/kod7Gegru2Q==",
                            PhoneNumberConfirmed = false,
                            PositionId = 3,
                            RoleId = 1,
                            SecurityStamp = "f855a6d3-fb9d-477f-8ea5-4fd04870f2d3",
                            TwoFactorEnabled = false,
                            UserName = "sergio@sergio.com"
                        },
                        new
                        {
                            Id = "9da84424-913a-4731-b4cc-6d32d30ad5b9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d09a59dd-60e4-4dad-a959-99456f0e49d6",
                            Email = "thomas@thomas.com",
                            EmailConfirmed = true,
                            FirstName = "Thomas",
                            LastName = "Muller",
                            LockoutEnabled = false,
                            NormalizedEmail = "THOMAS@THOMAS.COM",
                            NormalizedUserName = "THOMAS@THOMAS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI7ePSNdsKmrsV6U6OE+A5lgU1zx7wrxObQjv/4NtiaIj/C0SDNMajiE3Llp6rl3rQ==",
                            PhoneNumberConfirmed = false,
                            PositionId = 4,
                            RoleId = 1,
                            SecurityStamp = "4a72b4c8-6596-4083-aaf3-f20d589a6d5a",
                            TwoFactorEnabled = false,
                            UserName = "thomas@thomas.com"
                        },
                        new
                        {
                            Id = "525cef48-e0d5-49d2-94c6-8e47fa6965c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "07aa7b67-ecc4-4a23-8fe4-cc8d5892852a",
                            Email = "bastion@bastion.com",
                            EmailConfirmed = true,
                            FirstName = "Bastion",
                            LastName = "Schweinsteiger",
                            LockoutEnabled = false,
                            NormalizedEmail = "BASTION@BASTION.COM",
                            NormalizedUserName = "BASTION@BASTION.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENmEP8S3VekBbt1jk7HsVrMONGwVZV2Dc5MwCHiaLPZu7Y+UpmK82KzbsL/vCktDRA==",
                            PhoneNumberConfirmed = false,
                            PositionId = 4,
                            RoleId = 1,
                            SecurityStamp = "8d819fac-788d-4ca8-a9e2-82753d4bdd55",
                            TwoFactorEnabled = false,
                            UserName = "bastion@bastion.com"
                        },
                        new
                        {
                            Id = "48879eb3-3366-470d-ab9a-4a9c10931ef1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a57d8890-4ffd-46ff-bde4-bd17faaa2151",
                            Email = "billy@billy.com",
                            EmailConfirmed = true,
                            FirstName = "Billy",
                            LastName = "Captains",
                            LockoutEnabled = false,
                            NormalizedEmail = "BILLY@BILLY.COM",
                            NormalizedUserName = "BILLY@BILLY.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECbVYMue8lFrYCwV4/d6/BxwvWIwFH9kGvlmcMVCKFnAt7La/B+9IPpnecqlR1Yrow==",
                            PhoneNumberConfirmed = false,
                            PositionId = 2,
                            RoleId = 2,
                            SecurityStamp = "8de6247c-d755-4e61-89f9-238e762dc981",
                            TwoFactorEnabled = false,
                            UserName = "billy@billy.com"
                        });
                });

            modelBuilder.Entity("LeagueDash.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GameTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<int>("TeamAId");

                    b.Property<int?>("TeamAScore");

                    b.Property<int>("TeamBId");

                    b.Property<int?>("TeamBScore");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("LeagueDash.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "No Preference"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Goalkeeper"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Defender"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Midfielder"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Forward"
                        });
                });

            modelBuilder.Entity("LeagueDash.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Player"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Captain"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Commissioner"
                        });
                });

            modelBuilder.Entity("LeagueDash.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaptainId")
                        .IsRequired();

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LeagueDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LeagueDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LeagueDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LeagueDash.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}