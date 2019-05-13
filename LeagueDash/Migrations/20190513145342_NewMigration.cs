using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueDash.Migrations
{
    public partial class NewMigration : Migration
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
                    { "5061754a-5d88-4e46-a8ac-62f4434af4ed", 0, "d8001a2b-982f-43d3-988b-c8f513b4ede3", "rodger@rodger.com", true, "Rodger", "Commish", false, null, "RODGER@RODGER.COM", "RODGER@RODGER.COM", "AQAAAAEAACcQAAAAEMojExUgT82Sawpwveu6LLFuEpNJxX4iUBu77tG5nPuyvouw3wm+xvL1EDy5K0iJWA==", null, false, 1, 3, "b8eef87f-e160-425f-9d50-73170ecd9bcc", null, false, "rodger@rodger.com" },
                    { "e5a76361-c5f6-4ba1-a097-fd15b1eff8a4", 0, "c4f35365-ce41-48a6-979a-8fa4c9848371", "juan@juan.com", true, "Juan", "Captains", false, null, "JUAN@JUAN.COM", "JUAN@JUAN.COM", "AQAAAAEAACcQAAAAEHzRUkLjFvbfcTfPDkXInVgFkl8WdNqmbl14YQxO6ZdI7ltG0KmQ5yKnBtVDwXFQXw==", null, false, 1, 2, "e5ce20ae-b34c-4437-865e-92fdd39696c1", 10, false, "juan@juan.com" },
                    { "0a045a11-593d-421c-b073-415a6b0a7ab0", 0, "985c4af2-84d9-4e89-a5bd-e086367f6bde", "terry@teryy.com", true, "Terry", "Captains", false, null, "TERRY@TERRY.COM", "TERRY@TERYY.COM", "AQAAAAEAACcQAAAAEO098INs0gJ1jO7kUKKCIFsOKP/DqX2QXmWYtMeuSbH4Lh0UfNef1GNt+yUeGSvY/w==", null, false, 1, 2, "0e5ab7c1-56a9-4502-9420-27aff0d19e81", 9, false, "terry@terry.com" },
                    { "114fa0b1-9ac0-443c-b9c2-c8c97d44cf31", 0, "5b4d933c-8d12-4be6-9cff-89f514ed2996", "marko@marko.com", true, "Marko", "Ramius", false, null, "MARKO@MARKO.COM", "MARKO@MARKO.COM", "AQAAAAEAACcQAAAAEAT0cWz1nOKfTkvZDoUuhHjyOfq1XneIE5o3AOYZCaSdxlAuFwG8fWb95ntjakmXPQ==", null, false, 2, 2, "5b2ff256-bef7-4bd5-9365-bb3055158958", 8, false, "marko@marko.com" },
                    { "0b05f2d7-41aa-4ee1-a41c-dac43dfdb87b", 0, "d9a5f173-120e-46d3-ba41-59656aa784c9", "james@james.com", true, "James", "Kirk", false, null, "JAMES@JAMES.COM", "JAMES@JAMES.COM", "AQAAAAEAACcQAAAAEGpVke1xhMi/PRfUcHQbvaVbNjKh+uzxIn1avVTEVptXk5a0MwNe/C1cqtaos44ydg==", null, false, 3, 2, "25f2b386-7147-49eb-862d-fe6c840b0812", 7, false, "james@james.com" },
                    { "62b2147b-c2f2-48de-89e6-6aed4050737f", 0, "b30da9e4-7bb2-4c1d-92b1-d15b677c2ca4", "john@john.com", true, "John", "Miller", false, null, "JOHN@JOHN.COM", "JOHN@JOHN.COM", "AQAAAAEAACcQAAAAEE69b1hC5Jf8rGo3xdR06opS9yMjE0v6rVHD34DwUkWNB8aBypOFU6nBLuhP7LSCCQ==", null, false, 3, 2, "3bf008a8-8561-41cb-b33c-a22d08ebaac9", 6, false, "john@john.com" },
                    { "6186e7db-c20e-4184-afda-d7acda1b38c7", 0, "a4e2e87f-85b5-4a0d-a961-94feffe0fb2f", "carol@carol.com", true, "Carol", "Danvers", false, null, "CAROL@CAROL.COM", "CAROL@CAROL.COM", "AQAAAAEAACcQAAAAEN4SQTaFmA8/pSB3xYCC2zMgmeBjGH+X6dUmUNPomkzmJomFHTyed1ngX0snXWwqoA==", null, false, 5, 2, "aeda91fb-8f10-4493-996c-84b5fc7325d7", 5, false, "carol@carol.com" },
                    { "0b8b3a0c-fbd9-491e-a8c4-f400e0e0a121", 0, "29121ba3-6c02-4620-80a2-c158b35db0d2", "steve@steve.com", true, "Steve", "Rodgers", false, null, "STEVE@STEVE.COM", "STEVE@STEVE.COM", "AQAAAAEAACcQAAAAEGS18QhxZdiJfagAMzF7CyrvJcd25vZOxkGv63WrS4yaPbPor45NnGxDJO38atsEWA==", null, false, 4, 2, "dfac3e70-df55-46e2-b833-cfd1bb54c19d", 4, false, "steve@steve.com" },
                    { "8f266432-cb10-486b-97c8-8fe339426109", 0, "50f8095f-7cc9-4e14-b5fb-9aecc96b7701", "jack@jack.com", true, "Jack", "Sparrow", false, null, "JACK@JACK.COM", "JACK@JACK.COM", "AQAAAAEAACcQAAAAEIYYsI7U8SXOT6sg63qjpAYtwLRuI7qXySEclcS9WA/F0yhI4jdgA7V6i3YFdPVCnw==", null, false, 5, 2, "f4f2c07f-d0b2-463d-9c7a-574733b17bdc", 3, false, "jack@jack.com" },
                    { "82b1ff03-eb79-4527-9811-b7993160af3e", 0, "d5fefc13-d51d-4d65-928b-06adfa03ef0d", "bastion@bastion.com", true, "Bastion", "Schweinsteiger", false, null, "BASTION@BASTION.COM", "BASTION@BASTION.COM", "AQAAAAEAACcQAAAAEA/tgqsUHKnY4Mrdy5UewugtEObJ96osbnGUci4Jj5UQJpDgdHXaMB6CwOKYTcN1Yg==", null, false, 4, 1, "f8c39ead-3f56-4c6b-913d-67db2f524346", null, false, "bastion@bastion.com" },
                    { "c9b5a564-eb31-49b5-8e91-7f2adbf56d80", 0, "35bd07ed-195e-4176-b6a8-79024b687673", "thomas@thomas.com", true, "Thomas", "Muller", false, null, "THOMAS@THOMAS.COM", "THOMAS@THOMAS.COM", "AQAAAAEAACcQAAAAEJy0EBIcXjHBQQ2KSYS1Aejg/RCaTSwXXL/gvZSnjAxtNsQDzJrzKcQ8LP2gIcz73A==", null, false, 4, 1, "ee022a3a-82f3-4598-ba52-59ffbd31da91", null, false, "thomas@thomas.com" },
                    { "98a0d6f6-17d6-44ed-8c00-5bc71cd8bcb0", 0, "bbfcf0ee-1f42-4527-9529-946c3fec336b", "sergio@sergio.com", true, "Sergio", "Ramos", false, null, "SERGIO@SERGIO.COM", "SERGIO@SERGIO.COM", "AQAAAAEAACcQAAAAEBaQ0aTOXrEUAgyVTwHkqZQcvvMpRQkOsLRv9Wk3e7oUS8qW5SPRZlngb/LbWhUWqQ==", null, false, 3, 1, "df49187a-d6d2-4d44-9698-cf042a3913df", null, false, "sergio@sergio.com" },
                    { "2fa67c53-605b-4889-a3af-b1d00c5070ec", 0, "1d95a438-83bb-4424-b6e3-2b54833ad9ce", "cristiano@cristiano.com", true, "Cristiano", "Ronaldo", false, null, "CRISTIANO@CRISTIANO.COM", "CRISTIANO@CRISTIANO.COM", "AQAAAAEAACcQAAAAEKDDzBBmniOgQ4BPwfZieoqdInI+cNriC0frN2PEipCULH9ienCPQgbQvm/KNEzlxg==", null, false, 4, 1, "4722bff1-3527-4990-b3b4-d7918db46b30", null, false, "cristiano@cristiano.com" },
                    { "39523271-c006-46a0-bc53-e531322d0500", 0, "3c92e065-6460-4d38-b2ac-4ea0266c7c4e", "lionel@lionel.com", true, "Lionel", "Messi", false, null, "LIONEL@LIONEL.COM", "LIONEL@LIONEL.COM", "AQAAAAEAACcQAAAAENp38dt4KLPKzc/bmVLg1wkvxFHANN1vdgZTyZF07coIcZGNGk3wAUBK4/omWoYazw==", null, false, 5, 1, "5c076caf-ec3e-4b44-af12-572827b34eab", null, false, "lionel@lionel.com" },
                    { "44b7cbc1-f848-41bb-a6de-ab19bd985895", 0, "12079da0-69fd-41b5-916e-30d13a46bd85", "julia@julia.com", true, "Julia", "Players", false, null, "JULIA@JULIA.COM", "JULIA@JULIA.COM", "AQAAAAEAACcQAAAAEB76m4J60GnsTa+gUUXfUlT5bR1rn51DBYgnd5TYtdLSpq1zvHLoPZYOLnm0AiqL2A==", null, false, 5, 1, "debca76a-21c1-453a-a683-728cb6eb945d", null, false, "julia@julia.com" },
                    { "53f1ba03-0ee6-48ca-89ff-eee142296415", 0, "9fd5d7d0-16db-4751-a308-114efa4ed5e0", "will@will.com", true, "Will", "Captains", false, null, "WILL@WILL.COM", "WILL@WILL.COM", "AQAAAAEAACcQAAAAEIOjZUleFWFkDhpDJ4InlDpcOFZDK7GgIa58DR5HguI5QuZWfMpWrQ0pqPDD4cyp3Q==", null, false, 2, 2, "4461f143-d609-4254-8947-4997cdd4d419", 1, false, "will@will.com" },
                    { "1d72818d-8976-44ce-93a7-f47f9feea63d", 0, "3be19c49-de9f-4352-a894-347414bff2ba", "billy@billy.com", true, "Billy", "Captains", false, null, "BILLY@BILLY.COM", "BILLY@BILLY.COM", "AQAAAAEAACcQAAAAEGihmQrhz4CsJ494S38JVO2Fsm3A1WavIi/HO1977Iux0QnR+RGX2yAcf7CYjy5IwQ==", null, false, 2, 2, "46e0c5bb-0fc1-481a-b49a-99a35806601a", 2, false, "billy@billy.com" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Forward" },
                    { 4, "Midfielder" },
                    { 1, "No Preference" },
                    { 2, "Goalkeeper" },
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
                    { 9, "0a045a11-593d-421c-b073-415a6b0a7ab0", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6817), "Tornadoes" },
                    { 1, "53f1ba03-0ee6-48ca-89ff-eee142296415", new DateTime(2019, 5, 13, 9, 53, 41, 940, DateTimeKind.Local).AddTicks(4905), "Nashville SC" },
                    { 2, "1d72818d-8976-44ce-93a7-f47f9feea63d", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6782), "Junior Wombats" },
                    { 3, "8f266432-cb10-486b-97c8-8fe339426109", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6792), "Salty Pirates" },
                    { 4, "0b8b3a0c-fbd9-491e-a8c4-f400e0e0a121", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6796), "Earth's Mightiest Heroes" },
                    { 5, "6186e7db-c20e-4184-afda-d7acda1b38c7", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6803), "The New Avengers" },
                    { 6, "62b2147b-c2f2-48de-89e6-6aed4050737f", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6806), "101st Airborne" },
                    { 7, "0b05f2d7-41aa-4ee1-a41c-dac43dfdb87b", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6810), "Space Invaders" },
                    { 8, "114fa0b1-9ac0-443c-b9c2-c8c97d44cf31", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6813), "Red October" },
                    { 10, "e5a76361-c5f6-4ba1-a097-fd15b1eff8a4", new DateTime(2019, 5, 13, 9, 53, 41, 942, DateTimeKind.Local).AddTicks(6820), "Predators" }
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
