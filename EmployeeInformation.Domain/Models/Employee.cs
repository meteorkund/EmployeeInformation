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
        public Employee(int id, string fotograf, string isim, string soyisim, bool durum, string tcKimlik, string dogumTarihi, string medeniDurum, string egitimDurumu, string askerlik, string departman, string gorev, string iseGiris, string istenCikis, string maas, string cepTel, string calismaSuresi, string baslamaTarihi, string adres, string ekBilgi, DateTime createdDate, 
          Vacation2018 vacation2018, 
          Vacation2019 vacation2019,
          Vacation2020 vacation2020,
          Vacation2021 vacation2021,
          Vacation2022 vacation2022,
          Vacation2023 vacation2023)
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
            Vacation2018 = vacation2018;
            Vacation2019 = vacation2019;
            Vacation2020 = vacation2020;
            Vacation2021 = vacation2021;
            Vacation2022 = vacation2022;
            Vacation2023 = vacation2023;
            CreatedDate = createdDate;
        }

        public int Id { get; }
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

        public Vacation2018 Vacation2018 { get; }
        public Vacation2019 Vacation2019 { get; }
        public Vacation2020 Vacation2020 { get; }
        public Vacation2021 Vacation2021 { get; }
        public Vacation2022 Vacation2022 { get; }
        public Vacation2023 Vacation2023 { get; }

    }
}
