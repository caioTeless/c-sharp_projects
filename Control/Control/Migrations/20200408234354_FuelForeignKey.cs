using Microsoft.EntityFrameworkCore.Migrations;

namespace Control.Migrations
{
    public partial class FuelForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spend_Fuel_FuelId",
                table: "Spend");

            migrationBuilder.AlterColumn<int>(
                name: "FuelId",
                table: "Spend",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_Fuel_FuelId",
                table: "Spend",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spend_Fuel_FuelId",
                table: "Spend");

            migrationBuilder.AlterColumn<int>(
                name: "FuelId",
                table: "Spend",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Spend_Fuel_FuelId",
                table: "Spend",
                column: "FuelId",
                principalTable: "Fuel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
