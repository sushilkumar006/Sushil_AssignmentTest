using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushil_AssignmentTest.Migrations
{
    public partial class updatetablesWithKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Gender",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Customer_Info",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Customer_Info",
                newName: "GenderId");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "Customer_Info",
                newName: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Info_DistrictId",
                table: "Customer_Info",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Info_StateId",
                table: "Customer_Info",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Info_District_DistrictId",
                table: "Customer_Info",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Info_State_StateId",
                table: "Customer_Info",
                column: "StateId",
                principalTable: "State",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_infoToGender",
                table: "Customer_Info",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Info_District_DistrictId",
                table: "Customer_Info");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Info_State_StateId",
                table: "Customer_Info");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_infoToGender",
                table: "Customer_Info");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Info_DistrictId",
                table: "Customer_Info");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Info");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Info_StateId",
                table: "Customer_Info");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Gender",
                newName: "GenderId");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "Customer_Info",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Customer_Info",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "Customer_Info",
                newName: "District");
        }
    }
}
