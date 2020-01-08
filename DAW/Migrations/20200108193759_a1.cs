using Microsoft.EntityFrameworkCore.Migrations;

namespace DAW.WebApi.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Stations",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trains_Id",
                table: "Trains",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_Id",
                table: "Stations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Trains_Id",
                table: "Trains");

            migrationBuilder.DropIndex(
                name: "IX_Stations_Id",
                table: "Stations");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stations",
                newName: "ID");
        }
    }
}
