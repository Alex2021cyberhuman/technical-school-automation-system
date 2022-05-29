using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.Data.Migrations
{
    public partial class AddSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cabinets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cabinets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schedule",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    group_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_schedule", x => x.id);
                    table.ForeignKey(
                        name: "fk_schedule_group_group_id",
                        column: x => x.group_id,
                        principalTable: "group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "class_schedule",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    schedule_id = table.Column<long>(type: "bigint", nullable: false),
                    subject_id = table.Column<long>(type: "bigint", nullable: false),
                    day_of_week = table.Column<int>(type: "integer", nullable: false),
                    cabinet_id = table.Column<long>(type: "bigint", nullable: true),
                    teacher_id = table.Column<long>(type: "bigint", nullable: true),
                    number = table.Column<int>(type: "integer", nullable: false),
                    weeks_separation = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_schedule", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_schedule_cabinets_cabinet_id",
                        column: x => x.cabinet_id,
                        principalTable: "cabinets",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_class_schedule_schedule_schedule_id",
                        column: x => x.schedule_id,
                        principalTable: "schedule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_schedule_subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_schedule_user_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "class_schedule_replacement",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    schedule_id = table.Column<long>(type: "bigint", nullable: false),
                    class_schedule_id = table.Column<long>(type: "bigint", nullable: true),
                    subject_id = table.Column<long>(type: "bigint", nullable: false),
                    cabinet_id = table.Column<long>(type: "bigint", nullable: true),
                    teacher_id = table.Column<long>(type: "bigint", nullable: true),
                    date = table.Column<DateOnly>(type: "date", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_class_schedule_replacement", x => x.id);
                    table.ForeignKey(
                        name: "fk_class_schedule_replacement_cabinets_cabinet_id",
                        column: x => x.cabinet_id,
                        principalTable: "cabinets",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_class_schedule_replacement_class_schedule_class_schedule_id",
                        column: x => x.class_schedule_id,
                        principalTable: "class_schedule",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_class_schedule_replacement_schedule_schedule_id",
                        column: x => x.schedule_id,
                        principalTable: "schedule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_schedule_replacement_subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_class_schedule_replacement_user_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "user",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_cabinet_id",
                table: "class_schedule",
                column: "cabinet_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_schedule_id",
                table: "class_schedule",
                column: "schedule_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_subject_id",
                table: "class_schedule",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_teacher_id",
                table: "class_schedule",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_replacement_cabinet_id",
                table: "class_schedule_replacement",
                column: "cabinet_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_replacement_class_schedule_id",
                table: "class_schedule_replacement",
                column: "class_schedule_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_replacement_schedule_id",
                table: "class_schedule_replacement",
                column: "schedule_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_replacement_subject_id",
                table: "class_schedule_replacement",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "ix_class_schedule_replacement_teacher_id",
                table: "class_schedule_replacement",
                column: "teacher_id");

            migrationBuilder.CreateIndex(
                name: "ix_schedule_group_id",
                table: "schedule",
                column: "group_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "class_schedule_replacement");

            migrationBuilder.DropTable(
                name: "class_schedule");

            migrationBuilder.DropTable(
                name: "cabinets");

            migrationBuilder.DropTable(
                name: "schedule");
        }
    }
}
