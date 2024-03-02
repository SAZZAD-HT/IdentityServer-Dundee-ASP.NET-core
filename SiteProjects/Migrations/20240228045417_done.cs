using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteProjects.Migrations
{
    /// <inheritdoc />
    public partial class done : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyExpensesHeader",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    ExpenseDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyExpensesHeader", x => x.ExpenseId);
                });

            migrationBuilder.CreateTable(
                name: "DailyExpensesRow",
                columns: table => new
                {
                    ERowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ImagesId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApporved = table.Column<bool>(type: "bit", nullable: false),
                    ExpenseId = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyExpensesRow", x => x.ERowId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyExpensesHeader");

            migrationBuilder.DropTable(
                name: "DailyExpensesRow");
        }
    }
}
