using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteProjects.Migrations
{
    /// <inheritdoc />
    public partial class img12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "EmployeeBasicInfo",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "EmployeeBasicInfo");
        }
    }
}
