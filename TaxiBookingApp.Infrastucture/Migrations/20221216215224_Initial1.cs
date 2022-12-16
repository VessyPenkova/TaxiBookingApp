using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class Initial1 : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OfficeImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
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
                    TaxiRouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PickUpAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrlRouteGoogleMaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "money", precision: 18, scale: 2, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DriverCarId = table.Column<int>(type: "int", nullable: false),
                    RenterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxiRoutes", x => x.TaxiRouteId);
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
                    table.ForeignKey(
                        name: "FK_TaxiRoutes_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800-d726-4fc8-83d9-d6b3ac1f582e", 0, "37b9f78e-eb21-4d4e-838b-d93549f534bc", "guest@mail.com", false, null, true, null, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEBperbJ1O9FKWh1TrAgHcAsh10YbhHzWYSdjEuhsgh6ibuZ0LS6vGrwMrHQhr3W5XQ==", null, false, null, false, "guest@mail.com" },
                    { "dea1286-c198-4129-b3f3-b89d839581", 0, "3b893d31-88aa-4bc1-8c1f-d3afde4301b1", "agent@mail.com", false, null, true, null, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEDLMtuzNYC7WbYEz/Uh1wpQxMNMKhTDo4SIUwpRdScFFv+LGebA9KKgVGAS0h20pqw==", null, false, null, false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categorieses",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "InerCitySingle" },
                    { 2, "InerCityShared" },
                    { 3, "OneWayLocal" },
                    { 4, "RoundTripLocal" },
                    { 5, "Luxury" },
                    { 6, "Charter" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "City", "Country", "IsActive", "OfficeImageUrl", "Phone" },
                values: new object[,]
                {
                    { "1", "Plovdiv", "Bulgaria", true, "https://media.istockphoto.com/photos/outside-view-of-a-office-building-with-blue-windows-picture-id157439187", "0035932111111" },
                    { "2", "Plovdiv", "Sofia", true, "https://th.bing.com/th/id/R.ea2068b541126d4df2a90dda8af3a849?rik=R7U0u2Gyiwjx6g&riu=http%3a%2f%2fwww.theboutiqueoffice.com%2fwp-content%2fuploads%2f2015%2f04%2fAked-Esplanad-For-Rent-in-Bukit-Jalil-03.png&ehk=4yTgJ6%2ftN%2f8PkOiP%2fsuwRbu2Qse0NDJ6p5QeCndFGeY%3d&risl=&pid=ImgRaw&r=0", "0035932111111" },
                    { "3", "Wien", "Austria", true, "https://www.s2architecture.com/uploads/gallery/Truman-Office-Building/02.jpg", "00431111111" },
                    { "4", "Paris", "France", true, "https://th.bing.com/th/id/R.71dc3e07a5b246f95b10290d63d07d76?rik=Evh2RFKPJOVltA&riu=http%3a%2f%2fwww.buildingbutler.com%2fimages%2fgallery%2flarge%2fbuilding-facades-3463-13832.jpg&ehk=DVp9ap9ScbrjzkKQi9SLz9RYrm82XS8RqsUgwYwmmSw%3d&risl=&pid=ImgRaw&r=0", "00336111111" }
                });

            migrationBuilder.InsertData(
                table: "DriversCars",
                columns: new[] { "DriverCarId", "PhoneNumber", "UserId" },
                values: new object[] { 1, "00359123456", "dea1286-c198-4129-b3f3-b89d839581" });

            migrationBuilder.InsertData(
                table: "TaxiRoutes",
                columns: new[] { "TaxiRouteId", "CategoryId", "DeliveryAddress", "Description", "DriverCarId", "ImageUrlRouteGoogleMaps", "IsActive", "OfficeId", "PickUpAddress", "Price", "RenterId", "Title" },
                values: new object[,]
                {
                    { 11, 5, "Bulgaria, Sofia, Bul, Alexander malinov, 78", "Wheather you want a tourist tour from Plovdiv to Sofia, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://le-cdn.hibuwebsites.com/8978d127e39b497da77df2a4b91f33eb/dms3rep/multi/opt/RSshutterstock_120889072-1920w.jpg", true, "1", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 316.80m, "6d5800-d726-4fc8-83d9-d6b3ac1f582e", "Pivate Luxury" },
                    { 22, 2, "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600", true, "2", "Bulgaria, Sofia, Bul, Alexander malinov, 78", 316.80m, null, "Sared" },
                    { 33, 2, "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", "Wheather you want a tourist tour from Sofia to Plovdiv, or simply buizness trip, this trip is private with a luxary limousine", 1, "https://bulgaria-infoguide.com/wp-content/uploads/2018/10/green-taxi-1024x768.jpg", true, "2", "Bulgaria, Sofia, Bul, Alexander malinov, 78", 158.40m, null, "Sared with One" },
                    { 44, 3, "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://ekotaxi.bg/wp-content/uploads/2020/03/single_cab_redone-min-1-2048x1536.png", true, "1", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 6.20m, null, "OneWayLocal" },
                    { 55, 4, "Antique Theartre, str. Tsar Ivaylo 4, Plovdiv, Bulgaria", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600", true, "1", "Bulgaria, Plovdiv, Bul.Kniyaginya Maria Luiza, 31", 10.20m, null, "RoundTripLocal" },
                    { 66, 6, "Hartmann Road, London E16 2PX", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://th.bing.com/th/id/R.4f634d4c26e3f1a1cda6459f649713d1?rik=GYIFZQe3lUWPJA&pid=ImgRaw&r=0", true, "1", "Krumovo 4009, Rodopi Municipality, Plovdiv District", 10.20m, null, "Charter" }
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
                name: "IX_TaxiRoutes_OfficeId",
                table: "TaxiRoutes",
                column: "OfficeId");

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
                name: "Offices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
