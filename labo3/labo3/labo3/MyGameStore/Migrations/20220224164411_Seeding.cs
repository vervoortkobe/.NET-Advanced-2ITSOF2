using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Store",
                table: "tblStores",
                columns: new[] { "Id", "Addition", "Place", "IsFranchiseStore", "Name", "Number", "Street", "Zipcode" },
                values: new object[] { -1, "", "Antwerp", false, "ABC", "10A", "Ellerman", "2000" });

            migrationBuilder.InsertData(
                schema: "Person",
                table: "tblPeople",
                columns: new[] { "Id", "BirthDate", "EmailAddress", "EmployerId", "FirstName", "Gender", "LastName" },
                values: new object[] { -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a@b.com", -1, "Sven", 1, "Mariën" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "tblPeople",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                schema: "Store",
                table: "tblStores",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
