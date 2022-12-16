using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Categorieses",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 5, "Luxury" },
                    { 6, "Charter" }
                });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 22,
                column: "ImageUrlRouteGoogleMaps",
                value: "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600");

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 33,
                column: "ImageUrlRouteGoogleMaps",
                value: "https://bulgaria-infoguide.com/wp-content/uploads/2018/10/green-taxi-1024x768.jpg");

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 44,
                columns: new[] { "ImageUrlRouteGoogleMaps", "Title" },
                values: new object[] { "https://ekotaxi.bg/wp-content/uploads/2020/03/single_cab_redone-min-1-2048x1536.png", "OneWayLocal" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 55,
                columns: new[] { "ImageUrlRouteGoogleMaps", "Title" },
                values: new object[] { "https://content.fortune.com/wp-content/uploads/2014/09/170030873.jpg?resize=1200,600", "RoundTripLocal" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 11,
                columns: new[] { "CategoryId", "ImageUrlRouteGoogleMaps" },
                values: new object[] { 5, "https://le-cdn.hibuwebsites.com/8978d127e39b497da77df2a4b91f33eb/dms3rep/multi/opt/RSshutterstock_120889072-1920w.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorieses",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categorieses",
                keyColumn: "CategoryId",
                keyValue: 6);

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

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 11,
                columns: new[] { "CategoryId", "ImageUrlRouteGoogleMaps" },
                values: new object[] { 1, "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 22,
                column: "ImageUrlRouteGoogleMaps",
                value: "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0");

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 33,
                column: "ImageUrlRouteGoogleMaps",
                value: "https://www.google.com/maps/dir/Software+University,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%90%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%8A%D1%80+%D0%9C%D0%B0%D0%BB%D0%B8%D0%BD%D0%BE%D0%B2%E2%80%9C+78,+e%D1%82.+1,+1799+%D0%B2.%D0%B7.+%D0%90%D0%BC%D0%B5%D1%80%D0%B8%D0%BA%D0%B0%D0%BD%D1%81%D0%BA%D0%B8+%D0%BA%D0%BE%D0%BB%D0%B5%D0%B6,+%D0%A1%D0%BE%D1%84%D0%B8%D1%8F/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.3909117,23.5074334,9z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x40aa85cb55668ae1:0x447f9dd693e57def!2m2!1d23.3697846!2d42.6361915!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0");

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 44,
                columns: new[] { "ImageUrlRouteGoogleMaps", "Title" },
                values: new object[] { "https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.1462238,24.7489407,15.5z/data=!4m14!4m13!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!3e0", "Sared" });

            migrationBuilder.UpdateData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 55,
                columns: new[] { "ImageUrlRouteGoogleMaps", "Title" },
                values: new object[] { "https://www.google.com/maps/dir/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%90%D0%BD%D1%82%D0%B8%D1%87%D0%B5%D0%BD+%D1%82%D0%B5%D0%B0%D1%82%D1%8A%D1%80,+%D1%83%D0%BB%D0%B8%D1%86%D0%B0+%D0%A6%D0%B0%D1%80+%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/%D0%9C%D0%B0%D0%BB%D0%BA%D0%B0%D1%82%D0%B0+%D0%B1%D0%B0%D0%B7%D0%B8%D0%BB%D0%B8%D0%BA%D0%B0+%D1%81+%D0%B1%D0%B0%D0%BF%D1%82%D0%B8%D1%81%D1%82%D0%B5%D1%80%D0%B8%D0%B9+V+-+VI+%D0%B2.,+%D0%B1%D1%83%D0%BB.+%E2%80%9E%D0%9A%D0%BD%D1%8F%D0%B3%D0%B8%D0%BD%D1%8F+%D0%9C%D0%B0%D1%80%D0%B8%D1%8F+%D0%9B%D1%83%D0%B8%D0%B7%D0%B0%E2%80%9C+31,+4000+%D0%A6%D0%B5%D0%BD%D1%82%D1%8A%D1%80,+%D0%9F%D0%BB%D0%BE%D0%B2%D0%B4%D0%B8%D0%B2/@42.147763,24.751646,16z/data=!3m1!4b1!4m20!4m19!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!1m5!1m1!1s0x14acd1a346c61793:0xfac01f1ae582348c!2m2!1d24.7510692!2d42.1468859!1m5!1m1!1s0x14acd1a10fdb0a3b:0x63ec420e6020dc6d!2m2!1d24.7579536!2d42.1463245!3e0", "Sared" });
        }
    }
}
