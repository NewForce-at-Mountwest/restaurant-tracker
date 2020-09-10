using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantTracker.Data.Migrations
{
    public partial class AddedApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Waiter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_UserId",
                table: "Waiter",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Waiter_AspNetUsers_UserId",
                table: "Waiter",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Waiter_AspNetUsers_UserId",
                table: "Waiter");

            migrationBuilder.DropIndex(
                name: "IX_Waiter_UserId",
                table: "Waiter");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Waiter");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
