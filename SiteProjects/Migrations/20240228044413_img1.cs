using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteProjects.Migrations
{
    /// <inheritdoc />
    public partial class img1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyAllocation",
                columns: table => new
                {
                    AllotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllocationAmount = table.Column<float>(type: "real", maxLength: 200, nullable: false),
                    AllocationDate = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyAllocation", x => x.AllotId);
                });

            migrationBuilder.CreateTable(
                name: "ImagesExpenses",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesExpenses", x => x.ImageId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyAllocation");

            migrationBuilder.DropTable(
                name: "ImagesExpenses");
        }
    }
}
