using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AP.MyGameStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.CreateTable(
                name: "tblStores",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFranchiseStore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPeople",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPeople_tblStores_EmployerId",
                        column: x => x.EmployerId,
                        principalSchema: "Store",
                        principalTable: "tblStores",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Store",
                table: "tblStores",
                columns: new[] { "Id", "Addition", "City", "IsFranchiseStore", "Name", "Number", "Street", "Zipcode" },
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
                    { -2, "", "Antwerp", false, "Store 2", "6A", "StoreStreet", "2000" },
                    { -1, "", "Antwerp", false, "Store 1", "3A", "StoreStreet", "2000" }
                });

            migrationBuilder.InsertData(
                schema: "Store",
                table: "tblPeople",
                columns: new[] { "Id", "BirthDate", "Email", "EmployerId", "FirstName", "Gender", "LastName", "MobilePhone" },
                values: new object[,]
                {
                    { -100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kolby.Morar76@hotmail.com", -36, "Darin", 0, "Yundt", null },
                    { -99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roderick.Mayert@gmail.com", -60, "Allan", 0, "Armstrong", null },
                    { -98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hailie_Wilderman@yahoo.com", -10, "Colin", 0, "Quitzon", null },
                    { -97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurence.Sauer66@gmail.com", -70, "Amy", 1, "Hirthe", null },
                    { -96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garnet_Dickens@yahoo.com", -6, "Ethel", 1, "Douglas", null },
                    { -95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosamond_Glover83@yahoo.com", -39, "Andre", 0, "McCullough", null },
                    { -94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lelah_Johnson85@gmail.com", -34, "Rachael", 1, "Harvey", null },
                    { -93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mateo60@gmail.com", -49, "Christina", 1, "Orn", null },
                    { -92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holly99@yahoo.com", -31, "Luis", 0, "Strosin", null },
                    { -91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrie.Kovacek@hotmail.com", -7, "Christian", 0, "Kilback", null },
                    { -90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Destin.Hahn70@hotmail.com", -73, "Cynthia", 1, "Abbott", null },
                    { -89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jordy_Reichert@gmail.com", -91, "Adam", 0, "Rodriguez", null },
                    { -88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Opal_Gutkowski@yahoo.com", -16, "Casey", 0, "Roob", null },
                    { -87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abdiel.Emard98@gmail.com", -80, "Jean", 0, "Veum", null },
                    { -86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oceane49@hotmail.com", -97, "Veronica", 1, "Koch", null },
                    { -85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melany16@yahoo.com", -56, "Mindy", 1, "Purdy", null },
                    { -84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laurence32@yahoo.com", -12, "Wilson", 0, "Sipes", null },
                    { -83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anastasia.Watsica16@gmail.com", -26, "Kristi", 1, "Padberg", null },
                    { -82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane.Donnelly@yahoo.com", -98, "Mitchell", 0, "Marquardt", null },
                    { -81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leila14@yahoo.com", -93, "Olive", 1, "Waelchi", null },
                    { -80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willy19@gmail.com", -22, "Marianne", 1, "Altenwerth", null },
                    { -79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keshaun6@hotmail.com", -28, "Margaret", 1, "Towne", null },
                    { -78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel.Corwin79@hotmail.com", -79, "Josh", 0, "Windler", null },
                    { -77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacky54@gmail.com", -4, "Gladys", 1, "Mayert", null },
                    { -76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maurice.Lehner@yahoo.com", -36, "Armando", 0, "Bauch", null },
                    { -75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brendon69@gmail.com", -56, "Jessie", 0, "Hettinger", null },
                    { -74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Connie.Labadie53@hotmail.com", -71, "Dorothy", 1, "Hudson", null },
                    { -73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consuelo.Pouros71@hotmail.com", -98, "Jana", 1, "Raynor", null },
                    { -72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane.Doyle@yahoo.com", -91, "Gayle", 1, "Barrows", null },
                    { -71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bertrand.Herzog98@gmail.com", -84, "Christopher", 0, "O'Connell", null },
                    { -70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jerome75@gmail.com", -48, "Daniel", 0, "Schultz", null },
                    { -69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam_Reynolds@hotmail.com", -84, "Ruth", 1, "Hickle", null },
                    { -68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milan77@gmail.com", -80, "Edith", 1, "Steuber", null },
                    { -67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandt59@gmail.com", -48, "Andrea", 1, "Brown", null },
                    { -66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keely79@yahoo.com", -18, "Brent", 0, "Hintz", null },
                    { -65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocio_Rowe40@hotmail.com", -42, "Beth", 1, "Luettgen", null },
                    { -64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norma_Crooks76@hotmail.com", -92, "Lee", 0, "Klocko", null },
                    { -63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armand35@yahoo.com", -71, "Vanessa", 1, "Skiles", null },
                    { -62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ken_Collins@hotmail.com", -69, "Jeanette", 1, "Kiehn", null },
                    { -61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessika16@yahoo.com", -100, "Milton", 0, "Beer", null },
                    { -60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hardy_Stanton@gmail.com", -3, "Lee", 0, "Johns", null },
                    { -59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aurelio.Jenkins80@yahoo.com", -80, "Lila", 1, "Bernier", null },
                    { -58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julie.Skiles21@yahoo.com", -47, "Jody", 0, "Wunsch", null },
                    { -57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ericka79@hotmail.com", -29, "Jan", 0, "Upton", null },
                    { -56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orville_Klein27@hotmail.com", -45, "Rudy", 0, "Reynolds", null },
                    { -55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dovie.Fahey68@gmail.com", -66, "Anna", 1, "Gibson", null },
                    { -54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fredy_Schroeder@yahoo.com", -85, "Annie", 1, "Thiel", null },
                    { -53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grayce89@gmail.com", -12, "Julia", 1, "Cartwright", null },
                    { -52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleora_Boyer23@yahoo.com", -79, "Edmund", 0, "Streich", null },
                    { -51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiara.Rolfson58@gmail.com", -45, "Norma", 1, "Reichert", null },
                    { -50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lavinia.Legros@yahoo.com", -71, "Belinda", 1, "Hackett", null },
                    { -49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bulah58@yahoo.com", -11, "Kimberly", 1, "Heller", null },
                    { -48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isac_VonRueden@yahoo.com", -62, "Ramona", 1, "Witting", null },
                    { -47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cathryn_Green99@hotmail.com", -100, "Veronica", 1, "Kunze", null },
                    { -46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rickie72@gmail.com", -94, "Roderick", 0, "Leannon", null },
                    { -45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacinthe59@hotmail.com", -32, "Darla", 1, "Nicolas", null },
                    { -44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kitty_Kovacek@gmail.com", -48, "Jim", 0, "Gibson", null },
                    { -43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Queenie6@gmail.com", -61, "Jonathan", 0, "Bayer", null },
                    { -42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Krystal53@hotmail.com", -57, "Fannie", 1, "Runolfsdottir", null },
                    { -41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anjali_Cormier44@gmail.com", -1, "Paulette", 1, "Raynor", null },
                    { -40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Augustus_OHara3@hotmail.com", -89, "Freda", 1, "Erdman", null },
                    { -39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Willie66@hotmail.com", -61, "George", 0, "Abbott", null },
                    { -38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wilma.Jones@gmail.com", -12, "Clarence", 0, "Hartmann", null },
                    { -37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Holden.Tillman@gmail.com", -68, "Sylvester", 0, "Wolf", null },
                    { -36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josefina57@hotmail.com", -42, "Jackie", 0, "Kris", null },
                    { -35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mertie_Morissette@gmail.com", -59, "Anna", 1, "Nolan", null },
                    { -34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristobal37@yahoo.com", -60, "Esther", 1, "Douglas", null },
                    { -33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mose.Macejkovic26@gmail.com", -64, "Peter", 0, "Lowe", null },
                    { -32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenton83@yahoo.com", -6, "Shaun", 0, "Effertz", null },
                    { -31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shanel.Reichel78@hotmail.com", -87, "Sharon", 1, "Blick", null },
                    { -30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leola87@gmail.com", -89, "Olive", 1, "Hermiston", null },
                    { -29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hershel.OReilly34@gmail.com", -40, "Nina", 1, "Conn", null },
                    { -28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lew.Ullrich@yahoo.com", -63, "Julio", 0, "Kulas", null },
                    { -27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khalil5@yahoo.com", -88, "Gilberto", 0, "Kris", null },
                    { -26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catalina.Douglas75@hotmail.com", -20, "Alonzo", 0, "Buckridge", null },
                    { -25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas_Sawayn95@gmail.com", -83, "Ramon", 0, "Bashirian", null },
                    { -24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailee61@gmail.com", -73, "Michele", 1, "Klein", null },
                    { -23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariela68@gmail.com", -97, "Gustavo", 0, "Nienow", null },
                    { -22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaylan91@yahoo.com", -84, "Tasha", 1, "Johnston", null },
                    { -21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kian36@yahoo.com", -53, "Patsy", 1, "Hand", null },
                    { -20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brisa.Lowe@yahoo.com", -68, "Samuel", 0, "Fisher", null },
                    { -19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lue67@yahoo.com", -10, "Jasmine", 1, "Rosenbaum", null },
                    { -18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Theresia.Mraz31@hotmail.com", -65, "Terrance", 0, "Jacobi", null },
                    { -17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madisen_Daniel28@yahoo.com", -86, "Willard", 0, "Daugherty", null },
                    { -16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Serena_Lockman@gmail.com", -33, "Louis", 0, "Quitzon", null },
                    { -15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Talia_Sporer@hotmail.com", -52, "Lena", 1, "Auer", null },
                    { -14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elvis.Hayes@yahoo.com", -64, "Candice", 1, "Lehner", null },
                    { -13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clementine68@yahoo.com", -53, "Anne", 1, "Veum", null },
                    { -12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elissa.Davis@gmail.com", -27, "Melanie", 1, "Witting", null },
                    { -11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brigitte60@hotmail.com", -18, "Jeffery", 0, "Batz", null },
                    { -10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ora89@gmail.com", -68, "Franklin", 0, "Kreiger", null },
                    { -9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lyda8@gmail.com", -21, "Patty", 1, "Krajcik", null },
                    { -8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cole_Nader10@hotmail.com", -90, "Ricardo", 0, "Haag", null },
                    { -7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryley_Lowe26@hotmail.com", -19, "Gilberto", 0, "Ledner", null },
                    { -6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lindsey.Jacobi@gmail.com", -63, "Carlos", 0, "Larson", null },
                    { -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Syble_Runolfsdottir@hotmail.com", -54, "Ricky", 0, "Hane", null },
                    { -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus.Stamm@gmail.com", -84, "Ernesto", 0, "Jones", null },
                    { -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leda_Kub6@hotmail.com", -15, "Hattie", 1, "Wilkinson", null },
                    { -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keira.Dietrich30@hotmail.com", -61, "Ian", 0, "Funk", null },
                    { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendall.Gutkowski@hotmail.com", -55, "Arturo", 0, "Okuneva", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_EmployerId",
                schema: "Store",
                table: "tblPeople",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblStores_Name",
                schema: "Store",
                table: "tblStores",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPeople",
                schema: "Store");

            migrationBuilder.DropTable(
                name: "tblStores",
                schema: "Store");
        }
    }
}
