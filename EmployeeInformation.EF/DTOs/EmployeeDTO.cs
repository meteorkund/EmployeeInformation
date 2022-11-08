using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformation.EF.DTOs.Common;

namespace EmployeeInformation.EF.DTOs
{
    public class EmployeeDTO : BaseDTO
    {
        public int DepartmentDTOId { get; set; }
        public int SectorDTOId { get; set; }
        public int EducationDTOId { get; set; }
        public int MilitaryServiceDTOId { get; set; }
        public int MaritialDTOId { get; set; }


        public string? Fotograf { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public bool Durum { get; set; }
        public string? TCKimlik { get; set; }
        public string? DogumTarihi { get; set; }
        public string? MedeniDurum { get; set; }
        public string? EgitimDurumu { get; set; }
        public string? Askerlik { get; set; }
        public string? Gorev { get; set; }
        public string? IseGiris { get; set; }
        public string? IstenCikis { get; set; }
        public string? Maas { get; set; }
        public string? CepTel { get; set; }
        public string? CalismaSuresi { get; set; }
        public string? BaslamaTarihi { get; set; }
        public string? Adres { get; set; }
        public string? EkBilgi { get; set; }

        #region Vacations
        public Vacation2018DTO Vacation2018DTO { get; set; }
        public Vacation2019DTO Vacation2019DTO { get; set; }
        public Vacation2020DTO Vacation2020DTO { get; set; }
        public Vacation2021DTO Vacation2021DTO { get; set; }
        public Vacation2022DTO Vacation2022DTO { get; set; }
        public Vacation2023DTO Vacation2023DTO { get; set; }

        #endregion

        public DepartmentDTO DepartmentDTO { get; set; }
        public SectorDTO SectorDTO { get; set; }
        public EducationDTO EducationDTO { get; set; }
        public MilitaryServiceDTO MilitaryServiceDTO { get; set; }
        public MaritialDTO MaritialDTO { get; set; }

    }
}
