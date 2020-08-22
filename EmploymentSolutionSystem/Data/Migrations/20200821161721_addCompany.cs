using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSolutionSystem.Data.Migrations
{
    public partial class addCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Joblist",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Joblist",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Joblist",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "JobList",
                table: "company",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "candidate",
                columns: table => new
                {
                    Can_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Can_Name = table.Column<string>(nullable: true),
                    Can_LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Can_CV = table.Column<string>(nullable: true),
                    Job_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate", x => x.Can_Id);
                });

            migrationBuilder.CreateTable(
                name: "jobstatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobStatus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobstatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_company_JobList",
                table: "company",
                column: "JobList");

            migrationBuilder.AddForeignKey(
                name: "FK_company_Joblist_JobList",
                table: "company",
                column: "JobList",
                principalTable: "Joblist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_company_Joblist_JobList",
                table: "company");

            migrationBuilder.DropTable(
                name: "candidate");

            migrationBuilder.DropTable(
                name: "jobstatus");

            migrationBuilder.DropIndex(
                name: "IX_company_JobList",
                table: "company");

            migrationBuilder.DropColumn(
                name: "JobList",
                table: "company");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Joblist",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Joblist",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Joblist",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
