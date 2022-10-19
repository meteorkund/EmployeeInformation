using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Models
{
    public class Employee : BaseEntity
    {
        public Employee(string fotograf, string isim, string soyisim, bool durum, string tcKimlik, string dogumTarihi, string medeniDurum, string egitimDurumu, string askerlik, string departman, string gorev, string iseGiris, string istenCikis, string maas, string cepTel, string calismaSuresi, string baslamaTarihi, string adres, string ekBilgi)
        {
            Fotograf = fotograf;
            Isim = isim;
            Soyisim = soyisim;
            Durum = durum;
            TCKimlik = tcKimlik;
            DogumTarihi = dogumTarihi;
            MedeniDurum = medeniDurum;
            EgitimDurumu = egitimDurumu;
            Askerlik = askerlik;
            Departman = departman;
            Gorev = gorev;
            IseGiris = iseGiris;
            IstenCikis = istenCikis;
            Maas = maas;
            CepTel = cepTel;
            CalismaSuresi = calismaSuresi;
            BaslamaTarihi = baslamaTarihi;
            Adres = adres;
            EkBilgi = ekBilgi;
        }

        public string Fotograf { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public bool Durum { get; set; }
        public string TCKimlik { get; set; }
        public string DogumTarihi { get; set; }
        public string MedeniDurum { get; set; }
        public string EgitimDurumu { get; set; }
        public string Askerlik { get; set; }
        public string Departman { get; set; }
        public string Gorev { get; set; }
        public string IseGiris { get; set; }
        public string IstenCikis { get; set; }
        public string Maas { get; set; }
        public string CepTel { get; set; }
        public string CalismaSuresi { get; set; }
        public string BaslamaTarihi { get; set; }
        public string Adres { get; set; }
        public string EkBilgi { get; set; }

        public Izin2018 izin2018 { get; set; }
        //public izin2019 Izin2019 { get; set; }
        //public izin2020 Izin2020 { get; set; }
        //public izin2021 Izin2021 { get; set; }
        //public izin2022 Izin2022 { get; set; }
        //public izin2023 Izin2023 { get; set; }
        //public izin2024 Izin2024 { get; set; }
    }
}
