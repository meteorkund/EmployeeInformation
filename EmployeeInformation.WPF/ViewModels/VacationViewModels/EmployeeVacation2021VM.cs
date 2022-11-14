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
    public class EmployeeVacation2021VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2021VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2021_C1_Display => SelectedEmployee?.Vacation2021.Ocak2021_C1.ToString();
        public string Ocak2021_C2_Display => SelectedEmployee?.Vacation2021.Ocak2021_C2.ToString();
        public string Ocak2021_C3_Display => SelectedEmployee?.Vacation2021.Ocak2021_C3.ToString();
        public string Ocak2021_C4_Display => SelectedEmployee?.Vacation2021.Ocak2021_C4.ToString();
        public string Ocak2021_C5_Display => SelectedEmployee?.Vacation2021.Ocak2021_C5.ToString();
        public string Ocak2021_C6_Display => SelectedEmployee?.Vacation2021.Ocak2021_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2021_C1_Display => SelectedEmployee?.Vacation2021.Subat2021_C1.ToString();
        public string Subat2021_C2_Display => SelectedEmployee?.Vacation2021.Subat2021_C2.ToString();
        public string Subat2021_C3_Display => SelectedEmployee?.Vacation2021.Subat2021_C3.ToString();
        public string Subat2021_C4_Display => SelectedEmployee?.Vacation2021.Subat2021_C4.ToString();
        public string Subat2021_C5_Display => SelectedEmployee?.Vacation2021.Subat2021_C5.ToString();
        public string Subat2021_C6_Display => SelectedEmployee?.Vacation2021.Subat2021_C6.ToString();
        #endregion

        #region MART
        public string Mart2021_C1_Display => SelectedEmployee?.Vacation2021.Mart2021_C1.ToString();
        public string Mart2021_C2_Display => SelectedEmployee?.Vacation2021.Mart2021_C2.ToString();
        public string Mart2021_C3_Display => SelectedEmployee?.Vacation2021.Mart2021_C3.ToString();
        public string Mart2021_C4_Display => SelectedEmployee?.Vacation2021.Mart2021_C4.ToString();
        public string Mart2021_C5_Display => SelectedEmployee?.Vacation2021.Mart2021_C5.ToString();
        public string Mart2021_C6_Display => SelectedEmployee?.Vacation2021.Mart2021_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2021_C1_Display => SelectedEmployee?.Vacation2021.Nisan2021_C1.ToString();
        public string Nisan2021_C2_Display => SelectedEmployee?.Vacation2021.Nisan2021_C2.ToString();
        public string Nisan2021_C3_Display => SelectedEmployee?.Vacation2021.Nisan2021_C3.ToString();
        public string Nisan2021_C4_Display => SelectedEmployee?.Vacation2021.Nisan2021_C4.ToString();
        public string Nisan2021_C5_Display => SelectedEmployee?.Vacation2021.Nisan2021_C5.ToString();
        public string Nisan2021_C6_Display => SelectedEmployee?.Vacation2021.Nisan2021_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2021_C1_Display => SelectedEmployee?.Vacation2021.Mayis2021_C1.ToString();
        public string Mayis2021_C2_Display => SelectedEmployee?.Vacation2021.Mayis2021_C2.ToString();
        public string Mayis2021_C3_Display => SelectedEmployee?.Vacation2021.Mayis2021_C3.ToString();
        public string Mayis2021_C4_Display => SelectedEmployee?.Vacation2021.Mayis2021_C4.ToString();
        public string Mayis2021_C5_Display => SelectedEmployee?.Vacation2021.Mayis2021_C5.ToString();
        public string Mayis2021_C6_Display => SelectedEmployee?.Vacation2021.Mayis2021_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2021_C1_Display => SelectedEmployee?.Vacation2021.Haziran2021_C1.ToString();
        public string Haziran2021_C2_Display => SelectedEmployee?.Vacation2021.Haziran2021_C2.ToString();
        public string Haziran2021_C3_Display => SelectedEmployee?.Vacation2021.Haziran2021_C3.ToString();
        public string Haziran2021_C4_Display => SelectedEmployee?.Vacation2021.Haziran2021_C4.ToString();
        public string Haziran2021_C5_Display => SelectedEmployee?.Vacation2021.Haziran2021_C5.ToString();
        public string Haziran2021_C6_Display => SelectedEmployee?.Vacation2021.Haziran2021_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2021_C1_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C1.ToString();
        public string Temmuz2021_C2_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C2.ToString();
        public string Temmuz2021_C3_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C3.ToString();
        public string Temmuz2021_C4_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C4.ToString();
        public string Temmuz2021_C5_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C5.ToString();
        public string Temmuz2021_C6_Display => SelectedEmployee?.Vacation2021.Temmuz2021_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2021_C1_Display => SelectedEmployee?.Vacation2021.Agustos2021_C1.ToString();
        public string Agustos2021_C2_Display => SelectedEmployee?.Vacation2021.Agustos2021_C2.ToString();
        public string Agustos2021_C3_Display => SelectedEmployee?.Vacation2021.Agustos2021_C3.ToString();
        public string Agustos2021_C4_Display => SelectedEmployee?.Vacation2021.Agustos2021_C4.ToString();
        public string Agustos2021_C5_Display => SelectedEmployee?.Vacation2021.Agustos2021_C5.ToString();
        public string Agustos2021_C6_Display => SelectedEmployee?.Vacation2021.Agustos2021_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2021_C1_Display => SelectedEmployee?.Vacation2021.Eylul2021_C1.ToString();
        public string Eylul2021_C2_Display => SelectedEmployee?.Vacation2021.Eylul2021_C2.ToString();
        public string Eylul2021_C3_Display => SelectedEmployee?.Vacation2021.Eylul2021_C3.ToString();
        public string Eylul2021_C4_Display => SelectedEmployee?.Vacation2021.Eylul2021_C4.ToString();
        public string Eylul2021_C5_Display => SelectedEmployee?.Vacation2021.Eylul2021_C5.ToString();
        public string Eylul2021_C6_Display => SelectedEmployee?.Vacation2021.Eylul2021_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2021_C1_Display => SelectedEmployee?.Vacation2021.Ekim2021_C1.ToString();
        public string Ekim2021_C2_Display => SelectedEmployee?.Vacation2021.Ekim2021_C2.ToString();
        public string Ekim2021_C3_Display => SelectedEmployee?.Vacation2021.Ekim2021_C3.ToString();
        public string Ekim2021_C4_Display => SelectedEmployee?.Vacation2021.Ekim2021_C4.ToString();
        public string Ekim2021_C5_Display => SelectedEmployee?.Vacation2021.Ekim2021_C5.ToString();
        public string Ekim2021_C6_Display => SelectedEmployee?.Vacation2021.Ekim2021_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2021_C1_Display => SelectedEmployee?.Vacation2021.Kasim2021_C1.ToString();
        public string Kasim2021_C2_Display => SelectedEmployee?.Vacation2021.Kasim2021_C2.ToString();
        public string Kasim2021_C3_Display => SelectedEmployee?.Vacation2021.Kasim2021_C3.ToString();
        public string Kasim2021_C4_Display => SelectedEmployee?.Vacation2021.Kasim2021_C4.ToString();
        public string Kasim2021_C5_Display => SelectedEmployee?.Vacation2021.Kasim2021_C5.ToString();
        public string Kasim2021_C6_Display => SelectedEmployee?.Vacation2021.Kasim2021_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2021_C1_Display => SelectedEmployee?.Vacation2021.Aralik2021_C1.ToString();
        public string Aralik2021_C2_Display => SelectedEmployee?.Vacation2021.Aralik2021_C2.ToString();
        public string Aralik2021_C3_Display => SelectedEmployee?.Vacation2021.Aralik2021_C3.ToString();
        public string Aralik2021_C4_Display => SelectedEmployee?.Vacation2021.Aralik2021_C4.ToString();
        public string Aralik2021_C5_Display => SelectedEmployee?.Vacation2021.Aralik2021_C5.ToString();
        public string Aralik2021_C6_Display => SelectedEmployee?.Vacation2021.Aralik2021_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2021_C1_Display => Toplam2021_C1.ToString();
        public string Toplam2021_C2_Display => Toplam2021_C2.ToString();
        public string Toplam2021_C3_Display => Toplam2021_C3.ToString();
        public string Toplam2021_C4_Display => Toplam2021_C4.ToString();
        public string Toplam2021_C5_Display => Toplam2021_C5.ToString();
        public string Toplam2021_C6_Display => Toplam2021_C6.ToString();

        public int Toplam2021_C1 =>
            Int32.Parse(Ocak2021_C1_Display) +
            Int32.Parse(Subat2021_C1_Display) +
            Int32.Parse(Mart2021_C1_Display) +
            Int32.Parse(Nisan2021_C1_Display) +
            Int32.Parse(Mayis2021_C1_Display) +
            Int32.Parse(Haziran2021_C1_Display) +
            Int32.Parse(Temmuz2021_C1_Display) +
            Int32.Parse(Agustos2021_C1_Display) +
            Int32.Parse(Eylul2021_C1_Display) +
            Int32.Parse(Ekim2021_C1_Display) +
            Int32.Parse(Kasim2021_C1_Display) +
            Int32.Parse(Aralik2021_C1_Display);

        public int Toplam2021_C2 =>
            Int32.Parse(Ocak2021_C2_Display) +
            Int32.Parse(Subat2021_C2_Display) +
            Int32.Parse(Mart2021_C2_Display) +
            Int32.Parse(Nisan2021_C2_Display) +
            Int32.Parse(Mayis2021_C2_Display) +
            Int32.Parse(Haziran2021_C2_Display) +
            Int32.Parse(Temmuz2021_C2_Display) +
            Int32.Parse(Agustos2021_C2_Display) +
            Int32.Parse(Eylul2021_C2_Display) +
            Int32.Parse(Ekim2021_C2_Display) +
            Int32.Parse(Kasim2021_C2_Display) +
            Int32.Parse(Aralik2021_C2_Display);
        public int Toplam2021_C3 =>
            Int32.Parse(Ocak2021_C3_Display) +
            Int32.Parse(Subat2021_C3_Display) +
            Int32.Parse(Mart2021_C3_Display) +
            Int32.Parse(Nisan2021_C3_Display) +
            Int32.Parse(Mayis2021_C3_Display) +
            Int32.Parse(Haziran2021_C3_Display) +
            Int32.Parse(Temmuz2021_C3_Display) +
            Int32.Parse(Agustos2021_C3_Display) +
            Int32.Parse(Eylul2021_C3_Display) +
            Int32.Parse(Ekim2021_C3_Display) +
            Int32.Parse(Kasim2021_C3_Display) +
            Int32.Parse(Aralik2021_C3_Display);
        public int Toplam2021_C4 =>
            Int32.Parse(Ocak2021_C4_Display) +
            Int32.Parse(Subat2021_C4_Display) +
            Int32.Parse(Mart2021_C4_Display) +
            Int32.Parse(Nisan2021_C4_Display) +
            Int32.Parse(Mayis2021_C4_Display) +
            Int32.Parse(Haziran2021_C4_Display) +
            Int32.Parse(Temmuz2021_C4_Display) +
            Int32.Parse(Agustos2021_C4_Display) +
            Int32.Parse(Eylul2021_C4_Display) +
            Int32.Parse(Ekim2021_C4_Display) +
            Int32.Parse(Kasim2021_C4_Display) +
            Int32.Parse(Aralik2021_C4_Display);

        public int Toplam2021_C5 =>
            Int32.Parse(Ocak2021_C5_Display) +
            Int32.Parse(Subat2021_C5_Display) +
            Int32.Parse(Mart2021_C5_Display) +
            Int32.Parse(Nisan2021_C5_Display) +
            Int32.Parse(Mayis2021_C5_Display) +
            Int32.Parse(Haziran2021_C5_Display) +
            Int32.Parse(Temmuz2021_C5_Display) +
            Int32.Parse(Agustos2021_C5_Display) +
            Int32.Parse(Eylul2021_C5_Display) +
            Int32.Parse(Ekim2021_C5_Display) +
            Int32.Parse(Kasim2021_C5_Display) +
            Int32.Parse(Aralik2021_C5_Display);
        public int Toplam2021_C6 =>
            Int32.Parse(Ocak2021_C6_Display) +
            Int32.Parse(Subat2021_C6_Display) +
            Int32.Parse(Mart2021_C6_Display) +
            Int32.Parse(Nisan2021_C6_Display) +
            Int32.Parse(Mayis2021_C6_Display) +
            Int32.Parse(Haziran2021_C6_Display) +
            Int32.Parse(Temmuz2021_C6_Display) +
            Int32.Parse(Agustos2021_C6_Display) +
            Int32.Parse(Eylul2021_C6_Display) +
            Int32.Parse(Ekim2021_C6_Display) +
            Int32.Parse(Kasim2021_C6_Display) +
            Int32.Parse(Aralik2021_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2021_C1_Display));
            OnPropertyChanged(nameof(Ocak2021_C2_Display));
            OnPropertyChanged(nameof(Ocak2021_C3_Display));
            OnPropertyChanged(nameof(Ocak2021_C4_Display));
            OnPropertyChanged(nameof(Ocak2021_C5_Display));
            OnPropertyChanged(nameof(Ocak2021_C6_Display));

            OnPropertyChanged(nameof(Subat2021_C1_Display));
            OnPropertyChanged(nameof(Subat2021_C2_Display));
            OnPropertyChanged(nameof(Subat2021_C3_Display));
            OnPropertyChanged(nameof(Subat2021_C4_Display));
            OnPropertyChanged(nameof(Subat2021_C5_Display));
            OnPropertyChanged(nameof(Subat2021_C6_Display));

            OnPropertyChanged(nameof(Mart2021_C1_Display));
            OnPropertyChanged(nameof(Mart2021_C2_Display));
            OnPropertyChanged(nameof(Mart2021_C3_Display));
            OnPropertyChanged(nameof(Mart2021_C4_Display));
            OnPropertyChanged(nameof(Mart2021_C5_Display));
            OnPropertyChanged(nameof(Mart2021_C6_Display));

            OnPropertyChanged(nameof(Nisan2021_C1_Display));
            OnPropertyChanged(nameof(Nisan2021_C2_Display));
            OnPropertyChanged(nameof(Nisan2021_C3_Display));
            OnPropertyChanged(nameof(Nisan2021_C4_Display));
            OnPropertyChanged(nameof(Nisan2021_C5_Display));
            OnPropertyChanged(nameof(Nisan2021_C6_Display));

            OnPropertyChanged(nameof(Mayis2021_C1_Display));
            OnPropertyChanged(nameof(Mayis2021_C2_Display));
            OnPropertyChanged(nameof(Mayis2021_C3_Display));
            OnPropertyChanged(nameof(Mayis2021_C4_Display));
            OnPropertyChanged(nameof(Mayis2021_C5_Display));
            OnPropertyChanged(nameof(Mayis2021_C6_Display));

            OnPropertyChanged(nameof(Haziran2021_C1_Display));
            OnPropertyChanged(nameof(Haziran2021_C2_Display));
            OnPropertyChanged(nameof(Haziran2021_C3_Display));
            OnPropertyChanged(nameof(Haziran2021_C4_Display));
            OnPropertyChanged(nameof(Haziran2021_C5_Display));
            OnPropertyChanged(nameof(Haziran2021_C6_Display));

            OnPropertyChanged(nameof(Temmuz2021_C1_Display));
            OnPropertyChanged(nameof(Temmuz2021_C2_Display));
            OnPropertyChanged(nameof(Temmuz2021_C3_Display));
            OnPropertyChanged(nameof(Temmuz2021_C4_Display));
            OnPropertyChanged(nameof(Temmuz2021_C5_Display));
            OnPropertyChanged(nameof(Temmuz2021_C6_Display));

            OnPropertyChanged(nameof(Agustos2021_C1_Display));
            OnPropertyChanged(nameof(Agustos2021_C2_Display));
            OnPropertyChanged(nameof(Agustos2021_C3_Display));
            OnPropertyChanged(nameof(Agustos2021_C4_Display));
            OnPropertyChanged(nameof(Agustos2021_C5_Display));
            OnPropertyChanged(nameof(Agustos2021_C6_Display));

            OnPropertyChanged(nameof(Eylul2021_C1_Display));
            OnPropertyChanged(nameof(Eylul2021_C2_Display));
            OnPropertyChanged(nameof(Eylul2021_C3_Display));
            OnPropertyChanged(nameof(Eylul2021_C4_Display));
            OnPropertyChanged(nameof(Eylul2021_C5_Display));
            OnPropertyChanged(nameof(Eylul2021_C6_Display));

            OnPropertyChanged(nameof(Ekim2021_C1_Display));
            OnPropertyChanged(nameof(Ekim2021_C2_Display));
            OnPropertyChanged(nameof(Ekim2021_C3_Display));
            OnPropertyChanged(nameof(Ekim2021_C4_Display));
            OnPropertyChanged(nameof(Ekim2021_C5_Display));
            OnPropertyChanged(nameof(Ekim2021_C6_Display));

            OnPropertyChanged(nameof(Kasim2021_C1_Display));
            OnPropertyChanged(nameof(Kasim2021_C2_Display));
            OnPropertyChanged(nameof(Kasim2021_C3_Display));
            OnPropertyChanged(nameof(Kasim2021_C4_Display));
            OnPropertyChanged(nameof(Kasim2021_C5_Display));
            OnPropertyChanged(nameof(Kasim2021_C6_Display));

            OnPropertyChanged(nameof(Aralik2021_C1_Display));
            OnPropertyChanged(nameof(Aralik2021_C2_Display));
            OnPropertyChanged(nameof(Aralik2021_C3_Display));
            OnPropertyChanged(nameof(Aralik2021_C4_Display));
            OnPropertyChanged(nameof(Aralik2021_C5_Display));
            OnPropertyChanged(nameof(Aralik2021_C6_Display));

            OnPropertyChanged(nameof(Toplam2021_C1_Display));
            OnPropertyChanged(nameof(Toplam2021_C2_Display));
            OnPropertyChanged(nameof(Toplam2021_C3_Display));
            OnPropertyChanged(nameof(Toplam2021_C4_Display));
            OnPropertyChanged(nameof(Toplam2021_C5_Display));
            OnPropertyChanged(nameof(Toplam2021_C6_Display));

        }

    }
}
