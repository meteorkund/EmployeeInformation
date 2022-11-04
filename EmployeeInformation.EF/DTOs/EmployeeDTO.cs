﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs
{
    public class EmployeeDTO : BaseDTO
    {
        public int Id { get; set; }
        public int DepartmentDTOId { get; set; }
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

        public Vacation2018DTO Vacation2018DTO { get; set; }
        public Vacation2019DTO Vacation2019DTO { get; set; }
        public Vacation2020DTO Vacation2020DTO { get; set; }
        public Vacation2021DTO Vacation2021DTO { get; set; }
        public Vacation2022DTO Vacation2022DTO { get; set; }
        public Vacation2023DTO Vacation2023DTO { get; set; }

        public DepartmentDTO DepartmentDTO { get; set; }

    }
}
