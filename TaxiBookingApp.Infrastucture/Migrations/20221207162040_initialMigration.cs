using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorieses",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorieses", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "DriversCars",
                columns: table => new
                {
                    DriverCarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversCars", x => x.DriverCarId);
                    table.ForeignKey(
                        name: "FK_DriversCars_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxiRoutes",
                columns: table => new
                {
                    TaxiRoutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PickUpAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrlRouteGoogleMaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", precision: 18, scale: 2, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DriverCarId = table.Column<int>(type: "int", nullable: false),
                    RenterId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxiRoutes", x => x.TaxiRoutId);
                    table.ForeignKey(
                        name: "FK_TaxiRoutes_AspNetUsers_RenterId",
                        column: x => x.RenterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaxiRoutes_Categorieses_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorieses",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaxiRoutes_DriversCars_DriverCarId",
                        column: x => x.DriverCarId,
                        principalTable: "DriversCars",
                        principalColumn: "DriverCarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800-d726-4fc8-83d9-d6b3ac1f581e", 0, "79615578-b7b0-4c17-a979-994a4ad650aa", "guest@mail.com", false, false, null, "GUEST@MAIL.COM", "GUEST@MAIL.COM", "AQAAAAEAACcQAAAAEMdLQLduLiwYyi/elJR9QZmwS77q4eR/Uzmw+3sAc4uC34JyUzeue5Z468hGGi9NPw==", null, false, "92ad5232-b49a-47f2-914b-d557aa0a6664", false, "guest@mail.com" },
                    { "dea1286-c198-4129-b3f3-b89d839582", 0, "c17df48b-f25a-4776-bac7-d6552da4387e", "agent@mail.com", false, false, null, "AGENT@MAIL.COM", "AGENT@MAIL.COM", "AQAAAAEAACcQAAAAEC+c1spLZQjwURMRjUEx72NDBLB77j/IhjXSeI9ZiEABb81FWeAef4eYhy57xC5Jqw==", null, false, "93fb775a-3bce-499e-91fc-adda48cd6240", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categorieses",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "InerCitySingle" },
                    { 2, "InerCityShared" },
                    { 3, "OneWayLocal" },
                    { 4, "RoundTripLocal" }
                });

            migrationBuilder.InsertData(
                table: "DriversCars",
                columns: new[] { "DriverCarId", "PhoneNumber", "UserId" },
                values: new object[] { 1, "00359123456", "dea1286-c198-4129-b3f3-b89d839582" });

            migrationBuilder.InsertData(
                table: "TaxiRoutes",
                columns: new[] { "TaxiRoutId", "CategoryId", "DeliveryAddress", "Description", "DriverCarId", "ImageUrlRouteGoogleMaps", "PickUpAddress", "Price", "RenterId", "Title" },
                values: new object[,]
                {
                    { 11, 1, "Bulgaria, Sofia, Bul, Alexander malinov, 78", "Wheather you want a tourist tour from Plovdiv to Sofia, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 316.80m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Pivate Luxury" },
                    { 22, 2, "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0", "Bulgaria, Sofia, Bul, Alexander malinov, 78", 316.80m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Sared" },
                    { 33, 2, "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0", "Bulgaria, Sofia, Bul, Alexander malinov, 78", 158.40m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Sared with One" },
                    { 44, 3, "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.1462238,24.7489407,15.5z/data=!4m14!4m13!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!3e0", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 6.20m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Sared" },
                    { 55, 4, "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.147763,24.751646,16z/data=!3m1!4b1!4m20!4m19!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 10.20m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Sared" }
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

            migrationBuilder.CreateIndex(
                name: "IX_DriversCars_UserId",
                table: "DriversCars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxiRoutes_CategoryId",
                table: "TaxiRoutes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxiRoutes_DriverCarId",
                table: "TaxiRoutes",
                column: "DriverCarId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxiRoutes_RenterId",
                table: "TaxiRoutes",
                column: "RenterId");
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
                name: "TaxiRoutes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categorieses");

            migrationBuilder.DropTable(
                name: "DriversCars");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
