using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subat2018_c6",
                table: "Vacations",
                newName: "Subat2018_C6");

            migrationBuilder.RenameColumn(
                name: "Subat2018_c5",
                table: "Vacations",
                newName: "Subat2018_C5");

            migrationBuilder.RenameColumn(
                name: "Subat2018_c4",
                table: "Vacations",
                newName: "Subat2018_C4");

            migrationBuilder.RenameColumn(
                name: "Subat2018_c3",
                table: "Vacations",
                newName: "Subat2018_C3");

            migrationBuilder.RenameColumn(
                name: "Subat2018_c2",
                table: "Vacations",
                newName: "Subat2018_C2");

            migrationBuilder.RenameColumn(
                name: "Subat2018_c1",
                table: "Vacations",
                newName: "Subat2018_C1");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c6",
                table: "Vacations",
                newName: "Ocak2018_C6");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c5",
                table: "Vacations",
                newName: "Ocak2018_C5");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c4",
                table: "Vacations",
                newName: "Ocak2018_C4");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c3",
                table: "Vacations",
                newName: "Ocak2018_C3");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c2",
                table: "Vacations",
                newName: "Ocak2018_C2");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_c1",
                table: "Vacations",
                newName: "Ocak2018_C1");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Agustos2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Aralik2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ekim2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Eylul2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Haziran2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kasim2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mart2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mayis2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Nisan2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C1",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C2",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C3",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C4",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C5",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Temmuz2018_C6",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agustos2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Agustos2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Agustos2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Agustos2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Agustos2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Agustos2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Aralik2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Ekim2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Eylul2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Haziran2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Kasim2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mart2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Mayis2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Nisan2018_C6",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C1",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C2",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C3",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C4",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C5",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Temmuz2018_C6",
                table: "Vacations");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C6",
                table: "Vacations",
                newName: "Subat2018_c6");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C5",
                table: "Vacations",
                newName: "Subat2018_c5");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C4",
                table: "Vacations",
                newName: "Subat2018_c4");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C3",
                table: "Vacations",
                newName: "Subat2018_c3");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C2",
                table: "Vacations",
                newName: "Subat2018_c2");

            migrationBuilder.RenameColumn(
                name: "Subat2018_C1",
                table: "Vacations",
                newName: "Subat2018_c1");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C6",
                table: "Vacations",
                newName: "Ocak2018_c6");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C5",
                table: "Vacations",
                newName: "Ocak2018_c5");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C4",
                table: "Vacations",
                newName: "Ocak2018_c4");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C3",
                table: "Vacations",
                newName: "Ocak2018_c3");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C2",
                table: "Vacations",
                newName: "Ocak2018_c2");

            migrationBuilder.RenameColumn(
                name: "Ocak2018_C1",
                table: "Vacations",
                newName: "Ocak2018_c1");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c6",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c5",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c4",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c3",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c2",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Subat2018_c1",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c6",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c5",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c4",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c3",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c2",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ocak2018_c1",
                table: "Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
