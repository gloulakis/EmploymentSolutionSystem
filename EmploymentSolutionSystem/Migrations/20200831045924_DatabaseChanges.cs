using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSolutionSystem.Migrations
{
    public partial class DatabaseChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyLogo",
                table: "company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyLogo",
                table: "company");
        }
    }
}
