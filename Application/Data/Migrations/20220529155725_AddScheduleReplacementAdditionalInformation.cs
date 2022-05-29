using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Data.Migrations
{
    public partial class AddScheduleReplacementAdditionalInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement");

            migrationBuilder.AlterColumn<long>(
                name: "subject_id",
                table: "class_schedule_replacement",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<bool>(
                name: "is_addition",
                table: "class_schedule_replacement",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_cancel",
                table: "class_schedule_replacement",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement",
                column: "subject_id",
                principalTable: "subject",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropColumn(
                name: "is_addition",
                table: "class_schedule_replacement");

            migrationBuilder.DropColumn(
                name: "is_cancel",
                table: "class_schedule_replacement");

            migrationBuilder.AlterColumn<long>(
                name: "subject_id",
                table: "class_schedule_replacement",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_subject_subject_id",
                table: "class_schedule_replacement",
                column: "subject_id",
                principalTable: "subject",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
