using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushil_AssignmentTest.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_infoToGender",
                table: "Customer_Info");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_infoToGender",
                table: "Customer_Info",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
