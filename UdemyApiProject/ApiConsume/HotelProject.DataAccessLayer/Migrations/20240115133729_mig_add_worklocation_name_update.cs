using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_worklocation_name_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_workLocations_WorkLocationID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_workLocations",
                table: "workLocations");

            migrationBuilder.RenameTable(
                name: "workLocations",
                newName: "WorkLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkLocations",
                table: "WorkLocations",
                column: "WorkLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
                table: "AspNetUsers",
                column: "WorkLocationID",
                principalTable: "WorkLocations",
                principalColumn: "WorkLocationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkLocations",
                table: "WorkLocations");

            migrationBuilder.RenameTable(
                name: "WorkLocations",
                newName: "workLocations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workLocations",
                table: "workLocations",
                column: "WorkLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_workLocations_WorkLocationID",
                table: "AspNetUsers",
                column: "WorkLocationID",
                principalTable: "workLocations",
                principalColumn: "WorkLocationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
