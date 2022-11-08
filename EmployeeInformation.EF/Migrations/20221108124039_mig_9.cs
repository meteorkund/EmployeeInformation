using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaritialDTOId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MaritialDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritialStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritialDTO", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MaritialDTOId",
                table: "Employees",
                column: "MaritialDTOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_MaritialDTO_MaritialDTOId",
                table: "Employees",
                column: "MaritialDTOId",
                principalTable: "MaritialDTO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_MaritialDTO_MaritialDTOId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "MaritialDTO");

            migrationBuilder.DropIndex(
                name: "IX_Employees_MaritialDTOId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritialDTOId",
                table: "Employees");
        }
    }
}
