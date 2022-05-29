using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Data.Migrations
{
    public partial class RenameCabinetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_cabinets_cabinet_id",
                table: "class_schedule");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_cabinets_cabinet_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cabinets",
                table: "cabinets");

            migrationBuilder.RenameTable(
                name: "cabinets",
                newName: "cabinet");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "cabinet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "floor",
                table: "cabinet",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "profile",
                table: "cabinet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "wing",
                table: "cabinet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cabinet",
                table: "cabinet",
                column: "id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_cabinet_cabinet_id",
                table: "class_schedule");

            migrationBuilder.DropForeignKey(
                name: "fk_class_schedule_replacement_cabinet_cabinet_id",
                table: "class_schedule_replacement");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cabinet",
                table: "cabinet");

            migrationBuilder.DropColumn(
                name: "code",
                table: "cabinet");

            migrationBuilder.DropColumn(
                name: "floor",
                table: "cabinet");

            migrationBuilder.DropColumn(
                name: "profile",
                table: "cabinet");

            migrationBuilder.DropColumn(
                name: "wing",
                table: "cabinet");

            migrationBuilder.RenameTable(
                name: "cabinet",
                newName: "cabinets");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cabinets",
                table: "cabinets",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_cabinets_cabinet_id",
                table: "class_schedule",
                column: "cabinet_id",
                principalTable: "cabinets",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_class_schedule_replacement_cabinets_cabinet_id",
                table: "class_schedule_replacement",
                column: "cabinet_id",
                principalTable: "cabinets",
                principalColumn: "id");
        }
    }
}
