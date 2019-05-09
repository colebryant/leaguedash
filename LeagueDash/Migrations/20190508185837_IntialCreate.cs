using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDash.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameTime = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Location = table.Column<string>(nullable: false),
                    TeamAId = table.Column<int>(nullable: false),
                    TeamBId = table.Column<int>(nullable: false),
                    TeamAScore = table.Column<int>(nullable: true),
                    TeamBScore = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    CaptainId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PositionId", "RoleId", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "654c333b-a61b-4ce3-a116-08d429217e5f", 0, "26c8b93e-6bb9-4e1b-a7c0-3131ccd3ce9e", "rodger@rodger.com", true, "Rodger", "Commish", false, null, "RODGER@RODGER.COM", "RODGER@RODGER.COM", "AQAAAAEAACcQAAAAEDovM3bnjt+HMDUNC2XwPRMFx6l5cbXkbcgFes7IedpZ8yZhxQU24UNj1+B1SQzNUQ==", null, false, 1, 3, "0edf4060-05bd-4b88-a97b-e157c7049007", null, false, "rodger@rodger.com" },
                    { "525cef48-e0d5-49d2-94c6-8e47fa6965c2", 0, "07aa7b67-ecc4-4a23-8fe4-cc8d5892852a", "bastion@bastion.com", true, "Bastion", "Schweinsteiger", false, null, "BASTION@BASTION.COM", "BASTION@BASTION.COM", "AQAAAAEAACcQAAAAENmEP8S3VekBbt1jk7HsVrMONGwVZV2Dc5MwCHiaLPZu7Y+UpmK82KzbsL/vCktDRA==", null, false, 4, 1, "8d819fac-788d-4ca8-a9e2-82753d4bdd55", null, false, "bastion@bastion.com" },
                    { "9da84424-913a-4731-b4cc-6d32d30ad5b9", 0, "d09a59dd-60e4-4dad-a959-99456f0e49d6", "thomas@thomas.com", true, "Thomas", "Muller", false, null, "THOMAS@THOMAS.COM", "THOMAS@THOMAS.COM", "AQAAAAEAACcQAAAAEI7ePSNdsKmrsV6U6OE+A5lgU1zx7wrxObQjv/4NtiaIj/C0SDNMajiE3Llp6rl3rQ==", null, false, 4, 1, "4a72b4c8-6596-4083-aaf3-f20d589a6d5a", null, false, "thomas@thomas.com" },
                    { "bd4fd247-f33e-423e-b1dc-1abd15e1b314", 0, "8b05e98a-551b-4127-b21a-7432c605e085", "sergio@sergio.com", true, "Sergio", "Ramos", false, null, "SERGIO@SERGIO.COM", "SERGIO@SERGIO.COM", "AQAAAAEAACcQAAAAEGw9JCjQTb3/XVl/4qKFSrYNev8qkTBZsTxKBe2DdXrKyVxCsf1dJn/kod7Gegru2Q==", null, false, 3, 1, "f855a6d3-fb9d-477f-8ea5-4fd04870f2d3", null, false, "sergio@sergio.com" },
                    { "48879eb3-3366-470d-ab9a-4a9c10931ef1", 0, "a57d8890-4ffd-46ff-bde4-bd17faaa2151", "billy@billy.com", true, "Billy", "Captains", false, null, "BILLY@BILLY.COM", "BILLY@BILLY.COM", "AQAAAAEAACcQAAAAECbVYMue8lFrYCwV4/d6/BxwvWIwFH9kGvlmcMVCKFnAt7La/B+9IPpnecqlR1Yrow==", null, false, 2, 2, "8de6247c-d755-4e61-89f9-238e762dc981", null, false, "billy@billy.com" },
                    { "8f8ecd9f-b1ef-4975-8830-b3e2df3a08ba", 0, "8ec54598-3d6b-497b-8321-6897bb61c3a5", "lionel@lionel.com", true, "Lionel", "Messi", false, null, "LIONEL@LIONEL.COM", "LIONEL@LIONEL.COM", "AQAAAAEAACcQAAAAEGbbBLy15+kZXeaEvjq55nF0amgWJAAP641wmhkkatJtVhdfMgw7g4/jMGh5j4ca8g==", null, false, 5, 1, "55729465-6c27-4737-8c5e-6d11b9e8041a", null, false, "lionel@lionel.com" },
                    { "11527770-b80a-4531-9e56-2c4f5e3b65de", 0, "527a805f-18fd-4c6b-ad13-ba9c6ba73fcb", "julia@julia.com", true, "Julia", "Players", false, null, "JULIA@JULIA.COM", "JULIA@JULIA.COM", "AQAAAAEAACcQAAAAEEU3KtQYD0QDlDDHIZeFDLjv+D9x00WaE1C0igbCOTyBDyRlhDI4hTZ9iBX9/J6sYA==", null, false, 5, 1, "d13e5a0c-e9c3-4c97-a101-86ec2feb1aae", null, false, "julia@julia.com" },
                    { "8d84e18b-866d-4c4f-86d0-6ddbe93ec055", 0, "0c3d9d24-4834-4839-8c62-abe5cd5a60bb", "steve@steve.com", true, "Steve", "Captains", false, null, "STEVE@STEVE.COM", "STEVE@STEVE.COM", "AQAAAAEAACcQAAAAEPEISoXhemGvL287D/GvfPYh9xONBcN5sxhoJOnuJ/KIKd/4/XmSw7OW7ynbDljeTg==", null, false, 2, 2, "d3428dd9-e36d-4e40-90c2-86991011b79b", null, false, "steve@steve.com" },
                    { "b6941da7-dfeb-429e-b3ec-28a8bc1df740", 0, "3e698277-a857-4a52-8e61-011894748710", "cristiano@cristiano.com", true, "Cristiano", "Ronaldo", false, null, "CRISTIANO@CRISTIANO.COM", "CRISTIANO@CRISTIANO.COM", "AQAAAAEAACcQAAAAEHqnXGaLA85lZPkAQQzSmWIvWaYXzNWDNZ25KYG+2nNJQaikxWPr3FaZHk4Vi6haYw==", null, false, 4, 1, "a64d02c8-5e04-43ab-9a86-3fece849966c", null, false, "cristiano@cristiano.com" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "No Preference" },
                    { 2, "Goalkeeper" },
                    { 3, "Defender" },
                    { 4, "Midfielder" },
                    { 5, "Forward" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Captain" },
                    { 1, "Player" },
                    { 3, "Commissioner" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
