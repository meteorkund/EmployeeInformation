using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationDTOId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MilitaryServiceDTOId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MilitaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EducationDTOId",
                table: "Employees",
                column: "EducationDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MilitaryServiceDTOId",
                table: "Employees",
                column: "MilitaryServiceDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Educations_EducationDTOId",
                table: "Employees",
                column: "EducationDTOId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_MilitaryServices_MilitaryServiceDTOId",
                table: "Employees",
                column: "MilitaryServiceDTOId",
                principalTable: "MilitaryServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Educations_EducationDTOId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_MilitaryServices_MilitaryServiceDTOId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EducationDTOId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MilitaryServiceDTOId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EducationDTOId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MilitaryServiceDTOId",
                table: "Employees");
        }
    }
}
