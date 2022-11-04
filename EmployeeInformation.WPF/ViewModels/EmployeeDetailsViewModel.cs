using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Components;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.VacationViewModels;
using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeDetailsViewModel : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;

        public EmployeeVacation2018VM EmployeeVacation2018VM { get; }
        public EmployeeVacation2019VM EmployeeVacation2019VM { get; }
        public EmployeeVacation2020VM EmployeeVacation2020VM { get; }
        public EmployeeVacation2021VM EmployeeVacation2021VM { get; }
        public EmployeeVacation2022VM EmployeeVacation2022VM { get; }
        public EmployeeVacation2023VM EmployeeVacation2023VM { get; }


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
        public string DepartmanDisplay => SelectedEmployee?.Departman.DepartmentName;
        public string GorevDisplay => SelectedEmployee?.Gorev;
        public string IseGirisDisplay => SelectedEmployee?.IseGiris;
        public string IstenCikisDisplay => (string.IsNullOrEmpty(SelectedEmployee?.IstenCikis) ? "-" : SelectedEmployee?.IstenCikis);
        public string MaasDisplay => SelectedEmployee?.Maas;
        public string CepTelDisplay => SelectedEmployee?.CepTel;
        public string CalismaSuresiDisplay => ($"{days} gün, {months} ay, {years} yıl.");
        public string BaslamaTarihiDisplay => SelectedEmployee?.BaslamaTarihi;
        public string AdresDisplay => SelectedEmployee?.Adres;
        public string EkBilgiDisplay => SelectedEmployee?.EkBilgi;

        public RelayCommand OpenWappCommand { get; set; }

        public EmployeeDetailsViewModel(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;

            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

            RegisterCommands();


            EmployeeVacation2018VM = new EmployeeVacation2018VM(selectedEmployeeStore);
            EmployeeVacation2019VM = new EmployeeVacation2019VM(selectedEmployeeStore);
            EmployeeVacation2020VM = new EmployeeVacation2020VM(selectedEmployeeStore);
            EmployeeVacation2021VM = new EmployeeVacation2021VM(selectedEmployeeStore);
            EmployeeVacation2022VM = new EmployeeVacation2022VM(selectedEmployeeStore);
            EmployeeVacation2023VM = new EmployeeVacation2023VM(selectedEmployeeStore);

        }


        private void RegisterCommands()
        {
            OpenWappCommand = new RelayCommand(ExecuteOpenWappWeb);
        }

        private void ExecuteOpenWappWeb()
        {
            string whatsAppTel = CepTelDisplay;


            if (CepTelDisplay == null)
                MessageBox.Show("Kayıtlı telefon numarası bulunamadı!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);


            else
            {
                try
                {
                    string replacedWhatsAppTel = whatsAppTel.Replace("(", string.Empty)
                                                     .Replace(")", string.Empty)
                                                     .Replace("-", string.Empty);

                    if (replacedWhatsAppTel.Length == 10)
                    {
                        string wappURL = $"https://wa.me/+90{replacedWhatsAppTel}";
                        OpenURL(wappURL);
                    }

                    else
                    {
                        MessageBox.Show("Hatalı telefon numarası!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("BEklenmeyen bir hatayla karşılaşıldı!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }



        }

        private void OpenURL(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
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

        }
    }
}
