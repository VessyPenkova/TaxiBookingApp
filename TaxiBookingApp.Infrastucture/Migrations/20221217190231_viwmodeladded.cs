using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxiBookingApp.Infrastucture.Migrations
{
    public partial class viwmodeladded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TaxiRoutes",
                keyColumn: "TaxiRouteId",
                keyValue: 66);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35475500-221e-4dad-a2e3-de235f275d89", "AQAAAAEAACcQAAAAEKyHPjydqOYOP46sJFZBAHhS3MB4dzT2+TU4/6TjoIjerXjCTX0dUprUrVI9LR2zAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82eb3b53-d872-435e-94b4-2734d701ddf3", "AQAAAAEAACcQAAAAEPH1d3mB7OaRkWgE/Id+zW7GzrC3NGYDOz78z6qtS6PMENLRgaK33rMt5/tKOwAqZQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800-d726-4fc8-83d9-d6b3ac1f582e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37b9f78e-eb21-4d4e-838b-d93549f534bc", "AQAAAAEAACcQAAAAEBperbJ1O9FKWh1TrAgHcAsh10YbhHzWYSdjEuhsgh6ibuZ0LS6vGrwMrHQhr3W5XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea1286-c198-4129-b3f3-b89d839581",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b893d31-88aa-4bc1-8c1f-d3afde4301b1", "AQAAAAEAACcQAAAAEDLMtuzNYC7WbYEz/Uh1wpQxMNMKhTDo4SIUwpRdScFFv+LGebA9KKgVGAS0h20pqw==" });

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
        }
    }
}
