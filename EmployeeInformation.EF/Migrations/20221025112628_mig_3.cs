using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c1",
                table: "Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c2",
                table: "Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c3",
                table: "Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c4",
                table: "Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c5",
                table: "Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subat2018_c6",
                table: "Vacations",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subat2018_c1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Subat2018_c2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Subat2018_c3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Subat2018_c4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Subat2018_c5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Subat2018_c6",
                table: "Vacations");
        }
    }
}
