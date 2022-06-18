using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Data.Migrations
{
    public partial class AddEnrolmentGraduationDatesToGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "enrollment",
                table: "group",
                type: "timestamp with time zone",
                nullable: false,
                computedColumnSql: "make_date(\"enrollment_year\", 9, 1)",
                stored: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "graduation",
                table: "group",
                type: "timestamp with time zone",
                nullable: false,
                computedColumnSql: "make_date(\"graduation_year\", 8, 31)",
                stored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "enrollment",
                table: "group");

            migrationBuilder.DropColumn(
                name: "graduation",
                table: "group");
        }
    }
}
