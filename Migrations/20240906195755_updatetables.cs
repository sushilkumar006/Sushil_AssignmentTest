using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sushil_AssignmentTest.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "State",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "District",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "State",
                newName: "StateId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "District",
                newName: "DistrictId");
        }
    }
}
