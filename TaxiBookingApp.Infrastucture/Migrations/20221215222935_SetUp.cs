using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class SetUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxiRoutId",
                table: "TaxiRoutes",
                newName: "TaxiRouteId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TaxiRoutes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OfficeId",
                table: "TaxiRoutes",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8856dba4-6621-44f7-bc4e-a213f50a4047", true, "AQAAAAEAACcQAAAAEBZMqn7epduUQqe2SXZDu8osHdEPapsZVzC5wlwmtXW/nfzvRPM3mje70R4lkoEDZg==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce9c21a-9565-43d6-9ebe-dc4876ffb617", true, "AQAAAAEAACcQAAAAEI2XI65QWN7SZ7Y6NMrtVIIJu3fr9P+1dzJDV60IxNCLQ/GlBmL8T6uE7kVfbQZVQw==", null });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "City", "Country", "IsActive", "Phone" },
                values: new object[,]
                {
                    { "1", "Plovdiv", "Bulgaria", true, "0035932111111" },
                    { "2", "Plovdiv", "Sofia", true, "0035932111111" },
                    { "3", "Wien", "Austria", true, "00431111111" },
                    { "4", "Paris", "France", true, "00336111111" }
                });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 11,
                columns: new[] { "IsActive", "OfficeId" },
                values: new object[] { true, "1" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 22,
                columns: new[] { "IsActive", "OfficeId" },
                values: new object[] { true, "2" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 33,
                columns: new[] { "IsActive", "OfficeId" },
                values: new object[] { true, "2" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 44,
                columns: new[] { "IsActive", "OfficeId" },
                values: new object[] { true, "1" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 55,
                columns: new[] { "IsActive", "OfficeId" },
                values: new object[] { true, "1" });

            migrationBuilder.CreateIndex(
                name: "IX_TaxiRoutes_OfficeId",
                table: "TaxiRoutes",
                column: "OfficeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaxiRoutes_Offices_OfficeId",
                table: "TaxiRoutes",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "OfficeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaxiRoutes_Offices_OfficeId",
                table: "TaxiRoutes");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_TaxiRoutes_OfficeId",
                table: "TaxiRoutes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TaxiRoutes");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "TaxiRoutes");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TaxiRouteId",
                table: "TaxiRoutes",
                newName: "TaxiRoutId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a88a383a-612c-4b11-a9ef-41816667d2f4", "AQAAAAEAACcQAAAAENiC3kxSv4Q7LtADtGo0iI+yyd32dGJpbHp78yzVkWabn5nI647uBd7NOMhGZ5pHqQ==", "a304d0c6-cfbd-44ca-871e-7d1c1dcf6929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d847b66-7b3f-4254-9339-21edeb514e19", "AQAAAAEAACcQAAAAEJOg8dc846QHInVx5hWRa7+OwEy9/iBjuX4NW9E0FyMiJquo9d3EbBb0gxAs2eOBtA==", "83bfcb6f-b232-40d9-b8ba-5d4dfb48c4ab" });
        }
    }
}
