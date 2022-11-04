using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fotograf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyisim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false),
                    TCKimlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedeniDurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Askerlik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departman = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IseGiris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IstenCikis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CepTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalismaSuresi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaslamaTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EkBilgi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentDTOId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentDTOId",
                        column: x => x.DepartmentDTOId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2018",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2018_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2018_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2018", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2018_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2019",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2019_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2019_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2019", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2019_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2020",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2020_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2020_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2020", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2020_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2021",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2021_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2021_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2021", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2021_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2022",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2022_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2022_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2022", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2022_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2023",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Ocak2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Subat2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Mart2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Nisan2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Mayis2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Haziran2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Temmuz2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Agustos2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Eylul2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Ekim2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Kasim2023_C6 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C1 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C2 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C3 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C4 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C5 = table.Column<int>(type: "int", nullable: false),
                    Aralik2023_C6 = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations2023", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacations2023_Employees_Id",
                        column: x => x.Id,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDTOId",
                table: "Employees",
                column: "DepartmentDTOId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vacations2018");

            migrationBuilder.DropTable(
                name: "Vacations2019");

            migrationBuilder.DropTable(
                name: "Vacations2020");

            migrationBuilder.DropTable(
                name: "Vacations2021");

            migrationBuilder.DropTable(
                name: "Vacations2022");

            migrationBuilder.DropTable(
                name: "Vacations2023");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
