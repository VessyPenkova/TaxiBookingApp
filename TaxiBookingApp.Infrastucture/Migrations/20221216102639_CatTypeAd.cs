using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class CatTypeAd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "TaxiRoutes",
                columns: new[] { "TaxiRouteId", "CategoryId", "DeliveryAddress", "Description", "DriverCarId", "ImageUrlRouteGoogleMaps", "IsActive", "OfficeId", "PickUpAddress", "Price", "RenterId", "Title" },
                values: new object[] { 66, 6, "Hartmann Road, London E16 2PX", "Wheather you want a tourist tour in Plovdiv, or simply buizness trip, this trip is will satisy your expectation with a luxary limousine", 1, "https://th.bing.com/th/id/R.4f634d4c26e3f1a1cda6459f649713d1?rik=GYIFZQe3lUWPJA&pid=ImgRaw&r=0", true, "1", "Krumovo 4009, Rodopi Municipality, Plovdiv District", 10.20m, "6d5800-d726-4fc8-83d9-d6b3ac1f581e", "Charter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f581e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84d7ae52-8ca9-4165-b9a5-e090c3e43910", "AQAAAAEAACcQAAAAEM9Bx0fNsZAE//RH/MUg26U492XoKm1NvOObsRXh/wA+hAOEl1DAOSjYLoNnLcAO4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839582",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd0f1cf2-91c0-4cec-bab0-44b15b133e66", "AQAAAAEAACcQAAAAEPpCGYd8kSN2ULExZ/rF94k41YZ4IlmCs0WnFCSRFi6qtXIKgsg/9GICvfwqBQdMmA==" });
        }
    }
}
