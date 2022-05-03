using Microsoft.EntityFrameworkCore.Migrations;

namespace SofartBackend.DataAccess.Migrations
{
    public partial class SocialAccountsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialMediaId",
                table: "SocialAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SocialAccounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialAccounts_UserId",
                table: "SocialAccounts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialAccounts_Users_UserId",
                table: "SocialAccounts");

            migrationBuilder.DropIndex(
                name: "IX_SocialAccounts_UserId",
                table: "SocialAccounts");

            migrationBuilder.DropColumn(
                name: "SocialMediaId",
                table: "SocialAccounts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SocialAccounts");
        }
    }
}
