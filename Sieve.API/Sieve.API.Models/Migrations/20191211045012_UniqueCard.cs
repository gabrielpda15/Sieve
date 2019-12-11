using Microsoft.EntityFrameworkCore.Migrations;

namespace Sieve.API.Models.Migrations
{
    public partial class UniqueCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Cards_CardId",
                table: "Client");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Cards_CardId",
                table: "Client",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Cards_CardId",
                table: "Client");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Cards_CardId",
                table: "Client",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
