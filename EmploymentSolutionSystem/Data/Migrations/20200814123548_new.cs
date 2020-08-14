﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSolutionSystem.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joblist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(nullable: false),
                    JobDescription = table.Column<string>(nullable: false),
                    JobPosition = table.Column<string>(nullable: false),
                    JobSalary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joblist", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joblist");
        }
    }
}
