using Microsoft.EntityFrameworkCore.Migrations;

namespace SofartBackend.DataAccess.Migrations
{
    public partial class SocialAccountsFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_SocialMediaTypes_SocialMediaTypeId",
                table: "SocialAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "SocialAccounts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SocialAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SocialMediaTypeId",
                table: "SocialAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_SocialMediaTypes_SocialMediaTypeId",
                table: "SocialAccounts",
                column: "SocialMediaTypeId",
                principalTable: "SocialMediaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_SocialMediaTypes_SocialMediaTypeId",
                table: "SocialAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "SocialAccounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SocialMediaTypeId",
                table: "SocialAccounts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "SocialAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_SocialMediaTypes_SocialMediaTypeId",
                table: "SocialAccounts",
                column: "SocialMediaTypeId",
                principalTable: "SocialMediaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
