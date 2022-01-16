using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laba_CryptoCurrency.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CryptoCurrencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CryptoPair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Interval = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CryptoCurrencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeIntervals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CryptoCurrencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeIntervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeIntervals_CryptoCurrencies_CryptoCurrencyId",
                        column: x => x.CryptoCurrencyId,
                        principalTable: "CryptoCurrencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeIntervals_CryptoCurrencyId",
                table: "TimeIntervals",
                column: "CryptoCurrencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeIntervals");

            migrationBuilder.DropTable(
                name: "CryptoCurrencies");
        }
    }
}
