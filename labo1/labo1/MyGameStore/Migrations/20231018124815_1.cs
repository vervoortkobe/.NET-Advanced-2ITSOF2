using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGameStore.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Person");

            migrationBuilder.EnsureSchema(
                name: "Store");

            migrationBuilder.CreateTable(
                name: "tblPeople",
                schema: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    EmailAdress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPeople", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblStores",
                schema: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Addition = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    IsFranchiseStore = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonStore",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    EmployersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonStore", x => new { x.EmployeesId, x.EmployersId });
                    table.ForeignKey(
                        name: "FK_PersonStore_tblPeople_EmployeesId",
                        column: x => x.EmployeesId,
                        principalSchema: "Person",
                        principalTable: "tblPeople",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonStore_tblStores_EmployersId",
                        column: x => x.EmployersId,
                        principalSchema: "Store",
                        principalTable: "tblStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonStore_EmployersId",
                table: "PersonStore",
                column: "EmployersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonStore");

            migrationBuilder.DropTable(
                name: "tblPeople",
                schema: "Person");

            migrationBuilder.DropTable(
                name: "tblStores",
                schema: "Store");
        }
    }
}
