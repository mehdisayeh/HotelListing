using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 1, "Morocco", "MA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 2, "France", "FR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 3, "United States", "USA" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Adress", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 7, "Hay Riad Street 123, Rabat", 1, "Ornate Resort & Spa", 4.9000000000000004 },
                    { 1, "8867 Newcastle Street Deerfield Beach, Nice", 2, "Twin Keep Hotel & Spa", 4.7999999999999998 },
                    { 5, "7583 Railroad Avenue Suite 8 Roselle, Pa", 2, "Brass Cosmos Hotel", 4.2999999999999998 },
                    { 2, "924 Carson St. Odenton, MD 21113", 3, "Regal Mill Resort & Sp", 4.7000000000000002 },
                    { 3, "82 Main St. Brownsburg, IN 46112", 3, "Mellow Forest Hotel & Spa", 4.5 },
                    { 4, "7270 Pennsylvania Street Fort Wayne, IN 46804", 3, "Pacific Courtyard Hotel & Spa", 4.5999999999999996 },
                    { 6, "9 Andover Ave. Warminster, PA 18974", 3, "Sunny Emperor Resort & Spa", 3.8999999999999999 },
                    { 8, "444 North Lookout St. Fort Worth, TX 76110", 3, "Epitome Hotel", 4.7999999999999998 },
                    { 9, "4 Second Ave. Clifton Park, NY 12065", 3, "Opportunity Hotel", 4.5999999999999996 },
                    { 10, "7614 James Street Largo, FL 33771", 3, "Nature Hotel & Spa", 4.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
