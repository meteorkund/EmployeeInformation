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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EducationStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maritials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaritialStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maritials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MilitaryServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MilitaryStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilitaryServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SectorName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentDTOId = table.Column<int>(type: "INTEGER", nullable: false),
                    SectorDTOId = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationDTOId = table.Column<int>(type: "INTEGER", nullable: false),
                    MilitaryServiceDTOId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaritialDTOId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fotograf = table.Column<string>(type: "TEXT", nullable: true),
                    Isim = table.Column<string>(type: "TEXT", nullable: false),
                    Soyisim = table.Column<string>(type: "TEXT", nullable: false),
                    Durum = table.Column<bool>(type: "INTEGER", nullable: false),
                    TCKimlik = table.Column<string>(type: "TEXT", nullable: true),
                    DogumTarihi = table.Column<string>(type: "TEXT", nullable: true),
                    MedeniDurum = table.Column<string>(type: "TEXT", nullable: true),
                    EgitimDurumu = table.Column<string>(type: "TEXT", nullable: true),
                    Askerlik = table.Column<string>(type: "TEXT", nullable: true),
                    Gorev = table.Column<string>(type: "TEXT", nullable: true),
                    IseGiris = table.Column<string>(type: "TEXT", nullable: true),
                    IstenCikis = table.Column<string>(type: "TEXT", nullable: true),
                    Maas = table.Column<string>(type: "TEXT", nullable: true),
                    CepTel = table.Column<string>(type: "TEXT", nullable: true),
                    CalismaSuresi = table.Column<string>(type: "TEXT", nullable: true),
                    BaslamaTarihi = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true),
                    EkBilgi = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Employees_Educations_EducationDTOId",
                        column: x => x.EducationDTOId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Maritials_MaritialDTOId",
                        column: x => x.MaritialDTOId,
                        principalTable: "Maritials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_MilitaryServices_MilitaryServiceDTOId",
                        column: x => x.MilitaryServiceDTOId,
                        principalTable: "MilitaryServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Sectors_SectorDTOId",
                        column: x => x.SectorDTOId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations2018",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2018_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2019_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2020_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2021_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2022_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ocak2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Subat2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mart2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Nisan2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Mayis2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Haziran2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Temmuz2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Agustos2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Eylul2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Ekim2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Kasim2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C3 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C4 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C5 = table.Column<int>(type: "INTEGER", nullable: false),
                    Aralik2023_C6 = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EducationDTOId",
                table: "Employees",
                column: "EducationDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MaritialDTOId",
                table: "Employees",
                column: "MaritialDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MilitaryServiceDTOId",
                table: "Employees",
                column: "MilitaryServiceDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SectorDTOId",
                table: "Employees",
                column: "SectorDTOId");
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

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Maritials");

            migrationBuilder.DropTable(
                name: "MilitaryServices");

            migrationBuilder.DropTable(
                name: "Sectors");
        }
    }
}
