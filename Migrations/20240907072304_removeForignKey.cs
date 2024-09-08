using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushil_AssignmentTest.Migrations
{
    public partial class removeForignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
            name: "FK_Customer_infoToGender",
            table: "Customer_Info");

            // Optionally, you might also want to drop the index on the foreign key column
            migrationBuilder.DropIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
            name: "FK_Customer_infoToGender",
            table: "Customer_Info",
            column: "GenderId",
            principalTable: "Gender",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);

            // Optionally, recreate the index
            migrationBuilder.CreateIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info",
                column: "GenderId");

        }
    }
}
