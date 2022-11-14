using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.VacationViewModels
{
    public class EmployeeVacation2018VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2018VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2018_C1_Display => SelectedEmployee?.Vacation2018.Ocak2018_C1.ToString();
        public string Ocak2018_C2_Display => SelectedEmployee?.Vacation2018.Ocak2018_C2.ToString();
        public string Ocak2018_C3_Display => SelectedEmployee?.Vacation2018.Ocak2018_C3.ToString();
        public string Ocak2018_C4_Display => SelectedEmployee?.Vacation2018.Ocak2018_C4.ToString();
        public string Ocak2018_C5_Display => SelectedEmployee?.Vacation2018.Ocak2018_C5.ToString();
        public string Ocak2018_C6_Display => SelectedEmployee?.Vacation2018.Ocak2018_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2018_C1_Display => SelectedEmployee?.Vacation2018.Subat2018_C1.ToString();
        public string Subat2018_C2_Display => SelectedEmployee?.Vacation2018.Subat2018_C2.ToString();
        public string Subat2018_C3_Display => SelectedEmployee?.Vacation2018.Subat2018_C3.ToString();
        public string Subat2018_C4_Display => SelectedEmployee?.Vacation2018.Subat2018_C4.ToString();
        public string Subat2018_C5_Display => SelectedEmployee?.Vacation2018.Subat2018_C5.ToString();
        public string Subat2018_C6_Display => SelectedEmployee?.Vacation2018.Subat2018_C6.ToString();
        #endregion

        #region MART
        public string Mart2018_C1_Display => SelectedEmployee?.Vacation2018.Mart2018_C1.ToString();
        public string Mart2018_C2_Display => SelectedEmployee?.Vacation2018.Mart2018_C2.ToString();
        public string Mart2018_C3_Display => SelectedEmployee?.Vacation2018.Mart2018_C3.ToString();
        public string Mart2018_C4_Display => SelectedEmployee?.Vacation2018.Mart2018_C4.ToString();
        public string Mart2018_C5_Display => SelectedEmployee?.Vacation2018.Mart2018_C5.ToString();
        public string Mart2018_C6_Display => SelectedEmployee?.Vacation2018.Mart2018_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2018_C1_Display => SelectedEmployee?.Vacation2018.Nisan2018_C1.ToString();
        public string Nisan2018_C2_Display => SelectedEmployee?.Vacation2018.Nisan2018_C2.ToString();
        public string Nisan2018_C3_Display => SelectedEmployee?.Vacation2018.Nisan2018_C3.ToString();
        public string Nisan2018_C4_Display => SelectedEmployee?.Vacation2018.Nisan2018_C4.ToString();
        public string Nisan2018_C5_Display => SelectedEmployee?.Vacation2018.Nisan2018_C5.ToString();
        public string Nisan2018_C6_Display => SelectedEmployee?.Vacation2018.Nisan2018_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2018_C1_Display => SelectedEmployee?.Vacation2018.Mayis2018_C1.ToString();
        public string Mayis2018_C2_Display => SelectedEmployee?.Vacation2018.Mayis2018_C2.ToString();
        public string Mayis2018_C3_Display => SelectedEmployee?.Vacation2018.Mayis2018_C3.ToString();
        public string Mayis2018_C4_Display => SelectedEmployee?.Vacation2018.Mayis2018_C4.ToString();
        public string Mayis2018_C5_Display => SelectedEmployee?.Vacation2018.Mayis2018_C5.ToString();
        public string Mayis2018_C6_Display => SelectedEmployee?.Vacation2018.Mayis2018_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2018_C1_Display => SelectedEmployee?.Vacation2018.Haziran2018_C1.ToString();
        public string Haziran2018_C2_Display => SelectedEmployee?.Vacation2018.Haziran2018_C2.ToString();
        public string Haziran2018_C3_Display => SelectedEmployee?.Vacation2018.Haziran2018_C3.ToString();
        public string Haziran2018_C4_Display => SelectedEmployee?.Vacation2018.Haziran2018_C4.ToString();
        public string Haziran2018_C5_Display => SelectedEmployee?.Vacation2018.Haziran2018_C5.ToString();
        public string Haziran2018_C6_Display => SelectedEmployee?.Vacation2018.Haziran2018_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2018_C1_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C1.ToString();
        public string Temmuz2018_C2_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C2.ToString();
        public string Temmuz2018_C3_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C3.ToString();
        public string Temmuz2018_C4_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C4.ToString();
        public string Temmuz2018_C5_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C5.ToString();
        public string Temmuz2018_C6_Display => SelectedEmployee?.Vacation2018.Temmuz2018_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2018_C1_Display => SelectedEmployee?.Vacation2018.Agustos2018_C1.ToString();
        public string Agustos2018_C2_Display => SelectedEmployee?.Vacation2018.Agustos2018_C2.ToString();
        public string Agustos2018_C3_Display => SelectedEmployee?.Vacation2018.Agustos2018_C3.ToString();
        public string Agustos2018_C4_Display => SelectedEmployee?.Vacation2018.Agustos2018_C4.ToString();
        public string Agustos2018_C5_Display => SelectedEmployee?.Vacation2018.Agustos2018_C5.ToString();
        public string Agustos2018_C6_Display => SelectedEmployee?.Vacation2018.Agustos2018_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2018_C1_Display => SelectedEmployee?.Vacation2018.Eylul2018_C1.ToString();
        public string Eylul2018_C2_Display => SelectedEmployee?.Vacation2018.Eylul2018_C2.ToString();
        public string Eylul2018_C3_Display => SelectedEmployee?.Vacation2018.Eylul2018_C3.ToString();
        public string Eylul2018_C4_Display => SelectedEmployee?.Vacation2018.Eylul2018_C4.ToString();
        public string Eylul2018_C5_Display => SelectedEmployee?.Vacation2018.Eylul2018_C5.ToString();
        public string Eylul2018_C6_Display => SelectedEmployee?.Vacation2018.Eylul2018_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2018_C1_Display => SelectedEmployee?.Vacation2018.Ekim2018_C1.ToString();
        public string Ekim2018_C2_Display => SelectedEmployee?.Vacation2018.Ekim2018_C2.ToString();
        public string Ekim2018_C3_Display => SelectedEmployee?.Vacation2018.Ekim2018_C3.ToString();
        public string Ekim2018_C4_Display => SelectedEmployee?.Vacation2018.Ekim2018_C4.ToString();
        public string Ekim2018_C5_Display => SelectedEmployee?.Vacation2018.Ekim2018_C5.ToString();
        public string Ekim2018_C6_Display => SelectedEmployee?.Vacation2018.Ekim2018_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2018_C1_Display => SelectedEmployee?.Vacation2018.Kasim2018_C1.ToString();
        public string Kasim2018_C2_Display => SelectedEmployee?.Vacation2018.Kasim2018_C2.ToString();
        public string Kasim2018_C3_Display => SelectedEmployee?.Vacation2018.Kasim2018_C3.ToString();
        public string Kasim2018_C4_Display => SelectedEmployee?.Vacation2018.Kasim2018_C4.ToString();
        public string Kasim2018_C5_Display => SelectedEmployee?.Vacation2018.Kasim2018_C5.ToString();
        public string Kasim2018_C6_Display => SelectedEmployee?.Vacation2018.Kasim2018_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2018_C1_Display => SelectedEmployee?.Vacation2018.Aralik2018_C1.ToString();
        public string Aralik2018_C2_Display => SelectedEmployee?.Vacation2018.Aralik2018_C2.ToString();
        public string Aralik2018_C3_Display => SelectedEmployee?.Vacation2018.Aralik2018_C3.ToString();
        public string Aralik2018_C4_Display => SelectedEmployee?.Vacation2018.Aralik2018_C4.ToString();
        public string Aralik2018_C5_Display => SelectedEmployee?.Vacation2018.Aralik2018_C5.ToString();
        public string Aralik2018_C6_Display => SelectedEmployee?.Vacation2018.Aralik2018_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2018_C1_Display => Toplam2018_C1.ToString();
        public string Toplam2018_C2_Display => Toplam2018_C2.ToString();
        public string Toplam2018_C3_Display => Toplam2018_C3.ToString();
        public string Toplam2018_C4_Display => Toplam2018_C4.ToString();
        public string Toplam2018_C5_Display => Toplam2018_C5.ToString();
        public string Toplam2018_C6_Display => Toplam2018_C6.ToString();

        public int Toplam2018_C1 =>
            Int32.Parse(Ocak2018_C1_Display) +
            Int32.Parse(Subat2018_C1_Display) +
            Int32.Parse(Mart2018_C1_Display) +
            Int32.Parse(Nisan2018_C1_Display) +
            Int32.Parse(Mayis2018_C1_Display) +
            Int32.Parse(Haziran2018_C1_Display) +
            Int32.Parse(Temmuz2018_C1_Display) +
            Int32.Parse(Agustos2018_C1_Display) +
            Int32.Parse(Eylul2018_C1_Display) +
            Int32.Parse(Ekim2018_C1_Display) +
            Int32.Parse(Kasim2018_C1_Display) +
            Int32.Parse(Aralik2018_C1_Display);

        public int Toplam2018_C2 =>
            Int32.Parse(Ocak2018_C2_Display) +
            Int32.Parse(Subat2018_C2_Display) +
            Int32.Parse(Mart2018_C2_Display) +
            Int32.Parse(Nisan2018_C2_Display) +
            Int32.Parse(Mayis2018_C2_Display) +
            Int32.Parse(Haziran2018_C2_Display) +
            Int32.Parse(Temmuz2018_C2_Display) +
            Int32.Parse(Agustos2018_C2_Display) +
            Int32.Parse(Eylul2018_C2_Display) +
            Int32.Parse(Ekim2018_C2_Display) +
            Int32.Parse(Kasim2018_C2_Display) +
            Int32.Parse(Aralik2018_C2_Display);
        public int Toplam2018_C3 =>
            Int32.Parse(Ocak2018_C3_Display) +
            Int32.Parse(Subat2018_C3_Display) +
            Int32.Parse(Mart2018_C3_Display) +
            Int32.Parse(Nisan2018_C3_Display) +
            Int32.Parse(Mayis2018_C3_Display) +
            Int32.Parse(Haziran2018_C3_Display) +
            Int32.Parse(Temmuz2018_C3_Display) +
            Int32.Parse(Agustos2018_C3_Display) +
            Int32.Parse(Eylul2018_C3_Display) +
            Int32.Parse(Ekim2018_C3_Display) +
            Int32.Parse(Kasim2018_C3_Display) +
            Int32.Parse(Aralik2018_C3_Display);
        public int Toplam2018_C4 =>
            Int32.Parse(Ocak2018_C4_Display) +
            Int32.Parse(Subat2018_C4_Display) +
            Int32.Parse(Mart2018_C4_Display) +
            Int32.Parse(Nisan2018_C4_Display) +
            Int32.Parse(Mayis2018_C4_Display) +
            Int32.Parse(Haziran2018_C4_Display) +
            Int32.Parse(Temmuz2018_C4_Display) +
            Int32.Parse(Agustos2018_C4_Display) +
            Int32.Parse(Eylul2018_C4_Display) +
            Int32.Parse(Ekim2018_C4_Display) +
            Int32.Parse(Kasim2018_C4_Display) +
            Int32.Parse(Aralik2018_C4_Display);

        public int Toplam2018_C5 =>
            Int32.Parse(Ocak2018_C5_Display) +
            Int32.Parse(Subat2018_C5_Display) +
            Int32.Parse(Mart2018_C5_Display) +
            Int32.Parse(Nisan2018_C5_Display) +
            Int32.Parse(Mayis2018_C5_Display) +
            Int32.Parse(Haziran2018_C5_Display) +
            Int32.Parse(Temmuz2018_C5_Display) +
            Int32.Parse(Agustos2018_C5_Display) +
            Int32.Parse(Eylul2018_C5_Display) +
            Int32.Parse(Ekim2018_C5_Display) +
            Int32.Parse(Kasim2018_C5_Display) +
            Int32.Parse(Aralik2018_C5_Display);
        public int Toplam2018_C6 =>
            Int32.Parse(Ocak2018_C6_Display) +
            Int32.Parse(Subat2018_C6_Display) +
            Int32.Parse(Mart2018_C6_Display) +
            Int32.Parse(Nisan2018_C6_Display) +
            Int32.Parse(Mayis2018_C6_Display) +
            Int32.Parse(Haziran2018_C6_Display) +
            Int32.Parse(Temmuz2018_C6_Display) +
            Int32.Parse(Agustos2018_C6_Display) +
            Int32.Parse(Eylul2018_C6_Display) +
            Int32.Parse(Ekim2018_C6_Display) +
            Int32.Parse(Kasim2018_C6_Display) +
            Int32.Parse(Aralik2018_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2018_C1_Display));
            OnPropertyChanged(nameof(Ocak2018_C2_Display));
            OnPropertyChanged(nameof(Ocak2018_C3_Display));
            OnPropertyChanged(nameof(Ocak2018_C4_Display));
            OnPropertyChanged(nameof(Ocak2018_C5_Display));
            OnPropertyChanged(nameof(Ocak2018_C6_Display));

            OnPropertyChanged(nameof(Subat2018_C1_Display));
            OnPropertyChanged(nameof(Subat2018_C2_Display));
            OnPropertyChanged(nameof(Subat2018_C3_Display));
            OnPropertyChanged(nameof(Subat2018_C4_Display));
            OnPropertyChanged(nameof(Subat2018_C5_Display));
            OnPropertyChanged(nameof(Subat2018_C6_Display));

            OnPropertyChanged(nameof(Mart2018_C1_Display));
            OnPropertyChanged(nameof(Mart2018_C2_Display));
            OnPropertyChanged(nameof(Mart2018_C3_Display));
            OnPropertyChanged(nameof(Mart2018_C4_Display));
            OnPropertyChanged(nameof(Mart2018_C5_Display));
            OnPropertyChanged(nameof(Mart2018_C6_Display));

            OnPropertyChanged(nameof(Nisan2018_C1_Display));
            OnPropertyChanged(nameof(Nisan2018_C2_Display));
            OnPropertyChanged(nameof(Nisan2018_C3_Display));
            OnPropertyChanged(nameof(Nisan2018_C4_Display));
            OnPropertyChanged(nameof(Nisan2018_C5_Display));
            OnPropertyChanged(nameof(Nisan2018_C6_Display));

            OnPropertyChanged(nameof(Mayis2018_C1_Display));
            OnPropertyChanged(nameof(Mayis2018_C2_Display));
            OnPropertyChanged(nameof(Mayis2018_C3_Display));
            OnPropertyChanged(nameof(Mayis2018_C4_Display));
            OnPropertyChanged(nameof(Mayis2018_C5_Display));
            OnPropertyChanged(nameof(Mayis2018_C6_Display));

            OnPropertyChanged(nameof(Haziran2018_C1_Display));
            OnPropertyChanged(nameof(Haziran2018_C2_Display));
            OnPropertyChanged(nameof(Haziran2018_C3_Display));
            OnPropertyChanged(nameof(Haziran2018_C4_Display));
            OnPropertyChanged(nameof(Haziran2018_C5_Display));
            OnPropertyChanged(nameof(Haziran2018_C6_Display));

            OnPropertyChanged(nameof(Temmuz2018_C1_Display));
            OnPropertyChanged(nameof(Temmuz2018_C2_Display));
            OnPropertyChanged(nameof(Temmuz2018_C3_Display));
            OnPropertyChanged(nameof(Temmuz2018_C4_Display));
            OnPropertyChanged(nameof(Temmuz2018_C5_Display));
            OnPropertyChanged(nameof(Temmuz2018_C6_Display));

            OnPropertyChanged(nameof(Agustos2018_C1_Display));
            OnPropertyChanged(nameof(Agustos2018_C2_Display));
            OnPropertyChanged(nameof(Agustos2018_C3_Display));
            OnPropertyChanged(nameof(Agustos2018_C4_Display));
            OnPropertyChanged(nameof(Agustos2018_C5_Display));
            OnPropertyChanged(nameof(Agustos2018_C6_Display));

            OnPropertyChanged(nameof(Eylul2018_C1_Display));
            OnPropertyChanged(nameof(Eylul2018_C2_Display));
            OnPropertyChanged(nameof(Eylul2018_C3_Display));
            OnPropertyChanged(nameof(Eylul2018_C4_Display));
            OnPropertyChanged(nameof(Eylul2018_C5_Display));
            OnPropertyChanged(nameof(Eylul2018_C6_Display));

            OnPropertyChanged(nameof(Ekim2018_C1_Display));
            OnPropertyChanged(nameof(Ekim2018_C2_Display));
            OnPropertyChanged(nameof(Ekim2018_C3_Display));
            OnPropertyChanged(nameof(Ekim2018_C4_Display));
            OnPropertyChanged(nameof(Ekim2018_C5_Display));
            OnPropertyChanged(nameof(Ekim2018_C6_Display));

            OnPropertyChanged(nameof(Kasim2018_C1_Display));
            OnPropertyChanged(nameof(Kasim2018_C2_Display));
            OnPropertyChanged(nameof(Kasim2018_C3_Display));
            OnPropertyChanged(nameof(Kasim2018_C4_Display));
            OnPropertyChanged(nameof(Kasim2018_C5_Display));
            OnPropertyChanged(nameof(Kasim2018_C6_Display));

            OnPropertyChanged(nameof(Aralik2018_C1_Display));
            OnPropertyChanged(nameof(Aralik2018_C2_Display));
            OnPropertyChanged(nameof(Aralik2018_C3_Display));
            OnPropertyChanged(nameof(Aralik2018_C4_Display));
            OnPropertyChanged(nameof(Aralik2018_C5_Display));
            OnPropertyChanged(nameof(Aralik2018_C6_Display));

            OnPropertyChanged(nameof(Toplam2018_C1_Display));
            OnPropertyChanged(nameof(Toplam2018_C2_Display));
            OnPropertyChanged(nameof(Toplam2018_C3_Display));
            OnPropertyChanged(nameof(Toplam2018_C4_Display));
            OnPropertyChanged(nameof(Toplam2018_C5_Display));
            OnPropertyChanged(nameof(Toplam2018_C6_Display));

        }

    }
}
