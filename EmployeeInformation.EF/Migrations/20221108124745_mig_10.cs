using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_MaritialDTO_MaritialDTOId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaritialDTO",
                table: "MaritialDTO");

            migrationBuilder.RenameTable(
                name: "MaritialDTO",
                newName: "Maritials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maritials",
                table: "Maritials",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Maritials_MaritialDTOId",
                table: "Employees",
                column: "MaritialDTOId",
                principalTable: "Maritials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Maritials_MaritialDTOId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maritials",
                table: "Maritials");

            migrationBuilder.RenameTable(
                name: "Maritials",
                newName: "MaritialDTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaritialDTO",
                table: "MaritialDTO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_MaritialDTO_MaritialDTOId",
                table: "Employees",
                column: "MaritialDTOId",
                principalTable: "MaritialDTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
