using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGameStore.Migrations
{
    /// <inheritdoc />
    public partial class MultiStoreSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jan", "Janssens" });

            migrationBuilder.UpdateData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Number", "Street" },
                values: new object[] { "Store 1", "3A", "StoreStreet" });

            migrationBuilder.InsertData(
                schema: "Store",
                table: "tblStores",
                columns: new[] { "Id", "Addition", "Place", "IsFranchiseStore", "Name", "Number", "Street", "Zipcode" },
                values: new object[,]
                {
                    { -101, "", "Antwerp", false, "Store 101", "303A", "StoreStreet", "2000" },
                    { -100, "", "Antwerp", false, "Store 100", "300A", "StoreStreet", "2000" },
                    { -99, "", "Antwerp", false, "Store 99", "297A", "StoreStreet", "2000" },
                    { -98, "", "Antwerp", false, "Store 98", "294A", "StoreStreet", "2000" },
                    { -97, "", "Antwerp", false, "Store 97", "291A", "StoreStreet", "2000" },
                    { -96, "", "Antwerp", false, "Store 96", "288A", "StoreStreet", "2000" },
                    { -95, "", "Antwerp", false, "Store 95", "285A", "StoreStreet", "2000" },
                    { -94, "", "Antwerp", false, "Store 94", "282A", "StoreStreet", "2000" },
                    { -93, "", "Antwerp", false, "Store 93", "279A", "StoreStreet", "2000" },
                    { -92, "", "Antwerp", false, "Store 92", "276A", "StoreStreet", "2000" },
                    { -91, "", "Antwerp", false, "Store 91", "273A", "StoreStreet", "2000" },
                    { -90, "", "Antwerp", false, "Store 90", "270A", "StoreStreet", "2000" },
                    { -89, "", "Antwerp", false, "Store 89", "267A", "StoreStreet", "2000" },
                    { -88, "", "Antwerp", false, "Store 88", "264A", "StoreStreet", "2000" },
                    { -87, "", "Antwerp", false, "Store 87", "261A", "StoreStreet", "2000" },
                    { -86, "", "Antwerp", false, "Store 86", "258A", "StoreStreet", "2000" },
                    { -85, "", "Antwerp", false, "Store 85", "255A", "StoreStreet", "2000" },
                    { -84, "", "Antwerp", false, "Store 84", "252A", "StoreStreet", "2000" },
                    { -83, "", "Antwerp", false, "Store 83", "249A", "StoreStreet", "2000" },
                    { -82, "", "Antwerp", false, "Store 82", "246A", "StoreStreet", "2000" },
                    { -81, "", "Antwerp", false, "Store 81", "243A", "StoreStreet", "2000" },
                    { -80, "", "Antwerp", false, "Store 80", "240A", "StoreStreet", "2000" },
                    { -79, "", "Antwerp", false, "Store 79", "237A", "StoreStreet", "2000" },
                    { -78, "", "Antwerp", false, "Store 78", "234A", "StoreStreet", "2000" },
                    { -77, "", "Antwerp", false, "Store 77", "231A", "StoreStreet", "2000" },
                    { -76, "", "Antwerp", false, "Store 76", "228A", "StoreStreet", "2000" },
                    { -75, "", "Antwerp", false, "Store 75", "225A", "StoreStreet", "2000" },
                    { -74, "", "Antwerp", false, "Store 74", "222A", "StoreStreet", "2000" },
                    { -73, "", "Antwerp", false, "Store 73", "219A", "StoreStreet", "2000" },
                    { -72, "", "Antwerp", false, "Store 72", "216A", "StoreStreet", "2000" },
                    { -71, "", "Antwerp", false, "Store 71", "213A", "StoreStreet", "2000" },
                    { -70, "", "Antwerp", false, "Store 70", "210A", "StoreStreet", "2000" },
                    { -69, "", "Antwerp", false, "Store 69", "207A", "StoreStreet", "2000" },
                    { -68, "", "Antwerp", false, "Store 68", "204A", "StoreStreet", "2000" },
                    { -67, "", "Antwerp", false, "Store 67", "201A", "StoreStreet", "2000" },
                    { -66, "", "Antwerp", false, "Store 66", "198A", "StoreStreet", "2000" },
                    { -65, "", "Antwerp", false, "Store 65", "195A", "StoreStreet", "2000" },
                    { -64, "", "Antwerp", false, "Store 64", "192A", "StoreStreet", "2000" },
                    { -63, "", "Antwerp", false, "Store 63", "189A", "StoreStreet", "2000" },
                    { -62, "", "Antwerp", false, "Store 62", "186A", "StoreStreet", "2000" },
                    { -61, "", "Antwerp", false, "Store 61", "183A", "StoreStreet", "2000" },
                    { -60, "", "Antwerp", false, "Store 60", "180A", "StoreStreet", "2000" },
                    { -59, "", "Antwerp", false, "Store 59", "177A", "StoreStreet", "2000" },
                    { -58, "", "Antwerp", false, "Store 58", "174A", "StoreStreet", "2000" },
                    { -57, "", "Antwerp", false, "Store 57", "171A", "StoreStreet", "2000" },
                    { -56, "", "Antwerp", false, "Store 56", "168A", "StoreStreet", "2000" },
                    { -55, "", "Antwerp", false, "Store 55", "165A", "StoreStreet", "2000" },
                    { -54, "", "Antwerp", false, "Store 54", "162A", "StoreStreet", "2000" },
                    { -53, "", "Antwerp", false, "Store 53", "159A", "StoreStreet", "2000" },
                    { -52, "", "Antwerp", false, "Store 52", "156A", "StoreStreet", "2000" },
                    { -51, "", "Antwerp", false, "Store 51", "153A", "StoreStreet", "2000" },
                    { -50, "", "Antwerp", false, "Store 50", "150A", "StoreStreet", "2000" },
                    { -49, "", "Antwerp", false, "Store 49", "147A", "StoreStreet", "2000" },
                    { -48, "", "Antwerp", false, "Store 48", "144A", "StoreStreet", "2000" },
                    { -47, "", "Antwerp", false, "Store 47", "141A", "StoreStreet", "2000" },
                    { -46, "", "Antwerp", false, "Store 46", "138A", "StoreStreet", "2000" },
                    { -45, "", "Antwerp", false, "Store 45", "135A", "StoreStreet", "2000" },
                    { -44, "", "Antwerp", false, "Store 44", "132A", "StoreStreet", "2000" },
                    { -43, "", "Antwerp", false, "Store 43", "129A", "StoreStreet", "2000" },
                    { -42, "", "Antwerp", false, "Store 42", "126A", "StoreStreet", "2000" },
                    { -41, "", "Antwerp", false, "Store 41", "123A", "StoreStreet", "2000" },
                    { -40, "", "Antwerp", false, "Store 40", "120A", "StoreStreet", "2000" },
                    { -39, "", "Antwerp", false, "Store 39", "117A", "StoreStreet", "2000" },
                    { -38, "", "Antwerp", false, "Store 38", "114A", "StoreStreet", "2000" },
                    { -37, "", "Antwerp", false, "Store 37", "111A", "StoreStreet", "2000" },
                    { -36, "", "Antwerp", false, "Store 36", "108A", "StoreStreet", "2000" },
                    { -35, "", "Antwerp", false, "Store 35", "105A", "StoreStreet", "2000" },
                    { -34, "", "Antwerp", false, "Store 34", "102A", "StoreStreet", "2000" },
                    { -33, "", "Antwerp", false, "Store 33", "99A", "StoreStreet", "2000" },
                    { -32, "", "Antwerp", false, "Store 32", "96A", "StoreStreet", "2000" },
                    { -31, "", "Antwerp", false, "Store 31", "93A", "StoreStreet", "2000" },
                    { -30, "", "Antwerp", false, "Store 30", "90A", "StoreStreet", "2000" },
                    { -29, "", "Antwerp", false, "Store 29", "87A", "StoreStreet", "2000" },
                    { -28, "", "Antwerp", false, "Store 28", "84A", "StoreStreet", "2000" },
                    { -27, "", "Antwerp", false, "Store 27", "81A", "StoreStreet", "2000" },
                    { -26, "", "Antwerp", false, "Store 26", "78A", "StoreStreet", "2000" },
                    { -25, "", "Antwerp", false, "Store 25", "75A", "StoreStreet", "2000" },
                    { -24, "", "Antwerp", false, "Store 24", "72A", "StoreStreet", "2000" },
                    { -23, "", "Antwerp", false, "Store 23", "69A", "StoreStreet", "2000" },
                    { -22, "", "Antwerp", false, "Store 22", "66A", "StoreStreet", "2000" },
                    { -21, "", "Antwerp", false, "Store 21", "63A", "StoreStreet", "2000" },
                    { -20, "", "Antwerp", false, "Store 20", "60A", "StoreStreet", "2000" },
                    { -19, "", "Antwerp", false, "Store 19", "57A", "StoreStreet", "2000" },
                    { -18, "", "Antwerp", false, "Store 18", "54A", "StoreStreet", "2000" },
                    { -17, "", "Antwerp", false, "Store 17", "51A", "StoreStreet", "2000" },
                    { -16, "", "Antwerp", false, "Store 16", "48A", "StoreStreet", "2000" },
                    { -15, "", "Antwerp", false, "Store 15", "45A", "StoreStreet", "2000" },
                    { -14, "", "Antwerp", false, "Store 14", "42A", "StoreStreet", "2000" },
                    { -13, "", "Antwerp", false, "Store 13", "39A", "StoreStreet", "2000" },
                    { -12, "", "Antwerp", false, "Store 12", "36A", "StoreStreet", "2000" },
                    { -11, "", "Antwerp", false, "Store 11", "33A", "StoreStreet", "2000" },
                    { -10, "", "Antwerp", false, "Store 10", "30A", "StoreStreet", "2000" },
                    { -9, "", "Antwerp", false, "Store 9", "27A", "StoreStreet", "2000" },
                    { -8, "", "Antwerp", false, "Store 8", "24A", "StoreStreet", "2000" },
                    { -7, "", "Antwerp", false, "Store 7", "21A", "StoreStreet", "2000" },
                    { -6, "", "Antwerp", false, "Store 6", "18A", "StoreStreet", "2000" },
                    { -5, "", "Antwerp", false, "Store 5", "15A", "StoreStreet", "2000" },
                    { -4, "", "Antwerp", false, "Store 4", "12A", "StoreStreet", "2000" },
                    { -3, "", "Antwerp", false, "Store 3", "9A", "StoreStreet", "2000" },
                    { -2, "", "Antwerp", false, "Store 2", "6A", "StoreStreet", "2000" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sven", "Mariën" });

            migrationBuilder.UpdateData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Name", "Number", "Street" },
                values: new object[] { "ABC", "10A", "Ellerman" });
        }
    }
}
