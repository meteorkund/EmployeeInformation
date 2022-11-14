using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.VacationViewModels;
using GalaSoft.MvvmLight.Command;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace EmployeeInformation.WPF.ViewModels;

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


    public string DepartmanDisplay => SelectedEmployee?.Departman.DepartmentName;
    public string GorevDisplay => SelectedEmployee?.Sector.SectorName;
    public string MedeniDurumDisplay => SelectedEmployee?.Maritial.MaritialStatus;
    public string EgitimDurumuDisplay => SelectedEmployee?.Education.EducationDegree;
    public string AskerlikDisplay => SelectedEmployee?.Military.MilitaryStatus;



    public string IseGirisDisplay => SelectedEmployee?.IseGiris;
    public string IstenCikisDisplay => SelectedEmployee?.IstenCikis;
    public string MaasDisplay => SelectedEmployee?.Maas;
    public string CepTelDisplay => SelectedEmployee?.CepTel;
    public string CalismaSuresiDisplay => CalismaSuresiCalculated;
    public string BaslamaTarihiDisplay => SelectedEmployee?.BaslamaTarihi;
    public string AdresDisplay => SelectedEmployee?.Adres;
    public string EkBilgiDisplay => SelectedEmployee?.EkBilgi;


    private bool _showButton;

    public bool ShowButton
    {
        get { return _showButton; }
        set
        {
            _showButton = value;
            OnPropertyChanged(nameof(ShowButton));
        }
    }


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

    #region OPEN WHATSAPP
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
    #endregion

    int years, months, days;
    string CalismaSuresiCalculated;
    public void DateTimeCalculate()
    {
        if (string.IsNullOrEmpty(IstenCikisDisplay))
        {
            if (!string.IsNullOrEmpty(BaslamaTarihiDisplay))
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
                CalismaSuresiCalculated = ($"{days} gün, {months} ay, {years} yıl.");
            }
            else { CalismaSuresiCalculated = string.Empty; }
        }
        else
        {
            string date = BaslamaTarihiDisplay;
            string year = date.Substring(6, 4);
            string month = date.Substring(3, 2);
            string day = date.Substring(0, 2);

            int x_year = Int32.Parse(year);
            int x_month = Int32.Parse(month);
            int x_day = Int32.Parse(day);


            string dateCikis = IstenCikisDisplay;
            string yearCikis = dateCikis.Substring(6, 4);
            string monthCikis = dateCikis.Substring(3, 2);
            string dayCikis = dateCikis.Substring(0, 2);

            int y_year = Int32.Parse(yearCikis);
            int y_month = Int32.Parse(monthCikis);
            int y_day = Int32.Parse(dayCikis);

            DateTime date2 = new DateTime(y_year, y_month, y_day);
            DateTime date1 = new DateTime(x_year, x_month, x_day);

            years = 0;
            while (date1.AddYears(1) < date2)
            {
                years++;
                date1 = date1.AddYears(1);
            }

            months = 0;
            while (date1.AddMonths(1) < date2)
            {
                months++;
                date1 = date1.AddMonths(1);
            }

            days = (int)Math.Floor(date2.Subtract(date1).TotalDays);
            CalismaSuresiCalculated = ($"{days} gün, {months} ay, {years} yıl.");
        }


    }

    public void IsNumberEmpty()
    {
        if (!string.IsNullOrEmpty(CepTelDisplay))
            ShowButton = true;
        else
            ShowButton = false;
    }

    protected override void Dispose()
    {
        _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
        base.Dispose();
    }

    private void SelectedEmployeeStore_SelectedEmployeeChanged()
    {
        DateTimeCalculate();
        IsNumberEmpty();

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
