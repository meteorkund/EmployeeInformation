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
    public class EmployeeVacation2019VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2019VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2019_C1_Display => SelectedEmployee?.Vacation2019.Ocak2019_C1.ToString();
        public string Ocak2019_C2_Display => SelectedEmployee?.Vacation2019.Ocak2019_C2.ToString();
        public string Ocak2019_C3_Display => SelectedEmployee?.Vacation2019.Ocak2019_C3.ToString();
        public string Ocak2019_C4_Display => SelectedEmployee?.Vacation2019.Ocak2019_C4.ToString();
        public string Ocak2019_C5_Display => SelectedEmployee?.Vacation2019.Ocak2019_C5.ToString();
        public string Ocak2019_C6_Display => SelectedEmployee?.Vacation2019.Ocak2019_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2019_C1_Display => SelectedEmployee?.Vacation2019.Subat2019_C1.ToString();
        public string Subat2019_C2_Display => SelectedEmployee?.Vacation2019.Subat2019_C2.ToString();
        public string Subat2019_C3_Display => SelectedEmployee?.Vacation2019.Subat2019_C3.ToString();
        public string Subat2019_C4_Display => SelectedEmployee?.Vacation2019.Subat2019_C4.ToString();
        public string Subat2019_C5_Display => SelectedEmployee?.Vacation2019.Subat2019_C5.ToString();
        public string Subat2019_C6_Display => SelectedEmployee?.Vacation2019.Subat2019_C6.ToString();
        #endregion

        #region MART
        public string Mart2019_C1_Display => SelectedEmployee?.Vacation2019.Mart2019_C1.ToString();
        public string Mart2019_C2_Display => SelectedEmployee?.Vacation2019.Mart2019_C2.ToString();
        public string Mart2019_C3_Display => SelectedEmployee?.Vacation2019.Mart2019_C3.ToString();
        public string Mart2019_C4_Display => SelectedEmployee?.Vacation2019.Mart2019_C4.ToString();
        public string Mart2019_C5_Display => SelectedEmployee?.Vacation2019.Mart2019_C5.ToString();
        public string Mart2019_C6_Display => SelectedEmployee?.Vacation2019.Mart2019_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2019_C1_Display => SelectedEmployee?.Vacation2019.Nisan2019_C1.ToString();
        public string Nisan2019_C2_Display => SelectedEmployee?.Vacation2019.Nisan2019_C2.ToString();
        public string Nisan2019_C3_Display => SelectedEmployee?.Vacation2019.Nisan2019_C3.ToString();
        public string Nisan2019_C4_Display => SelectedEmployee?.Vacation2019.Nisan2019_C4.ToString();
        public string Nisan2019_C5_Display => SelectedEmployee?.Vacation2019.Nisan2019_C5.ToString();
        public string Nisan2019_C6_Display => SelectedEmployee?.Vacation2019.Nisan2019_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2019_C1_Display => SelectedEmployee?.Vacation2019.Mayis2019_C1.ToString();
        public string Mayis2019_C2_Display => SelectedEmployee?.Vacation2019.Mayis2019_C2.ToString();
        public string Mayis2019_C3_Display => SelectedEmployee?.Vacation2019.Mayis2019_C3.ToString();
        public string Mayis2019_C4_Display => SelectedEmployee?.Vacation2019.Mayis2019_C4.ToString();
        public string Mayis2019_C5_Display => SelectedEmployee?.Vacation2019.Mayis2019_C5.ToString();
        public string Mayis2019_C6_Display => SelectedEmployee?.Vacation2019.Mayis2019_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2019_C1_Display => SelectedEmployee?.Vacation2019.Haziran2019_C1.ToString();
        public string Haziran2019_C2_Display => SelectedEmployee?.Vacation2019.Haziran2019_C2.ToString();
        public string Haziran2019_C3_Display => SelectedEmployee?.Vacation2019.Haziran2019_C3.ToString();
        public string Haziran2019_C4_Display => SelectedEmployee?.Vacation2019.Haziran2019_C4.ToString();
        public string Haziran2019_C5_Display => SelectedEmployee?.Vacation2019.Haziran2019_C5.ToString();
        public string Haziran2019_C6_Display => SelectedEmployee?.Vacation2019.Haziran2019_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2019_C1_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C1.ToString();
        public string Temmuz2019_C2_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C2.ToString();
        public string Temmuz2019_C3_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C3.ToString();
        public string Temmuz2019_C4_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C4.ToString();
        public string Temmuz2019_C5_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C5.ToString();
        public string Temmuz2019_C6_Display => SelectedEmployee?.Vacation2019.Temmuz2019_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2019_C1_Display => SelectedEmployee?.Vacation2019.Agustos2019_C1.ToString();
        public string Agustos2019_C2_Display => SelectedEmployee?.Vacation2019.Agustos2019_C2.ToString();
        public string Agustos2019_C3_Display => SelectedEmployee?.Vacation2019.Agustos2019_C3.ToString();
        public string Agustos2019_C4_Display => SelectedEmployee?.Vacation2019.Agustos2019_C4.ToString();
        public string Agustos2019_C5_Display => SelectedEmployee?.Vacation2019.Agustos2019_C5.ToString();
        public string Agustos2019_C6_Display => SelectedEmployee?.Vacation2019.Agustos2019_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2019_C1_Display => SelectedEmployee?.Vacation2019.Eylul2019_C1.ToString();
        public string Eylul2019_C2_Display => SelectedEmployee?.Vacation2019.Eylul2019_C2.ToString();
        public string Eylul2019_C3_Display => SelectedEmployee?.Vacation2019.Eylul2019_C3.ToString();
        public string Eylul2019_C4_Display => SelectedEmployee?.Vacation2019.Eylul2019_C4.ToString();
        public string Eylul2019_C5_Display => SelectedEmployee?.Vacation2019.Eylul2019_C5.ToString();
        public string Eylul2019_C6_Display => SelectedEmployee?.Vacation2019.Eylul2019_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2019_C1_Display => SelectedEmployee?.Vacation2019.Ekim2019_C1.ToString();
        public string Ekim2019_C2_Display => SelectedEmployee?.Vacation2019.Ekim2019_C2.ToString();
        public string Ekim2019_C3_Display => SelectedEmployee?.Vacation2019.Ekim2019_C3.ToString();
        public string Ekim2019_C4_Display => SelectedEmployee?.Vacation2019.Ekim2019_C4.ToString();
        public string Ekim2019_C5_Display => SelectedEmployee?.Vacation2019.Ekim2019_C5.ToString();
        public string Ekim2019_C6_Display => SelectedEmployee?.Vacation2019.Ekim2019_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2019_C1_Display => SelectedEmployee?.Vacation2019.Kasim2019_C1.ToString();
        public string Kasim2019_C2_Display => SelectedEmployee?.Vacation2019.Kasim2019_C2.ToString();
        public string Kasim2019_C3_Display => SelectedEmployee?.Vacation2019.Kasim2019_C3.ToString();
        public string Kasim2019_C4_Display => SelectedEmployee?.Vacation2019.Kasim2019_C4.ToString();
        public string Kasim2019_C5_Display => SelectedEmployee?.Vacation2019.Kasim2019_C5.ToString();
        public string Kasim2019_C6_Display => SelectedEmployee?.Vacation2019.Kasim2019_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2019_C1_Display => SelectedEmployee?.Vacation2019.Aralik2019_C1.ToString();
        public string Aralik2019_C2_Display => SelectedEmployee?.Vacation2019.Aralik2019_C2.ToString();
        public string Aralik2019_C3_Display => SelectedEmployee?.Vacation2019.Aralik2019_C3.ToString();
        public string Aralik2019_C4_Display => SelectedEmployee?.Vacation2019.Aralik2019_C4.ToString();
        public string Aralik2019_C5_Display => SelectedEmployee?.Vacation2019.Aralik2019_C5.ToString();
        public string Aralik2019_C6_Display => SelectedEmployee?.Vacation2019.Aralik2019_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2019_C1_Display => Toplam2019_C1.ToString();
        public string Toplam2019_C2_Display => Toplam2019_C2.ToString();
        public string Toplam2019_C3_Display => Toplam2019_C3.ToString();
        public string Toplam2019_C4_Display => Toplam2019_C4.ToString();
        public string Toplam2019_C5_Display => Toplam2019_C5.ToString();
        public string Toplam2019_C6_Display => Toplam2019_C6.ToString();

        public int Toplam2019_C1 =>
            Int32.Parse(Ocak2019_C1_Display) +
            Int32.Parse(Subat2019_C1_Display) +
            Int32.Parse(Mart2019_C1_Display) +
            Int32.Parse(Nisan2019_C1_Display) +
            Int32.Parse(Mayis2019_C1_Display) +
            Int32.Parse(Haziran2019_C1_Display) +
            Int32.Parse(Temmuz2019_C1_Display) +
            Int32.Parse(Agustos2019_C1_Display) +
            Int32.Parse(Eylul2019_C1_Display) +
            Int32.Parse(Ekim2019_C1_Display) +
            Int32.Parse(Kasim2019_C1_Display) +
            Int32.Parse(Aralik2019_C1_Display);

        public int Toplam2019_C2 =>
            Int32.Parse(Ocak2019_C2_Display) +
            Int32.Parse(Subat2019_C2_Display) +
            Int32.Parse(Mart2019_C2_Display) +
            Int32.Parse(Nisan2019_C2_Display) +
            Int32.Parse(Mayis2019_C2_Display) +
            Int32.Parse(Haziran2019_C2_Display) +
            Int32.Parse(Temmuz2019_C2_Display) +
            Int32.Parse(Agustos2019_C2_Display) +
            Int32.Parse(Eylul2019_C2_Display) +
            Int32.Parse(Ekim2019_C2_Display) +
            Int32.Parse(Kasim2019_C2_Display) +
            Int32.Parse(Aralik2019_C2_Display);
        public int Toplam2019_C3 =>
            Int32.Parse(Ocak2019_C3_Display) +
            Int32.Parse(Subat2019_C3_Display) +
            Int32.Parse(Mart2019_C3_Display) +
            Int32.Parse(Nisan2019_C3_Display) +
            Int32.Parse(Mayis2019_C3_Display) +
            Int32.Parse(Haziran2019_C3_Display) +
            Int32.Parse(Temmuz2019_C3_Display) +
            Int32.Parse(Agustos2019_C3_Display) +
            Int32.Parse(Eylul2019_C3_Display) +
            Int32.Parse(Ekim2019_C3_Display) +
            Int32.Parse(Kasim2019_C3_Display) +
            Int32.Parse(Aralik2019_C3_Display);
        public int Toplam2019_C4 =>
            Int32.Parse(Ocak2019_C4_Display) +
            Int32.Parse(Subat2019_C4_Display) +
            Int32.Parse(Mart2019_C4_Display) +
            Int32.Parse(Nisan2019_C4_Display) +
            Int32.Parse(Mayis2019_C4_Display) +
            Int32.Parse(Haziran2019_C4_Display) +
            Int32.Parse(Temmuz2019_C4_Display) +
            Int32.Parse(Agustos2019_C4_Display) +
            Int32.Parse(Eylul2019_C4_Display) +
            Int32.Parse(Ekim2019_C4_Display) +
            Int32.Parse(Kasim2019_C4_Display) +
            Int32.Parse(Aralik2019_C4_Display);

        public int Toplam2019_C5 =>
            Int32.Parse(Ocak2019_C5_Display) +
            Int32.Parse(Subat2019_C5_Display) +
            Int32.Parse(Mart2019_C5_Display) +
            Int32.Parse(Nisan2019_C5_Display) +
            Int32.Parse(Mayis2019_C5_Display) +
            Int32.Parse(Haziran2019_C5_Display) +
            Int32.Parse(Temmuz2019_C5_Display) +
            Int32.Parse(Agustos2019_C5_Display) +
            Int32.Parse(Eylul2019_C5_Display) +
            Int32.Parse(Ekim2019_C5_Display) +
            Int32.Parse(Kasim2019_C5_Display) +
            Int32.Parse(Aralik2019_C5_Display);
        public int Toplam2019_C6 =>
            Int32.Parse(Ocak2019_C6_Display) +
            Int32.Parse(Subat2019_C6_Display) +
            Int32.Parse(Mart2019_C6_Display) +
            Int32.Parse(Nisan2019_C6_Display) +
            Int32.Parse(Mayis2019_C6_Display) +
            Int32.Parse(Haziran2019_C6_Display) +
            Int32.Parse(Temmuz2019_C6_Display) +
            Int32.Parse(Agustos2019_C6_Display) +
            Int32.Parse(Eylul2019_C6_Display) +
            Int32.Parse(Ekim2019_C6_Display) +
            Int32.Parse(Kasim2019_C6_Display) +
            Int32.Parse(Aralik2019_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2019_C1_Display));
            OnPropertyChanged(nameof(Ocak2019_C2_Display));
            OnPropertyChanged(nameof(Ocak2019_C3_Display));
            OnPropertyChanged(nameof(Ocak2019_C4_Display));
            OnPropertyChanged(nameof(Ocak2019_C5_Display));
            OnPropertyChanged(nameof(Ocak2019_C6_Display));

            OnPropertyChanged(nameof(Subat2019_C1_Display));
            OnPropertyChanged(nameof(Subat2019_C2_Display));
            OnPropertyChanged(nameof(Subat2019_C3_Display));
            OnPropertyChanged(nameof(Subat2019_C4_Display));
            OnPropertyChanged(nameof(Subat2019_C5_Display));
            OnPropertyChanged(nameof(Subat2019_C6_Display));

            OnPropertyChanged(nameof(Mart2019_C1_Display));
            OnPropertyChanged(nameof(Mart2019_C2_Display));
            OnPropertyChanged(nameof(Mart2019_C3_Display));
            OnPropertyChanged(nameof(Mart2019_C4_Display));
            OnPropertyChanged(nameof(Mart2019_C5_Display));
            OnPropertyChanged(nameof(Mart2019_C6_Display));

            OnPropertyChanged(nameof(Nisan2019_C1_Display));
            OnPropertyChanged(nameof(Nisan2019_C2_Display));
            OnPropertyChanged(nameof(Nisan2019_C3_Display));
            OnPropertyChanged(nameof(Nisan2019_C4_Display));
            OnPropertyChanged(nameof(Nisan2019_C5_Display));
            OnPropertyChanged(nameof(Nisan2019_C6_Display));

            OnPropertyChanged(nameof(Mayis2019_C1_Display));
            OnPropertyChanged(nameof(Mayis2019_C2_Display));
            OnPropertyChanged(nameof(Mayis2019_C3_Display));
            OnPropertyChanged(nameof(Mayis2019_C4_Display));
            OnPropertyChanged(nameof(Mayis2019_C5_Display));
            OnPropertyChanged(nameof(Mayis2019_C6_Display));

            OnPropertyChanged(nameof(Haziran2019_C1_Display));
            OnPropertyChanged(nameof(Haziran2019_C2_Display));
            OnPropertyChanged(nameof(Haziran2019_C3_Display));
            OnPropertyChanged(nameof(Haziran2019_C4_Display));
            OnPropertyChanged(nameof(Haziran2019_C5_Display));
            OnPropertyChanged(nameof(Haziran2019_C6_Display));

            OnPropertyChanged(nameof(Temmuz2019_C1_Display));
            OnPropertyChanged(nameof(Temmuz2019_C2_Display));
            OnPropertyChanged(nameof(Temmuz2019_C3_Display));
            OnPropertyChanged(nameof(Temmuz2019_C4_Display));
            OnPropertyChanged(nameof(Temmuz2019_C5_Display));
            OnPropertyChanged(nameof(Temmuz2019_C6_Display));

            OnPropertyChanged(nameof(Agustos2019_C1_Display));
            OnPropertyChanged(nameof(Agustos2019_C2_Display));
            OnPropertyChanged(nameof(Agustos2019_C3_Display));
            OnPropertyChanged(nameof(Agustos2019_C4_Display));
            OnPropertyChanged(nameof(Agustos2019_C5_Display));
            OnPropertyChanged(nameof(Agustos2019_C6_Display));

            OnPropertyChanged(nameof(Eylul2019_C1_Display));
            OnPropertyChanged(nameof(Eylul2019_C2_Display));
            OnPropertyChanged(nameof(Eylul2019_C3_Display));
            OnPropertyChanged(nameof(Eylul2019_C4_Display));
            OnPropertyChanged(nameof(Eylul2019_C5_Display));
            OnPropertyChanged(nameof(Eylul2019_C6_Display));

            OnPropertyChanged(nameof(Ekim2019_C1_Display));
            OnPropertyChanged(nameof(Ekim2019_C2_Display));
            OnPropertyChanged(nameof(Ekim2019_C3_Display));
            OnPropertyChanged(nameof(Ekim2019_C4_Display));
            OnPropertyChanged(nameof(Ekim2019_C5_Display));
            OnPropertyChanged(nameof(Ekim2019_C6_Display));

            OnPropertyChanged(nameof(Kasim2019_C1_Display));
            OnPropertyChanged(nameof(Kasim2019_C2_Display));
            OnPropertyChanged(nameof(Kasim2019_C3_Display));
            OnPropertyChanged(nameof(Kasim2019_C4_Display));
            OnPropertyChanged(nameof(Kasim2019_C5_Display));
            OnPropertyChanged(nameof(Kasim2019_C6_Display));

            OnPropertyChanged(nameof(Aralik2019_C1_Display));
            OnPropertyChanged(nameof(Aralik2019_C2_Display));
            OnPropertyChanged(nameof(Aralik2019_C3_Display));
            OnPropertyChanged(nameof(Aralik2019_C4_Display));
            OnPropertyChanged(nameof(Aralik2019_C5_Display));
            OnPropertyChanged(nameof(Aralik2019_C6_Display));

            OnPropertyChanged(nameof(Toplam2019_C1_Display));
            OnPropertyChanged(nameof(Toplam2019_C2_Display));
            OnPropertyChanged(nameof(Toplam2019_C3_Display));
            OnPropertyChanged(nameof(Toplam2019_C4_Display));
            OnPropertyChanged(nameof(Toplam2019_C5_Display));
            OnPropertyChanged(nameof(Toplam2019_C6_Display));

        }

    }
}
