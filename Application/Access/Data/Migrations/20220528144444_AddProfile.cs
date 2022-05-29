using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Access.Data.Migrations
{
    public partial class AddProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_role_role_role_id",
                table: "user_role");

            migrationBuilder.AddColumn<string>(
                name: "profile",
                table: "user",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "fk_user_role_roles_role_id",
                table: "user_role",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_user_role_roles_role_id",
                table: "user_role");

            migrationBuilder.DropColumn(
                name: "profile",
                table: "user");

            migrationBuilder.AddForeignKey(
                name: "fk_user_role_role_role_id",
                table: "user_role",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
