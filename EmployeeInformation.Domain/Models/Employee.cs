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

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Fotograf { get; set;  }
        public string Isim { get; set;  }
        public string Soyisim { get; set; }
        public bool Durum { get; set; }
        public string TCKimlik { get; set;  }
        public string DogumTarihi { get; set;  }
        public string MedeniDurum { get; set;  }
        public string EgitimDurumu { get; set; }
        public string Askerlik { get; set;  }
        public string Gorev { get; set;  }
        public string IseGiris { get; set;  }
        public string IstenCikis { get; set; }
        public string Maas { get; set; }
        public string CepTel { get; set; }
        public string CalismaSuresi { get; set; }
        public string BaslamaTarihi { get; set; }
        public string Adres { get; set; }
        public string EkBilgi { get; set; }

        public Vacation2018 Vacation2018 { get; set; }
        public Vacation2019 Vacation2019 { get; set; }
        public Vacation2020 Vacation2020 { get; set; }
        public Vacation2021 Vacation2021 { get; set; }
        public Vacation2022 Vacation2022 { get; set; }
        public Vacation2023 Vacation2023 { get; set; }

        public Department Departman { get; set; }
        public Sector Sector { get; set; }

    }
}
