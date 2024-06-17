using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyGameStore.Migrations
{
    /// <inheritdoc />
    public partial class MultiFakePersonSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EmailAddress", "EmployerId", "FirstName", "LastName" },
                values: new object[] { "Allan.Jones24@gmail.com", -9, "Lana", "Hegmann" });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "Id", "BirthDate", "EmailAddress", "EmployerId", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { -100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rashawn_Romaguera@hotmail.com", -56, "Antonio", 0, "Kautzer" },
                    { -99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cali.Marquardt@hotmail.com", -33, "Nadine", 1, "Schuppe" },
                    { -98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyrel.Blick@yahoo.com", -71, "Miranda", 1, "Lang" },
                    { -97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katrina.Hessel23@gmail.com", -55, "Jesse", 0, "Kozey" },
                    { -96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deion_Daugherty@hotmail.com", -82, "Bertha", 1, "Stokes" },
                    { -95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark_Jacobson65@gmail.com", -39, "Colin", 0, "Robel" },
                    { -94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cletus.Nolan78@hotmail.com", -30, "Kelly", 1, "Orn" },
                    { -93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esmeralda19@yahoo.com", -13, "Joy", 1, "Stracke" },
                    { -92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dillon_Bashirian@gmail.com", -1, "Mack", 0, "Stracke" },
                    { -91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry96@hotmail.com", -37, "Cecelia", 1, "Dooley" },
                    { -90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Norma.Schaefer51@hotmail.com", -17, "Shaun", 0, "Wisoky" },
                    { -89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonora.Schuster@hotmail.com", -38, "Kirk", 0, "Osinski" },
                    { -88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Providenci.Marquardt@yahoo.com", -25, "Tyler", 0, "Boyle" },
                    { -87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlene.Mueller76@gmail.com", -80, "Maggie", 1, "Treutel" },
                    { -86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Callie_Tremblay@hotmail.com", -24, "Jamie", 0, "Green" },
                    { -85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trisha69@yahoo.com", -75, "Randolph", 0, "Schowalter" },
                    { -84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terry21@yahoo.com", -78, "Wesley", 0, "Bahringer" },
                    { -83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eldora0@gmail.com", -31, "Woodrow", 0, "Schoen" },
                    { -82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joel.Robel85@gmail.com", -67, "Hugo", 0, "Walter" },
                    { -81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentin.Schowalter44@gmail.com", -90, "Darrin", 0, "Feest" },
                    { -80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosalia.Collier28@gmail.com", -20, "Kristine", 1, "Upton" },
                    { -79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerson_Huel@gmail.com", -39, "Natalie", 1, "Bergnaum" },
                    { -78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Furman8@gmail.com", -89, "Jeremy", 0, "Lang" },
                    { -77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julia.Corwin18@hotmail.com", -37, "Derrick", 0, "Von" },
                    { -76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adelia.Schowalter1@yahoo.com", -29, "Laverne", 1, "Sanford" },
                    { -75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerson.Gislason@hotmail.com", -95, "Ed", 0, "Hoeger" },
                    { -74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luigi_Boyle71@yahoo.com", -32, "Sandra", 1, "Dooley" },
                    { -73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe.Powlowski@gmail.com", -20, "Raul", 0, "Lind" },
                    { -72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosamond_Kiehn@hotmail.com", -79, "Dean", 0, "Herman" },
                    { -71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark26@hotmail.com", -80, "Kellie", 1, "Morissette" },
                    { -70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jazmin84@gmail.com", -67, "Teri", 1, "Casper" },
                    { -69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garland_Volkman@hotmail.com", -62, "Warren", 0, "Wuckert" },
                    { -68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosie19@yahoo.com", -77, "Raul", 0, "Stanton" },
                    { -67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ellen_Pacocha@gmail.com", -64, "Sue", 1, "Hoppe" },
                    { -66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linda.Jast86@gmail.com", -57, "Nathan", 0, "Dietrich" },
                    { -65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilliana72@gmail.com", -98, "Erin", 1, "Kling" },
                    { -64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kory_Buckridge@gmail.com", -2, "Andrea", 1, "Kulas" },
                    { -63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cora.Zboncak90@gmail.com", -46, "Beulah", 1, "Renner" },
                    { -62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kade47@hotmail.com", -27, "Randal", 0, "Johnson" },
                    { -61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morgan89@yahoo.com", -36, "Monique", 1, "Bailey" },
                    { -60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefanie88@yahoo.com", -71, "Christy", 1, "Treutel" },
                    { -59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eliezer32@hotmail.com", -7, "Randall", 0, "Cummerata" },
                    { -58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler.Gusikowski@gmail.com", -43, "Tommie", 0, "Ferry" },
                    { -57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clark.McCullough@hotmail.com", -16, "Randall", 0, "Donnelly" },
                    { -56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mertie.Fahey61@hotmail.com", -23, "Jennie", 1, "Stanton" },
                    { -55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cydney_Okuneva58@yahoo.com", -62, "Angelo", 0, "Kuvalis" },
                    { -54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samir6@yahoo.com", -21, "Angel", 1, "Murphy" },
                    { -53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catalina_Russel82@gmail.com", -42, "Lois", 1, "Jenkins" },
                    { -52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niko.Satterfield62@yahoo.com", -41, "Eula", 1, "Collier" },
                    { -51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lilliana.Quitzon@gmail.com", -45, "Sarah", 1, "Moen" },
                    { -50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Idell_Tromp@gmail.com", -19, "Bertha", 1, "Fadel" },
                    { -49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madyson_Feest@gmail.com", -38, "Robyn", 1, "Rippin" },
                    { -48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demarcus.Hane@hotmail.com", -5, "Micheal", 0, "Weber" },
                    { -47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baylee_Mills@hotmail.com", -52, "Carmen", 1, "Rutherford" },
                    { -46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonie.Koch26@hotmail.com", -75, "Andrew", 0, "Reilly" },
                    { -45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Therese.Roob79@gmail.com", -58, "Henrietta", 1, "Wyman" },
                    { -44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jovan.Lang@yahoo.com", -92, "Fannie", 1, "Rohan" },
                    { -43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timmy77@gmail.com", -48, "Neil", 0, "Bruen" },
                    { -42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francesca_Mueller@yahoo.com", -28, "Joanne", 1, "Krajcik" },
                    { -41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sasha_Jenkins@gmail.com", -75, "Shane", 0, "Schaefer" },
                    { -40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aaliyah_Torphy@yahoo.com", -10, "Boyd", 0, "Rippin" },
                    { -39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maudie49@hotmail.com", -94, "Victor", 0, "Kuhlman" },
                    { -38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carmela45@gmail.com", -20, "Carrie", 1, "Rippin" },
                    { -37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monserrate_Reinger@yahoo.com", -54, "Dennis", 0, "Rempel" },
                    { -36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sedrick_Balistreri@hotmail.com", -13, "Veronica", 1, "Stehr" },
                    { -35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heather67@yahoo.com", -53, "Anna", 1, "Bahringer" },
                    { -34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devan31@gmail.com", -5, "Timothy", 0, "Schneider" },
                    { -33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arely.Schaden31@hotmail.com", -43, "Gene", 0, "O'Conner" },
                    { -32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jayme_Sporer67@hotmail.com", -32, "Joel", 0, "Lang" },
                    { -31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jared97@gmail.com", -60, "Nicholas", 0, "Hoppe" },
                    { -30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mckenna31@gmail.com", -51, "Domingo", 0, "D'Amore" },
                    { -29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beulah.Swift82@yahoo.com", -27, "Barbara", 1, "Beahan" },
                    { -28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dennis_Mayer@yahoo.com", -81, "Doug", 0, "Wuckert" },
                    { -27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katheryn_Bernier@gmail.com", -64, "Lynne", 1, "Kessler" },
                    { -26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hunter.Leannon@gmail.com", -95, "Lora", 1, "Abbott" },
                    { -25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janis99@gmail.com", -84, "Pablo", 0, "Dooley" },
                    { -24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keshaun.Pacocha@yahoo.com", -41, "Santiago", 0, "Hand" },
                    { -23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emelia_Douglas@hotmail.com", -56, "Eleanor", 1, "Gleichner" },
                    { -22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chris_Nitzsche28@yahoo.com", -82, "Lloyd", 0, "Ebert" },
                    { -21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eduardo_Bogisich@yahoo.com", -35, "Luke", 0, "Brakus" },
                    { -20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiarra_McCullough49@gmail.com", -89, "Alberto", 0, "Armstrong" },
                    { -19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orpha_Mayert@yahoo.com", -76, "Isabel", 1, "Treutel" },
                    { -18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tania.Ryan@gmail.com", -72, "Violet", 1, "Hermiston" },
                    { -17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana.Sawayn62@yahoo.com", -47, "Marilyn", 1, "Dooley" },
                    { -16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zion_Koss@yahoo.com", -8, "Elias", 0, "Hermiston" },
                    { -15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brody_Cremin@yahoo.com", -90, "Sally", 1, "McCullough" },
                    { -14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onie.Jacobi51@gmail.com", -34, "Marlon", 0, "Crona" },
                    { -13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loy16@gmail.com", -21, "David", 0, "Kohler" },
                    { -12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colt30@yahoo.com", -26, "Sheri", 1, "Stamm" },
                    { -11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan_Hilll58@gmail.com", -54, "Nathan", 0, "Windler" },
                    { -10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arch.Leannon66@yahoo.com", -45, "Robyn", 1, "Watsica" },
                    { -9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elouise.Hintz@yahoo.com", -58, "Elisa", 1, "Hoeger" },
                    { -8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eleanore.West@hotmail.com", -62, "Guillermo", 0, "Kessler" },
                    { -7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lia.Collins@yahoo.com", -19, "Irvin", 0, "Blick" },
                    { -6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lamar.Block@hotmail.com", -46, "Travis", 0, "Kemmer" },
                    { -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beverly.Hegmann81@hotmail.com", -7, "Alberta", 1, "Vandervort" },
                    { -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dessie_Torphy@yahoo.com", -59, "Roy", 0, "Bruen" },
                    { -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dee_Kunze40@gmail.com", -62, "Frances", 1, "Zieme" },
                    { -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hilbert_Skiles@hotmail.com", -23, "Julie", 1, "Jacobs" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.UpdateData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "EmailAddress", "EmployerId", "FirstName", "LastName" },
                values: new object[] { "a@b.com", -1, "Jan", "Janssens" });
        }
    }
}
