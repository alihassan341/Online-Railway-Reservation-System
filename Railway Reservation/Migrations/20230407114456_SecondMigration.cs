using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Railway_Reservation.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Schedules_Source",
                table: "Schedules",
                column: "Source");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Cities_Source",
                table: "Schedules",
                column: "Source",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Cities_Source",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_Source",
                table: "Schedules");
        }
    }
}
