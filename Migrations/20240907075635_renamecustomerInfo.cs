using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushil_AssignmentTest.Migrations
{
    public partial class renamecustomerInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Info_Districts_DistrictId",
                table: "Customer_Info");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Info_States_StateId",
                table: "Customer_Info");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Info",
                table: "Customer_Info");

            migrationBuilder.RenameTable(
                name: "Customer_Info",
                newName: "Customer_Infos");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Info_StateId",
                table: "Customer_Infos",
                newName: "IX_Customer_Infos_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Info_GenderId",
                table: "Customer_Infos",
                newName: "IX_Customer_Infos_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Info_DistrictId",
                table: "Customer_Infos",
                newName: "IX_Customer_Infos_DistrictId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Infos",
                table: "Customer_Infos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Infos_Districts_DistrictId",
                table: "Customer_Infos",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Infos_States_StateId",
                table: "Customer_Infos",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Infos_Districts_DistrictId",
                table: "Customer_Infos");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Infos_States_StateId",
                table: "Customer_Infos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer_Infos",
                table: "Customer_Infos");

            migrationBuilder.RenameTable(
                name: "Customer_Infos",
                newName: "Customer_Info");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Infos_StateId",
                table: "Customer_Info",
                newName: "IX_Customer_Info_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Infos_GenderId",
                table: "Customer_Info",
                newName: "IX_Customer_Info_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_Infos_DistrictId",
                table: "Customer_Info",
                newName: "IX_Customer_Info_DistrictId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer_Info",
                table: "Customer_Info",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Info_Districts_DistrictId",
                table: "Customer_Info",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Info_States_StateId",
                table: "Customer_Info",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
