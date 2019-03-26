using Microsoft.EntityFrameworkCore.Migrations;

namespace CapTestAutomationDemo.Migrations
{
    public partial class EngineSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InsurancePackage",
                table: "VehiclesModel",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EngineSize",
                table: "VehiclesModel",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                table: "VehiclesModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineSize",
                table: "VehiclesModel");

            migrationBuilder.DropColumn(
                name: "FuelType",
                table: "VehiclesModel");

            migrationBuilder.AlterColumn<string>(
                name: "InsurancePackage",
                table: "VehiclesModel",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
