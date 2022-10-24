using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeInformation.EF.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    EkBilgi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
