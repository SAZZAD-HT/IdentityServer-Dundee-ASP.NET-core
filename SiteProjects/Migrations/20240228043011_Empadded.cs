using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteProjects.Migrations
{
    /// <inheritdoc />
    public partial class Empadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankInfo",
                columns: table => new
                {
                    InfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InfBranchId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankInfo", x => x.InfId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBasicInfo",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpFatherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpMotherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpSpouseName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpNID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpPassport = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpTIN = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpNationality = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpReligion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpBloodGroup = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpMaritalStatus = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmpGender = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InfId = table.Column<int>(type: "int", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    ResignDate = table.Column<DateOnly>(type: "date", nullable: false),
                    DateOfJoin = table.Column<DateOnly>(type: "date", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBasicInfo", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "MasterDesigination",
                columns: table => new
                {
                    DesiginationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesiginationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DesiginationType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterDesigination", x => x.DesiginationId);
                });

            migrationBuilder.CreateTable(
                name: "MasterSiteSetup",
                columns: table => new
                {
                    SiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SiteLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSiteSetup", x => x.SiteId);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    SalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalary = table.Column<float>(type: "real", nullable: false),
                    GrossSalary = table.Column<float>(type: "real", nullable: false),
                    Deduction = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.SalID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankInfo");

            migrationBuilder.DropTable(
                name: "EmployeeBasicInfo");

            migrationBuilder.DropTable(
                name: "MasterDesigination");

            migrationBuilder.DropTable(
                name: "MasterSiteSetup");

            migrationBuilder.DropTable(
                name: "Salary");
        }
    }
}
