using Microsoft.EntityFrameworkCore.Migrations;

namespace Sieve.API.Models.Migrations
{
    public partial class EmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Identity_IdentityId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityId",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Identity_IdentityId",
                table: "Employees",
                column: "IdentityId",
                principalTable: "Identity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Identity_IdentityId",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityId",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Identity_IdentityId",
                table: "Employees",
                column: "IdentityId",
                principalTable: "Identity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
