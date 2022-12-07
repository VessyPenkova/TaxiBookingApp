using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79615578-b7b0-4c17-a979-994a4ad650aa", "AQAAAAEAACcQAAAAEMdLQLduLiwYyi/elJR9QZmwS77q4eR/Uzmw+3sAc4uC34JyUzeue5Z468hGGi9NPw==", "92ad5232-b49a-47f2-914b-d557aa0a6664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c17df48b-f25a-4776-bac7-d6552da4387e", "AQAAAAEAACcQAAAAEC+c1spLZQjwURMRjUEx72NDBLB77j/IhjXSeI9ZiEABb81FWeAef4eYhy57xC5Jqw==", "93fb775a-3bce-499e-91fc-adda48cd6240" });
        }
    }
}
