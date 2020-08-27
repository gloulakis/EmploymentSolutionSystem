using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSolutionSystem.Data.Migrations
{
    public partial class Cmpany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_company_Joblist_JobList",
                table: "company");

            migrationBuilder.DropIndex(
                name: "IX_company_JobList",
                table: "company");

            migrationBuilder.DropColumn(
                name: "JobList",
                table: "company");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Joblist",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Joblist",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Joblist",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "BULSTAT",
                table: "company",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "JobListId",
                table: "company",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_company_JobListId",
                table: "company",
                column: "JobListId");

            migrationBuilder.AddForeignKey(
                name: "FK_company_Joblist_JobListId",
                table: "company",
                column: "JobListId",
                principalTable: "Joblist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_company_Joblist_JobListId",
                table: "company");

            migrationBuilder.DropIndex(
                name: "IX_company_JobListId",
                table: "company");

            migrationBuilder.DropColumn(
                name: "BULSTAT",
                table: "company");

            migrationBuilder.DropColumn(
                name: "JobListId",
                table: "company");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Joblist",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "JobPosition",
                table: "Joblist",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Joblist",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "JobList",
                table: "company",
                type: "int",
                nullable: true);

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
    }
}
