using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class isactivtrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afb139b3-79a1-4a16-9239-5dd5ad73c51b", "AQAAAAEAACcQAAAAECLLPa+NW0Ix+5ANUL+0BvuQ0PVZSLwAUO9T9+eyBkRI4xDVLfSJ2xQExPbE653yug==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eda754ed-ad1f-42e2-b4d7-d8fc2673ffb3", "AQAAAAEAACcQAAAAELuS5b8ml3i5P4TfkMtUr+5FHMEL+ySh9RmNIJ4hlXRfD7tGtem6m9MJXTgdYEOpIA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8856dba4-6621-44f7-bc4e-a213f50a4047", "AQAAAAEAACcQAAAAEBZMqn7epduUQqe2SXZDu8osHdEPapsZVzC5wlwmtXW/nfzvRPM3mje70R4lkoEDZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce9c21a-9565-43d6-9ebe-dc4876ffb617", "AQAAAAEAACcQAAAAEI2XI65QWN7SZ7Y6NMrtVIIJu3fr9P+1dzJDV60IxNCLQ/GlBmL8T6uE7kVfbQZVQw==" });
        }
    }
}
