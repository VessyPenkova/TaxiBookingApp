using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class intl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "df3faae0-d61b-40ca-a766-a6fb450dc2c8", "AQAAAAEAACcQAAAAEMud+E8VRvjo3CZKpMwMH/ow/LgW6fupk6scclOiuJq7gmffZuuiRCPVf+QhZhZ+MA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b66aa19a-2167-4c48-8cb0-4ea5804b3b66", "AQAAAAEAACcQAAAAEELr/qjUc+mBJywCXGIdtQ9duITeqVIh6Qy3y0cnZbKJKKvl+JjOP3IgpwwKb5OfWw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d00501b-2147-4487-bcf1-0c92fb14a940", "AQAAAAEAACcQAAAAECx3FjlRG+T74tSVH6RdyOuGFIzt+YL/Mk0pXObtdgSUqS4+BlLb4fdP+LQR6iLb8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e1aa0646-412e-4e13-94c4-7a6775b5f562", "AQAAAAEAACcQAAAAEJUgbm+0eOQANenTkE5Ex28HbWmzu7XKkyrF4sCFMBPhEdnj2IXwwyL97+ommz0xvg==" });
        }
    }
}
