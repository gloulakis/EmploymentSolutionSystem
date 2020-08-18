using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSolutionSystem.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobImage",
                table: "Joblist",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: false),
                    CompanyEmail = table.Column<string>(nullable: false),
                    CompanyTelephoneNumber = table.Column<string>(nullable: true),
                    CompanyCity = table.Column<string>(nullable: false),
                    CompanyAddress = table.Column<string>(nullable: false),
                    CompanyZIPCode = table.Column<string>(nullable: false),
                    CompanyLogo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropColumn(
                name: "JobImage",
                table: "Joblist");
        }
    }
}
