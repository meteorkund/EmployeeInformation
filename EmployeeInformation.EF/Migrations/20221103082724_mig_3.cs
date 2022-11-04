using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departman",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Departman",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
