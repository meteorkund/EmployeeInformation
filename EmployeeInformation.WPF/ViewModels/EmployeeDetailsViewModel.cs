using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeDetailsViewModel : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        private Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public bool HasSelectedEmployee => SelectedEmployee != null;
        public string Isim => SelectedEmployee?.Isim ?? "Lütfen bir personel seçin.";
        public string Soyisim => SelectedEmployee?.Soyisim;
        public string FotografDisplay => SelectedEmployee?.Fotograf;
        public bool DurumDisplay => (bool)(SelectedEmployee?.Durum);
        public string KimlikDisplay => SelectedEmployee?.TCKimlik;
        public string DogumTarihiDisplay => SelectedEmployee?.DogumTarihi;
        public string MedeniDurumDisplay => SelectedEmployee?.MedeniDurum;
        public string EgitimDurumuDisplay => SelectedEmployee?.EgitimDurumu;
        public string AskerlikDisplay => SelectedEmployee?.Askerlik;
        public string DepartmanDisplay => SelectedEmployee?.Departman;
        public string GorevDisplay => SelectedEmployee?.Gorev;
        public string IseGirisDisplay => SelectedEmployee?.IseGiris;
        public string IstenCikisDisplay => (string.IsNullOrEmpty(SelectedEmployee?.IstenCikis) ? "-" : SelectedEmployee?.IstenCikis);
        public string MaasDisplay => SelectedEmployee?.Maas;
        public string CepTelDisplay => SelectedEmployee?.CepTel;
        public string CalismaSuresiDisplay => ($"{days} gün, {months} ay, {years} yıl.");
        public string BaslamaTarihiDisplay => SelectedEmployee?.BaslamaTarihi;
        public string AdresDisplay => SelectedEmployee?.Adres;
        public string EkBilgiDisplay => SelectedEmployee?.EkBilgi;
        public int Ocak2018_c1_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c1);
        public int Ocak2018_c2_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c2);
        public int Ocak2018_c3_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c3);
        public int Ocak2018_c4_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c4);
        public int Ocak2018_c5_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c5);
        public int Ocak2018_c6_Display => (int)(SelectedEmployee?.Vacation2018?.Ocak2018_c6);


        public EmployeeDetailsViewModel(SelectedEmployeeStore selectedCustomerStore)
        {
            _selectedEmployeeStore = selectedCustomerStore;

            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;
        }


        int years, months, days;
        public void DateTimeCalculate()
        {
            if (BaslamaTarihiDisplay is not null)
            {
                string date = BaslamaTarihiDisplay;
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(0, 2);

                int x_year = Int32.Parse(year);
                int x_month = Int32.Parse(month);
                int x_day = Int32.Parse(day);

                DateTime dt2 = DateTime.Now;
                DateTime dt1 = new DateTime(x_year, x_month, x_day);

                years = 0;
                while (dt1.AddYears(1) < dt2)
                {
                    years++;
                    dt1 = dt1.AddYears(1);
                }

                months = 0;
                while (dt1.AddMonths(1) < dt2)
                {
                    months++;
                    dt1 = dt1.AddMonths(1);
                }

                days = (int)Math.Floor(dt2.Subtract(dt1).TotalDays);
            }
        }

        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }

        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            DateTimeCalculate();

            OnPropertyChanged(nameof(HasSelectedEmployee));
            OnPropertyChanged(nameof(FotografDisplay));
            OnPropertyChanged(nameof(Isim));
            OnPropertyChanged(nameof(Soyisim));
            OnPropertyChanged(nameof(DurumDisplay));
            OnPropertyChanged(nameof(KimlikDisplay));
            OnPropertyChanged(nameof(DogumTarihiDisplay));
            OnPropertyChanged(nameof(MedeniDurumDisplay));
            OnPropertyChanged(nameof(EgitimDurumuDisplay));
            OnPropertyChanged(nameof(AskerlikDisplay));
            OnPropertyChanged(nameof(DepartmanDisplay));
            OnPropertyChanged(nameof(GorevDisplay));
            OnPropertyChanged(nameof(IseGirisDisplay));
            OnPropertyChanged(nameof(IstenCikisDisplay));
            OnPropertyChanged(nameof(MaasDisplay));
            OnPropertyChanged(nameof(CepTelDisplay));
            OnPropertyChanged(nameof(CalismaSuresiDisplay));
            OnPropertyChanged(nameof(BaslamaTarihiDisplay));
            OnPropertyChanged(nameof(AdresDisplay));
            OnPropertyChanged(nameof(EkBilgiDisplay));
            OnPropertyChanged(nameof(Ocak2018_c1_Display));
            OnPropertyChanged(nameof(Ocak2018_c2_Display));
            OnPropertyChanged(nameof(Ocak2018_c3_Display));
            OnPropertyChanged(nameof(Ocak2018_c4_Display));
            OnPropertyChanged(nameof(Ocak2018_c5_Display));
            OnPropertyChanged(nameof(Ocak2018_c6_Display));
        }
    }
}
