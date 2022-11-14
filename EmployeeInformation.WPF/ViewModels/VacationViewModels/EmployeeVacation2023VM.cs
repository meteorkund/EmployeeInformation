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
    public class EmployeeVacation2023VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2023VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2023_C1_Display => SelectedEmployee?.Vacation2023.Ocak2023_C1.ToString();
        public string Ocak2023_C2_Display => SelectedEmployee?.Vacation2023.Ocak2023_C2.ToString();
        public string Ocak2023_C3_Display => SelectedEmployee?.Vacation2023.Ocak2023_C3.ToString();
        public string Ocak2023_C4_Display => SelectedEmployee?.Vacation2023.Ocak2023_C4.ToString();
        public string Ocak2023_C5_Display => SelectedEmployee?.Vacation2023.Ocak2023_C5.ToString();
        public string Ocak2023_C6_Display => SelectedEmployee?.Vacation2023.Ocak2023_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2023_C1_Display => SelectedEmployee?.Vacation2023.Subat2023_C1.ToString();
        public string Subat2023_C2_Display => SelectedEmployee?.Vacation2023.Subat2023_C2.ToString();
        public string Subat2023_C3_Display => SelectedEmployee?.Vacation2023.Subat2023_C3.ToString();
        public string Subat2023_C4_Display => SelectedEmployee?.Vacation2023.Subat2023_C4.ToString();
        public string Subat2023_C5_Display => SelectedEmployee?.Vacation2023.Subat2023_C5.ToString();
        public string Subat2023_C6_Display => SelectedEmployee?.Vacation2023.Subat2023_C6.ToString();
        #endregion

        #region MART
        public string Mart2023_C1_Display => SelectedEmployee?.Vacation2023.Mart2023_C1.ToString();
        public string Mart2023_C2_Display => SelectedEmployee?.Vacation2023.Mart2023_C2.ToString();
        public string Mart2023_C3_Display => SelectedEmployee?.Vacation2023.Mart2023_C3.ToString();
        public string Mart2023_C4_Display => SelectedEmployee?.Vacation2023.Mart2023_C4.ToString();
        public string Mart2023_C5_Display => SelectedEmployee?.Vacation2023.Mart2023_C5.ToString();
        public string Mart2023_C6_Display => SelectedEmployee?.Vacation2023.Mart2023_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2023_C1_Display => SelectedEmployee?.Vacation2023.Nisan2023_C1.ToString();
        public string Nisan2023_C2_Display => SelectedEmployee?.Vacation2023.Nisan2023_C2.ToString();
        public string Nisan2023_C3_Display => SelectedEmployee?.Vacation2023.Nisan2023_C3.ToString();
        public string Nisan2023_C4_Display => SelectedEmployee?.Vacation2023.Nisan2023_C4.ToString();
        public string Nisan2023_C5_Display => SelectedEmployee?.Vacation2023.Nisan2023_C5.ToString();
        public string Nisan2023_C6_Display => SelectedEmployee?.Vacation2023.Nisan2023_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2023_C1_Display => SelectedEmployee?.Vacation2023.Mayis2023_C1.ToString();
        public string Mayis2023_C2_Display => SelectedEmployee?.Vacation2023.Mayis2023_C2.ToString();
        public string Mayis2023_C3_Display => SelectedEmployee?.Vacation2023.Mayis2023_C3.ToString();
        public string Mayis2023_C4_Display => SelectedEmployee?.Vacation2023.Mayis2023_C4.ToString();
        public string Mayis2023_C5_Display => SelectedEmployee?.Vacation2023.Mayis2023_C5.ToString();
        public string Mayis2023_C6_Display => SelectedEmployee?.Vacation2023.Mayis2023_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2023_C1_Display => SelectedEmployee?.Vacation2023.Haziran2023_C1.ToString();
        public string Haziran2023_C2_Display => SelectedEmployee?.Vacation2023.Haziran2023_C2.ToString();
        public string Haziran2023_C3_Display => SelectedEmployee?.Vacation2023.Haziran2023_C3.ToString();
        public string Haziran2023_C4_Display => SelectedEmployee?.Vacation2023.Haziran2023_C4.ToString();
        public string Haziran2023_C5_Display => SelectedEmployee?.Vacation2023.Haziran2023_C5.ToString();
        public string Haziran2023_C6_Display => SelectedEmployee?.Vacation2023.Haziran2023_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2023_C1_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C1.ToString();
        public string Temmuz2023_C2_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C2.ToString();
        public string Temmuz2023_C3_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C3.ToString();
        public string Temmuz2023_C4_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C4.ToString();
        public string Temmuz2023_C5_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C5.ToString();
        public string Temmuz2023_C6_Display => SelectedEmployee?.Vacation2023.Temmuz2023_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2023_C1_Display => SelectedEmployee?.Vacation2023.Agustos2023_C1.ToString();
        public string Agustos2023_C2_Display => SelectedEmployee?.Vacation2023.Agustos2023_C2.ToString();
        public string Agustos2023_C3_Display => SelectedEmployee?.Vacation2023.Agustos2023_C3.ToString();
        public string Agustos2023_C4_Display => SelectedEmployee?.Vacation2023.Agustos2023_C4.ToString();
        public string Agustos2023_C5_Display => SelectedEmployee?.Vacation2023.Agustos2023_C5.ToString();
        public string Agustos2023_C6_Display => SelectedEmployee?.Vacation2023.Agustos2023_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2023_C1_Display => SelectedEmployee?.Vacation2023.Eylul2023_C1.ToString();
        public string Eylul2023_C2_Display => SelectedEmployee?.Vacation2023.Eylul2023_C2.ToString();
        public string Eylul2023_C3_Display => SelectedEmployee?.Vacation2023.Eylul2023_C3.ToString();
        public string Eylul2023_C4_Display => SelectedEmployee?.Vacation2023.Eylul2023_C4.ToString();
        public string Eylul2023_C5_Display => SelectedEmployee?.Vacation2023.Eylul2023_C5.ToString();
        public string Eylul2023_C6_Display => SelectedEmployee?.Vacation2023.Eylul2023_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2023_C1_Display => SelectedEmployee?.Vacation2023.Ekim2023_C1.ToString();
        public string Ekim2023_C2_Display => SelectedEmployee?.Vacation2023.Ekim2023_C2.ToString();
        public string Ekim2023_C3_Display => SelectedEmployee?.Vacation2023.Ekim2023_C3.ToString();
        public string Ekim2023_C4_Display => SelectedEmployee?.Vacation2023.Ekim2023_C4.ToString();
        public string Ekim2023_C5_Display => SelectedEmployee?.Vacation2023.Ekim2023_C5.ToString();
        public string Ekim2023_C6_Display => SelectedEmployee?.Vacation2023.Ekim2023_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2023_C1_Display => SelectedEmployee?.Vacation2023.Kasim2023_C1.ToString();
        public string Kasim2023_C2_Display => SelectedEmployee?.Vacation2023.Kasim2023_C2.ToString();
        public string Kasim2023_C3_Display => SelectedEmployee?.Vacation2023.Kasim2023_C3.ToString();
        public string Kasim2023_C4_Display => SelectedEmployee?.Vacation2023.Kasim2023_C4.ToString();
        public string Kasim2023_C5_Display => SelectedEmployee?.Vacation2023.Kasim2023_C5.ToString();
        public string Kasim2023_C6_Display => SelectedEmployee?.Vacation2023.Kasim2023_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2023_C1_Display => SelectedEmployee?.Vacation2023.Aralik2023_C1.ToString();
        public string Aralik2023_C2_Display => SelectedEmployee?.Vacation2023.Aralik2023_C2.ToString();
        public string Aralik2023_C3_Display => SelectedEmployee?.Vacation2023.Aralik2023_C3.ToString();
        public string Aralik2023_C4_Display => SelectedEmployee?.Vacation2023.Aralik2023_C4.ToString();
        public string Aralik2023_C5_Display => SelectedEmployee?.Vacation2023.Aralik2023_C5.ToString();
        public string Aralik2023_C6_Display => SelectedEmployee?.Vacation2023.Aralik2023_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2023_C1_Display => Toplam2023_C1.ToString();
        public string Toplam2023_C2_Display => Toplam2023_C2.ToString();
        public string Toplam2023_C3_Display => Toplam2023_C3.ToString();
        public string Toplam2023_C4_Display => Toplam2023_C4.ToString();
        public string Toplam2023_C5_Display => Toplam2023_C5.ToString();
        public string Toplam2023_C6_Display => Toplam2023_C6.ToString();

        public int Toplam2023_C1 =>
            Int32.Parse(Ocak2023_C1_Display) +
            Int32.Parse(Subat2023_C1_Display) +
            Int32.Parse(Mart2023_C1_Display) +
            Int32.Parse(Nisan2023_C1_Display) +
            Int32.Parse(Mayis2023_C1_Display) +
            Int32.Parse(Haziran2023_C1_Display) +
            Int32.Parse(Temmuz2023_C1_Display) +
            Int32.Parse(Agustos2023_C1_Display) +
            Int32.Parse(Eylul2023_C1_Display) +
            Int32.Parse(Ekim2023_C1_Display) +
            Int32.Parse(Kasim2023_C1_Display) +
            Int32.Parse(Aralik2023_C1_Display);

        public int Toplam2023_C2 =>
            Int32.Parse(Ocak2023_C2_Display) +
            Int32.Parse(Subat2023_C2_Display) +
            Int32.Parse(Mart2023_C2_Display) +
            Int32.Parse(Nisan2023_C2_Display) +
            Int32.Parse(Mayis2023_C2_Display) +
            Int32.Parse(Haziran2023_C2_Display) +
            Int32.Parse(Temmuz2023_C2_Display) +
            Int32.Parse(Agustos2023_C2_Display) +
            Int32.Parse(Eylul2023_C2_Display) +
            Int32.Parse(Ekim2023_C2_Display) +
            Int32.Parse(Kasim2023_C2_Display) +
            Int32.Parse(Aralik2023_C2_Display);
        public int Toplam2023_C3 =>
            Int32.Parse(Ocak2023_C3_Display) +
            Int32.Parse(Subat2023_C3_Display) +
            Int32.Parse(Mart2023_C3_Display) +
            Int32.Parse(Nisan2023_C3_Display) +
            Int32.Parse(Mayis2023_C3_Display) +
            Int32.Parse(Haziran2023_C3_Display) +
            Int32.Parse(Temmuz2023_C3_Display) +
            Int32.Parse(Agustos2023_C3_Display) +
            Int32.Parse(Eylul2023_C3_Display) +
            Int32.Parse(Ekim2023_C3_Display) +
            Int32.Parse(Kasim2023_C3_Display) +
            Int32.Parse(Aralik2023_C3_Display);
        public int Toplam2023_C4 =>
            Int32.Parse(Ocak2023_C4_Display) +
            Int32.Parse(Subat2023_C4_Display) +
            Int32.Parse(Mart2023_C4_Display) +
            Int32.Parse(Nisan2023_C4_Display) +
            Int32.Parse(Mayis2023_C4_Display) +
            Int32.Parse(Haziran2023_C4_Display) +
            Int32.Parse(Temmuz2023_C4_Display) +
            Int32.Parse(Agustos2023_C4_Display) +
            Int32.Parse(Eylul2023_C4_Display) +
            Int32.Parse(Ekim2023_C4_Display) +
            Int32.Parse(Kasim2023_C4_Display) +
            Int32.Parse(Aralik2023_C4_Display);

        public int Toplam2023_C5 =>
            Int32.Parse(Ocak2023_C5_Display) +
            Int32.Parse(Subat2023_C5_Display) +
            Int32.Parse(Mart2023_C5_Display) +
            Int32.Parse(Nisan2023_C5_Display) +
            Int32.Parse(Mayis2023_C5_Display) +
            Int32.Parse(Haziran2023_C5_Display) +
            Int32.Parse(Temmuz2023_C5_Display) +
            Int32.Parse(Agustos2023_C5_Display) +
            Int32.Parse(Eylul2023_C5_Display) +
            Int32.Parse(Ekim2023_C5_Display) +
            Int32.Parse(Kasim2023_C5_Display) +
            Int32.Parse(Aralik2023_C5_Display);
        public int Toplam2023_C6 =>
            Int32.Parse(Ocak2023_C6_Display) +
            Int32.Parse(Subat2023_C6_Display) +
            Int32.Parse(Mart2023_C6_Display) +
            Int32.Parse(Nisan2023_C6_Display) +
            Int32.Parse(Mayis2023_C6_Display) +
            Int32.Parse(Haziran2023_C6_Display) +
            Int32.Parse(Temmuz2023_C6_Display) +
            Int32.Parse(Agustos2023_C6_Display) +
            Int32.Parse(Eylul2023_C6_Display) +
            Int32.Parse(Ekim2023_C6_Display) +
            Int32.Parse(Kasim2023_C6_Display) +
            Int32.Parse(Aralik2023_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2023_C1_Display));
            OnPropertyChanged(nameof(Ocak2023_C2_Display));
            OnPropertyChanged(nameof(Ocak2023_C3_Display));
            OnPropertyChanged(nameof(Ocak2023_C4_Display));
            OnPropertyChanged(nameof(Ocak2023_C5_Display));
            OnPropertyChanged(nameof(Ocak2023_C6_Display));

            OnPropertyChanged(nameof(Subat2023_C1_Display));
            OnPropertyChanged(nameof(Subat2023_C2_Display));
            OnPropertyChanged(nameof(Subat2023_C3_Display));
            OnPropertyChanged(nameof(Subat2023_C4_Display));
            OnPropertyChanged(nameof(Subat2023_C5_Display));
            OnPropertyChanged(nameof(Subat2023_C6_Display));

            OnPropertyChanged(nameof(Mart2023_C1_Display));
            OnPropertyChanged(nameof(Mart2023_C2_Display));
            OnPropertyChanged(nameof(Mart2023_C3_Display));
            OnPropertyChanged(nameof(Mart2023_C4_Display));
            OnPropertyChanged(nameof(Mart2023_C5_Display));
            OnPropertyChanged(nameof(Mart2023_C6_Display));

            OnPropertyChanged(nameof(Nisan2023_C1_Display));
            OnPropertyChanged(nameof(Nisan2023_C2_Display));
            OnPropertyChanged(nameof(Nisan2023_C3_Display));
            OnPropertyChanged(nameof(Nisan2023_C4_Display));
            OnPropertyChanged(nameof(Nisan2023_C5_Display));
            OnPropertyChanged(nameof(Nisan2023_C6_Display));

            OnPropertyChanged(nameof(Mayis2023_C1_Display));
            OnPropertyChanged(nameof(Mayis2023_C2_Display));
            OnPropertyChanged(nameof(Mayis2023_C3_Display));
            OnPropertyChanged(nameof(Mayis2023_C4_Display));
            OnPropertyChanged(nameof(Mayis2023_C5_Display));
            OnPropertyChanged(nameof(Mayis2023_C6_Display));

            OnPropertyChanged(nameof(Haziran2023_C1_Display));
            OnPropertyChanged(nameof(Haziran2023_C2_Display));
            OnPropertyChanged(nameof(Haziran2023_C3_Display));
            OnPropertyChanged(nameof(Haziran2023_C4_Display));
            OnPropertyChanged(nameof(Haziran2023_C5_Display));
            OnPropertyChanged(nameof(Haziran2023_C6_Display));

            OnPropertyChanged(nameof(Temmuz2023_C1_Display));
            OnPropertyChanged(nameof(Temmuz2023_C2_Display));
            OnPropertyChanged(nameof(Temmuz2023_C3_Display));
            OnPropertyChanged(nameof(Temmuz2023_C4_Display));
            OnPropertyChanged(nameof(Temmuz2023_C5_Display));
            OnPropertyChanged(nameof(Temmuz2023_C6_Display));

            OnPropertyChanged(nameof(Agustos2023_C1_Display));
            OnPropertyChanged(nameof(Agustos2023_C2_Display));
            OnPropertyChanged(nameof(Agustos2023_C3_Display));
            OnPropertyChanged(nameof(Agustos2023_C4_Display));
            OnPropertyChanged(nameof(Agustos2023_C5_Display));
            OnPropertyChanged(nameof(Agustos2023_C6_Display));

            OnPropertyChanged(nameof(Eylul2023_C1_Display));
            OnPropertyChanged(nameof(Eylul2023_C2_Display));
            OnPropertyChanged(nameof(Eylul2023_C3_Display));
            OnPropertyChanged(nameof(Eylul2023_C4_Display));
            OnPropertyChanged(nameof(Eylul2023_C5_Display));
            OnPropertyChanged(nameof(Eylul2023_C6_Display));

            OnPropertyChanged(nameof(Ekim2023_C1_Display));
            OnPropertyChanged(nameof(Ekim2023_C2_Display));
            OnPropertyChanged(nameof(Ekim2023_C3_Display));
            OnPropertyChanged(nameof(Ekim2023_C4_Display));
            OnPropertyChanged(nameof(Ekim2023_C5_Display));
            OnPropertyChanged(nameof(Ekim2023_C6_Display));

            OnPropertyChanged(nameof(Kasim2023_C1_Display));
            OnPropertyChanged(nameof(Kasim2023_C2_Display));
            OnPropertyChanged(nameof(Kasim2023_C3_Display));
            OnPropertyChanged(nameof(Kasim2023_C4_Display));
            OnPropertyChanged(nameof(Kasim2023_C5_Display));
            OnPropertyChanged(nameof(Kasim2023_C6_Display));

            OnPropertyChanged(nameof(Aralik2023_C1_Display));
            OnPropertyChanged(nameof(Aralik2023_C2_Display));
            OnPropertyChanged(nameof(Aralik2023_C3_Display));
            OnPropertyChanged(nameof(Aralik2023_C4_Display));
            OnPropertyChanged(nameof(Aralik2023_C5_Display));
            OnPropertyChanged(nameof(Aralik2023_C6_Display));

            OnPropertyChanged(nameof(Toplam2023_C1_Display));
            OnPropertyChanged(nameof(Toplam2023_C2_Display));
            OnPropertyChanged(nameof(Toplam2023_C3_Display));
            OnPropertyChanged(nameof(Toplam2023_C4_Display));
            OnPropertyChanged(nameof(Toplam2023_C5_Display));
            OnPropertyChanged(nameof(Toplam2023_C6_Display));

        }

    }
}
