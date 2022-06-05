using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Data.Migrations
{
    public partial class AddCascadeRequirements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_cabinet_cabinet_id",
                table: "class_schedule");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_cabinet_cabinet_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_class_schedule_class_schedule_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_cabinet_cabinet_id",
                table: "class_schedule",
                column: "cabinet_id",
                principalTable: "cabinet",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_cabinet_cabinet_id",
                table: "class_schedule_replacement",
                column: "cabinet_id",
                principalTable: "cabinet",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_class_schedule_class_schedule_id",
                table: "class_schedule_replacement",
                column: "class_schedule_id",
                principalTable: "class_schedule",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement",
                column: "subject_id",
                principalTable: "subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_cabinet_cabinet_id",
                table: "class_schedule");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_cabinet_cabinet_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_class_schedule_class_schedule_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_cabinet_cabinet_id",
                table: "class_schedule",
                column: "cabinet_id",
                principalTable: "cabinet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_cabinet_cabinet_id",
                table: "class_schedule_replacement",
                column: "cabinet_id",
                principalTable: "cabinet",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_class_schedule_class_schedule_id",
                table: "class_schedule_replacement",
                column: "class_schedule_id",
                principalTable: "class_schedule",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement",
                column: "subject_id",
                principalTable: "subject",
                principalColumn: "id");
        }
    }
}
