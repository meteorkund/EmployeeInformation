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
        public Employee(Guid id, string fotograf, string isim, string soyisim, bool durum, string tcKimlik, string dogumTarihi, string medeniDurum, string egitimDurumu, string askerlik, string departman, string gorev, string iseGiris, string istenCikis, string maas, string cepTel, string calismaSuresi, string baslamaTarihi, string adres, string ekBilgi)
        {
            Id = id;
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

        public Guid Id { get; }
        public string Fotograf { get;  }
        public string Isim { get;  }
        public string Soyisim { get; }
        public bool Durum { get; set; }
        public string TCKimlik { get;  }
        public string DogumTarihi { get;  }
        public string MedeniDurum { get;  }
        public string EgitimDurumu { get; }
        public string Askerlik { get;  }
        public string Departman { get;  }
        public string Gorev { get;  }
        public string IseGiris { get;  }
        public string IstenCikis { get; }
        public string Maas { get; }
        public string CepTel { get; }
        public string CalismaSuresi { get; }
        public string BaslamaTarihi { get; }
        public string Adres { get; }
        public string EkBilgi { get; }

        public Izin2018 izin2018 { get; }
        //public izin2019 Izin2019 { get; set; }
        //public izin2020 Izin2020 { get; set; }
        //public izin2021 Izin2021 { get; set; }
        //public izin2022 Izin2022 { get; set; }
        //public izin2023 Izin2023 { get; set; }
        //public izin2024 Izin2024 { get; set; }
    }
}
