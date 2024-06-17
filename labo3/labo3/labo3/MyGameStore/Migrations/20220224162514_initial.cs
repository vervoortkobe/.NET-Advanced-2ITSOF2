using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGameStore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.CreateTable(
                name: "tblStores",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(60)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(2)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(60)", nullable: true),
                    IsFranchiseStore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPeople",
                schema: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    EmployerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPeople_tblStores_EmployerId",
                        column: x => x.EmployerId,
                        principalSchema: "Store",
                        principalTable: "tblStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_EmployerId",
                schema: "Person",
                table: "tblPeople",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPeople_Id",
                schema: "Person",
                table: "tblPeople",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblStores_Name",
                schema: "Store",
                table: "tblStores",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPeople",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "tblStores",
                schema: "Store");
        }
    }
}
