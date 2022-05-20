using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.Specialities.Data.Migrations
{
    public partial class AssignSubjectsToSpecialities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "speciality_id",
                table: "subject",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "semester",
                columns: table => new
                {
                    subject_id = table.Column<long>(type: "bigint", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<int>(type: "integer", nullable: false),
                    hours = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_semester", x => new { x.subject_id, x.id });
                    table.ForeignKey(
                        name: "fk_semester_subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_subject_speciality_id",
                table: "subject",
                column: "speciality_id");

            migrationBuilder.AddForeignKey(
                name: "fk_subject_speciality_speciality_id",
                table: "subject",
                column: "speciality_id",
                principalTable: "speciality",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_subject_speciality_speciality_id",
                table: "subject");

            migrationBuilder.DropTable(
                name: "semester");

            migrationBuilder.DropIndex(
                name: "ix_subject_speciality_id",
                table: "subject");

            migrationBuilder.DropColumn(
                name: "speciality_id",
                table: "subject");
        }
    }
}
