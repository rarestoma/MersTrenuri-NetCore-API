using Microsoft.EntityFrameworkCore.Migrations;

namespace DAW.WebApi.Migrations
{
    public partial class a12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TrainStations",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TrainStations_Id",
                table: "TrainStations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TrainStations_Id",
                table: "TrainStations");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TrainStations",
                newName: "ID");
        }
    }
}
