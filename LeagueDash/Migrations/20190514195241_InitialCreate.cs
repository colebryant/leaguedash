using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDash.Migrations
{
    public partial class InitialCreate : Migration
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
                    { "ce96ae73-4dc3-4bed-bd0b-de0668220618", 0, "bbcc79d4-ad38-4a49-9dce-daca9c88139d", "rodger@rodger.com", true, "Rodger", "Commish", false, null, "RODGER@RODGER.COM", "RODGER@RODGER.COM", "AQAAAAEAACcQAAAAEIQTrzNd9smYjFpywJt8HLpLuxMXDoXiCQXFi82Onay4wdC/y866tXRfREw8poEUZg==", null, false, 1, 3, "97704b3d-6c68-495f-9b6b-3ef1b0f176f6", null, false, "rodger@rodger.com" },
                    { "32a6205f-51d6-4d5e-b34d-5b3d8aea546f", 0, "9ff6ec08-209b-4a47-9461-e56fe7f6dd3a", "juan@juan.com", true, "Juan", "Captains", false, null, "JUAN@JUAN.COM", "JUAN@JUAN.COM", "AQAAAAEAACcQAAAAEASdfmL/03uL105qlZdmknXENGNLGcZlvzyBZckUb+iQfiKiEHU7WKrVJruWOI7R2Q==", null, false, 1, 2, "030454b8-95c4-4086-884d-de1da2a457c0", 10, false, "juan@juan.com" },
                    { "e8a990f7-f7eb-402b-a751-032f589f151b", 0, "3b290183-4edb-4d35-a107-738e622954d5", "marko@marko.com", true, "Marko", "Ramius", false, null, "MARKO@MARKO.COM", "MARKO@MARKO.COM", "AQAAAAEAACcQAAAAEKEHts1jAgH1T2TsB1SNJdNfuzooakUbKDXIQMDk+v3rUhpNkd4yGDfGUNEwoQfxYw==", null, false, 2, 2, "cd4e9cc6-c391-4205-9637-9767861e7327", 8, false, "marko@marko.com" },
                    { "643f61f2-e472-4286-85a1-d0745e3acd3d", 0, "13d41d76-2af0-4e70-96cb-b626e2e4157e", "james@james.com", true, "James", "Kirk", false, null, "JAMES@JAMES.COM", "JAMES@JAMES.COM", "AQAAAAEAACcQAAAAELZUrs+Zr2VCv0nU/oGc82NVZaIoZ1kz/UmyaKm/DFTzJ9SzGCQCREIfk6G6WXxX9Q==", null, false, 3, 2, "e5d6144b-400e-4470-85c6-0469374bd66c", 7, false, "james@james.com" },
                    { "ec515133-6e28-438f-a93c-d8d3bd897b34", 0, "32669fa1-91f0-4bd0-827d-ca1f0b01f524", "john@john.com", true, "John", "Miller", false, null, "JOHN@JOHN.COM", "JOHN@JOHN.COM", "AQAAAAEAACcQAAAAENAivw+W3u/gftro/h56wd4l85zqCPI1iu7g3dMHPC0xetOqGiD8QJdvy72nNVND8A==", null, false, 3, 2, "058fb48c-a80c-4904-b3e2-493a431ba305", 6, false, "john@john.com" },
                    { "de01d5f4-de08-4b1d-bd03-0f0b3ead376b", 0, "91924fca-5003-4d3c-bbec-51f5d4ad7a8b", "carol@carol.com", true, "Carol", "Danvers", false, null, "CAROL@CAROL.COM", "CAROL@CAROL.COM", "AQAAAAEAACcQAAAAEJJAoAZv4Mj/X7+qDEHepzJmX2lxA8CWBwYKnM8fWk/v0CL6w67cDqknpwrxrjUE6g==", null, false, 5, 2, "222ea9dc-6354-4cb7-a5ce-73de726b1740", 5, false, "carol@carol.com" },
                    { "ffe39243-ed2a-4531-a1d4-7d87adcd9461", 0, "0314a599-5773-4cff-b4be-645c2740b067", "steve@steve.com", true, "Steve", "Rodgers", false, null, "STEVE@STEVE.COM", "STEVE@STEVE.COM", "AQAAAAEAACcQAAAAEEKJ/LB+CSKgDL1Bg+jykwv0FfKY3TFziEtXpQNFqOdbDuT5pOKvyB0K/RXELgEpsQ==", null, false, 4, 2, "76afa8cc-dcdf-484d-8f9a-353ac38e1b44", 4, false, "steve@steve.com" },
                    { "0a2fa575-0739-4ee6-a797-83370a17b615", 0, "caf2acbc-ad46-456f-b125-513edfaa3f6d", "jack@jack.com", true, "Jack", "Sparrow", false, null, "JACK@JACK.COM", "JACK@JACK.COM", "AQAAAAEAACcQAAAAECBEeEcR9R+4iiI609xyhi0Lk4Wb7ek7Ou4wG38A5IDpU0NNyIkhNql4DYr0+oJTJg==", null, false, 5, 2, "1b8ee3d2-bdf5-4d4a-8815-543ec6db9ab4", 3, false, "jack@jack.com" },
                    { "75fb5fe3-0eef-4642-b893-fca05d421344", 0, "fa084057-1462-4369-87aa-a1af51e8850d", "terry@teryy.com", true, "Terry", "Captains", false, null, "TERRY@TERRY.COM", "TERRY@TERYY.COM", "AQAAAAEAACcQAAAAEI4/MzAKJYY/TfTPEL8VAJdR924VJnhCh+qenhoCwaLHFNLe2LAQ5bDfGK05Eautog==", null, false, 1, 2, "264073a7-13c6-4334-88b8-6ca2578f13e7", 9, false, "terry@terry.com" },
                    { "5af0f2e1-71f3-484d-a517-aeba23c97473", 0, "f7727abd-680d-46a0-8c6c-2aa075f0cae9", "bastion@bastion.com", true, "Bastion", "Schweinsteiger", false, null, "BASTION@BASTION.COM", "BASTION@BASTION.COM", "AQAAAAEAACcQAAAAEOoxqi7Ox7L1Ol4+t71K/d439TnkdKsVMLYvBdHTdTnmfRIRxrlvnfGmUhF9PL6ybw==", null, false, 4, 1, "828419d6-4e70-4d81-9335-a57372a238e8", null, false, "bastion@bastion.com" },
                    { "e189db7b-2e13-453a-a5ea-b12d55f1054f", 0, "64864092-35db-445b-9a68-d812a3d62275", "thomas@thomas.com", true, "Thomas", "Muller", false, null, "THOMAS@THOMAS.COM", "THOMAS@THOMAS.COM", "AQAAAAEAACcQAAAAEJtH79JSpiZB4m898uiFBRDQ8M+5O8PsPzA15QIt9wPPFUUYRxLGs0w29thDKNt+Pw==", null, false, 4, 1, "0c2c2b09-6cd0-45f2-b9dd-ee82fb652ff3", null, false, "thomas@thomas.com" },
                    { "d86ee9dd-418e-4f2e-9e37-8df4b14f19ee", 0, "68fff582-0c1b-46e7-8d43-22e0e188f98b", "sergio@sergio.com", true, "Sergio", "Ramos", false, null, "SERGIO@SERGIO.COM", "SERGIO@SERGIO.COM", "AQAAAAEAACcQAAAAEMh1I4MP8lhTr4ZYn6MyoschqnmxiCB0BvZiic0Byi11hGwMPfpgHwVqBKOOtsFIiA==", null, false, 3, 1, "dc627198-d9a3-4de0-adf7-f14a465cb082", null, false, "sergio@sergio.com" },
                    { "1d743f4e-fbf6-427b-8382-d545e070c959", 0, "4816e40a-7930-4380-9dd5-c7ef39abeea8", "cristiano@cristiano.com", true, "Cristiano", "Ronaldo", false, null, "CRISTIANO@CRISTIANO.COM", "CRISTIANO@CRISTIANO.COM", "AQAAAAEAACcQAAAAENRUVVKXA5Ya3KL9RreVcKXHAKAEs0FbfRqawmwzLtP5i2Q7AYLGDnuJyQMeM3Skhg==", null, false, 4, 1, "76f54498-4632-4f63-81db-e953dd3809b1", null, false, "cristiano@cristiano.com" },
                    { "462ced06-6c69-45ab-ae3d-36c31bc6ab86", 0, "4e7908cf-6fd2-4bda-90bb-88d69efa1ab7", "lionel@lionel.com", true, "Lionel", "Messi", false, null, "LIONEL@LIONEL.COM", "LIONEL@LIONEL.COM", "AQAAAAEAACcQAAAAEHN6Yi9WIZrzw49mI5C4SbXafCVCY84yXKT2YLp2K9rVPaSkyspA0aeVS9xkZCcIyA==", null, false, 5, 1, "9e89fe99-c83b-4910-bce1-d4cb7c445efe", null, false, "lionel@lionel.com" },
                    { "fe134dea-dd8e-4c07-9201-4472a6409ac7", 0, "ba9aef42-1e76-47bb-9515-e82900cff2aa", "julia@julia.com", true, "Julia", "Players", false, null, "JULIA@JULIA.COM", "JULIA@JULIA.COM", "AQAAAAEAACcQAAAAEIECs/xxltFYOToFhHAgnDMy8tZCmhVgot8EC+tM1IfjcK4BT2lFO+sfVeT6ZfxbCg==", null, false, 5, 1, "b84beed6-2563-41ec-96a4-49008c939e49", null, false, "julia@julia.com" },
                    { "0251cc8d-baaa-4aa6-ba92-1c95d6377770", 0, "66aa342f-7986-493c-b1a8-c13930e29e8c", "will@will.com", true, "Will", "Captains", false, null, "WILL@WILL.COM", "WILL@WILL.COM", "AQAAAAEAACcQAAAAEAzkmB0bHPdifp5wLU83M9zCzwjmaKBb5PRqUfDBKKxoZ1J83t3dFg5jK8BB+ewF3g==", null, false, 2, 2, "ee7ac600-2647-445e-a296-7d8760baa085", 1, false, "will@will.com" },
                    { "80e593ff-b140-40cb-9947-916ff58a9e4f", 0, "d2ea1d7d-287e-4a9d-a524-6af7320ea476", "billy@billy.com", true, "Billy", "Captains", false, null, "BILLY@BILLY.COM", "BILLY@BILLY.COM", "AQAAAAEAACcQAAAAENrysqC6HVwv3buGvj7QAhD44NStes94i4YcDMOaQMydoX4U0H/+zOqbdNEVunBRdQ==", null, false, 2, 2, "e892b0ca-5fb5-4f4d-bef4-ff5603440125", 2, false, "billy@billy.com" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "GameTime", "Location", "TeamAId", "TeamAScore", "TeamBId", "TeamBScore" },
                values: new object[,]
                {
                    { 19, new DateTime(2019, 5, 21, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 4, 7, 5, 2 },
                    { 20, new DateTime(2019, 5, 26, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 4, 5, 6, 6 },
                    { 21, new DateTime(2019, 5, 28, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 4, 4, 7, 4 },
                    { 22, new DateTime(2019, 5, 30, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 4, 1, 8, 2 },
                    { 23, new DateTime(2019, 6, 4, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 4, 2, 9, 1 },
                    { 24, new DateTime(2019, 6, 6, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 4, 4, 10, 2 },
                    { 28, new DateTime(2019, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 5, 2, 9, 2 },
                    { 26, new DateTime(2019, 5, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 5, 5, 7, 2 },
                    { 27, new DateTime(2019, 5, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 5, 2, 8, 5 },
                    { 29, new DateTime(2019, 6, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 5, 3, 10, 2 },
                    { 30, new DateTime(2019, 6, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 5, 2, 1, 3 },
                    { 18, new DateTime(2019, 6, 6, 19, 45, 0, 0, DateTimeKind.Unspecified), "West Park", 3, 5, 9, 2 },
                    { 25, new DateTime(2019, 5, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 5, 3, 6, 2 },
                    { 17, new DateTime(2019, 6, 4, 19, 45, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 3, 4, 8, 1 },
                    { 16, new DateTime(2019, 5, 30, 19, 45, 0, 0, DateTimeKind.Unspecified), "West Park", 3, 2, 7, 1 },
                    { 2, new DateTime(2019, 5, 26, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 1, 2, 3, 0 },
                    { 1, new DateTime(2019, 5, 21, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 1, 4, 2, 3 },
                    { 3, new DateTime(2019, 5, 28, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 1, 5, 4, 3 },
                    { 4, new DateTime(2019, 5, 30, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 1, 2, 5, 1 },
                    { 5, new DateTime(2019, 6, 4, 19, 15, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 1, 4, 6, 1 },
                    { 6, new DateTime(2019, 6, 6, 19, 15, 0, 0, DateTimeKind.Unspecified), "West Park", 1, 5, 7, 4 },
                    { 8, new DateTime(2019, 5, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 2, 1, 4, 2 },
                    { 7, new DateTime(2019, 5, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 2, 4, 3, 3 },
                    { 10, new DateTime(2019, 5, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 2, 2, 6, 1 },
                    { 11, new DateTime(2019, 6, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 2, 4, 7, 1 },
                    { 12, new DateTime(2019, 6, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), "West Park", 2, 5, 8, 4 },
                    { 13, new DateTime(2019, 5, 21, 19, 45, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 3, 0, 4, 2 },
                    { 14, new DateTime(2019, 5, 26, 19, 45, 0, 0, DateTimeKind.Unspecified), "West Park", 3, 1, 5, 2 },
                    { 9, new DateTime(2019, 5, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 2, 4, 5, 3 },
                    { 15, new DateTime(2019, 5, 28, 19, 45, 0, 0, DateTimeKind.Unspecified), "Elmington Park", 3, 4, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Midfielder" },
                    { 5, "Forward" },
                    { 2, "Goalkeeper" },
                    { 1, "No Preference" },
                    { 3, "Defender" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Player" },
                    { 2, "Captain" },
                    { 3, "Commissioner" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "CaptainId", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 6, "ec515133-6e28-438f-a93c-d8d3bd897b34", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1981), "101st Airborne" },
                    { 8, "e8a990f7-f7eb-402b-a751-032f589f151b", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1988), "Red October" },
                    { 7, "643f61f2-e472-4286-85a1-d0745e3acd3d", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1984), "Space Invaders" },
                    { 5, "de01d5f4-de08-4b1d-bd03-0f0b3ead376b", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1977), "The New Avengers" },
                    { 9, "75fb5fe3-0eef-4642-b893-fca05d421344", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1995), "Tornadoes" },
                    { 3, "0a2fa575-0739-4ee6-a797-83370a17b615", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1970), "Salty Pirates" },
                    { 2, "80e593ff-b140-40cb-9947-916ff58a9e4f", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1953), "Junior Wombats" },
                    { 1, "0251cc8d-baaa-4aa6-ba92-1c95d6377770", new DateTime(2019, 5, 14, 14, 52, 40, 949, DateTimeKind.Local).AddTicks(6582), "Nashville SC" },
                    { 4, "ffe39243-ed2a-4531-a1d4-7d87adcd9461", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1974), "Earth's Mightiest Heroes" },
                    { 10, "32a6205f-51d6-4d5e-b34d-5b3d8aea546f", new DateTime(2019, 5, 14, 14, 52, 40, 953, DateTimeKind.Local).AddTicks(1998), "Predators" }
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
