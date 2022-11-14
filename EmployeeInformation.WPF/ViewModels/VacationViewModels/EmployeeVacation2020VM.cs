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
    public class EmployeeVacation2020VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2020VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2020_C1_Display => SelectedEmployee?.Vacation2020.Ocak2020_C1.ToString();
        public string Ocak2020_C2_Display => SelectedEmployee?.Vacation2020.Ocak2020_C2.ToString();
        public string Ocak2020_C3_Display => SelectedEmployee?.Vacation2020.Ocak2020_C3.ToString();
        public string Ocak2020_C4_Display => SelectedEmployee?.Vacation2020.Ocak2020_C4.ToString();
        public string Ocak2020_C5_Display => SelectedEmployee?.Vacation2020.Ocak2020_C5.ToString();
        public string Ocak2020_C6_Display => SelectedEmployee?.Vacation2020.Ocak2020_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2020_C1_Display => SelectedEmployee?.Vacation2020.Subat2020_C1.ToString();
        public string Subat2020_C2_Display => SelectedEmployee?.Vacation2020.Subat2020_C2.ToString();
        public string Subat2020_C3_Display => SelectedEmployee?.Vacation2020.Subat2020_C3.ToString();
        public string Subat2020_C4_Display => SelectedEmployee?.Vacation2020.Subat2020_C4.ToString();
        public string Subat2020_C5_Display => SelectedEmployee?.Vacation2020.Subat2020_C5.ToString();
        public string Subat2020_C6_Display => SelectedEmployee?.Vacation2020.Subat2020_C6.ToString();
        #endregion

        #region MART
        public string Mart2020_C1_Display => SelectedEmployee?.Vacation2020.Mart2020_C1.ToString();
        public string Mart2020_C2_Display => SelectedEmployee?.Vacation2020.Mart2020_C2.ToString();
        public string Mart2020_C3_Display => SelectedEmployee?.Vacation2020.Mart2020_C3.ToString();
        public string Mart2020_C4_Display => SelectedEmployee?.Vacation2020.Mart2020_C4.ToString();
        public string Mart2020_C5_Display => SelectedEmployee?.Vacation2020.Mart2020_C5.ToString();
        public string Mart2020_C6_Display => SelectedEmployee?.Vacation2020.Mart2020_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2020_C1_Display => SelectedEmployee?.Vacation2020.Nisan2020_C1.ToString();
        public string Nisan2020_C2_Display => SelectedEmployee?.Vacation2020.Nisan2020_C2.ToString();
        public string Nisan2020_C3_Display => SelectedEmployee?.Vacation2020.Nisan2020_C3.ToString();
        public string Nisan2020_C4_Display => SelectedEmployee?.Vacation2020.Nisan2020_C4.ToString();
        public string Nisan2020_C5_Display => SelectedEmployee?.Vacation2020.Nisan2020_C5.ToString();
        public string Nisan2020_C6_Display => SelectedEmployee?.Vacation2020.Nisan2020_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2020_C1_Display => SelectedEmployee?.Vacation2020.Mayis2020_C1.ToString();
        public string Mayis2020_C2_Display => SelectedEmployee?.Vacation2020.Mayis2020_C2.ToString();
        public string Mayis2020_C3_Display => SelectedEmployee?.Vacation2020.Mayis2020_C3.ToString();
        public string Mayis2020_C4_Display => SelectedEmployee?.Vacation2020.Mayis2020_C4.ToString();
        public string Mayis2020_C5_Display => SelectedEmployee?.Vacation2020.Mayis2020_C5.ToString();
        public string Mayis2020_C6_Display => SelectedEmployee?.Vacation2020.Mayis2020_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2020_C1_Display => SelectedEmployee?.Vacation2020.Haziran2020_C1.ToString();
        public string Haziran2020_C2_Display => SelectedEmployee?.Vacation2020.Haziran2020_C2.ToString();
        public string Haziran2020_C3_Display => SelectedEmployee?.Vacation2020.Haziran2020_C3.ToString();
        public string Haziran2020_C4_Display => SelectedEmployee?.Vacation2020.Haziran2020_C4.ToString();
        public string Haziran2020_C5_Display => SelectedEmployee?.Vacation2020.Haziran2020_C5.ToString();
        public string Haziran2020_C6_Display => SelectedEmployee?.Vacation2020.Haziran2020_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2020_C1_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C1.ToString();
        public string Temmuz2020_C2_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C2.ToString();
        public string Temmuz2020_C3_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C3.ToString();
        public string Temmuz2020_C4_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C4.ToString();
        public string Temmuz2020_C5_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C5.ToString();
        public string Temmuz2020_C6_Display => SelectedEmployee?.Vacation2020.Temmuz2020_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2020_C1_Display => SelectedEmployee?.Vacation2020.Agustos2020_C1.ToString();
        public string Agustos2020_C2_Display => SelectedEmployee?.Vacation2020.Agustos2020_C2.ToString();
        public string Agustos2020_C3_Display => SelectedEmployee?.Vacation2020.Agustos2020_C3.ToString();
        public string Agustos2020_C4_Display => SelectedEmployee?.Vacation2020.Agustos2020_C4.ToString();
        public string Agustos2020_C5_Display => SelectedEmployee?.Vacation2020.Agustos2020_C5.ToString();
        public string Agustos2020_C6_Display => SelectedEmployee?.Vacation2020.Agustos2020_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2020_C1_Display => SelectedEmployee?.Vacation2020.Eylul2020_C1.ToString();
        public string Eylul2020_C2_Display => SelectedEmployee?.Vacation2020.Eylul2020_C2.ToString();
        public string Eylul2020_C3_Display => SelectedEmployee?.Vacation2020.Eylul2020_C3.ToString();
        public string Eylul2020_C4_Display => SelectedEmployee?.Vacation2020.Eylul2020_C4.ToString();
        public string Eylul2020_C5_Display => SelectedEmployee?.Vacation2020.Eylul2020_C5.ToString();
        public string Eylul2020_C6_Display => SelectedEmployee?.Vacation2020.Eylul2020_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2020_C1_Display => SelectedEmployee?.Vacation2020.Ekim2020_C1.ToString();
        public string Ekim2020_C2_Display => SelectedEmployee?.Vacation2020.Ekim2020_C2.ToString();
        public string Ekim2020_C3_Display => SelectedEmployee?.Vacation2020.Ekim2020_C3.ToString();
        public string Ekim2020_C4_Display => SelectedEmployee?.Vacation2020.Ekim2020_C4.ToString();
        public string Ekim2020_C5_Display => SelectedEmployee?.Vacation2020.Ekim2020_C5.ToString();
        public string Ekim2020_C6_Display => SelectedEmployee?.Vacation2020.Ekim2020_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2020_C1_Display => SelectedEmployee?.Vacation2020.Kasim2020_C1.ToString();
        public string Kasim2020_C2_Display => SelectedEmployee?.Vacation2020.Kasim2020_C2.ToString();
        public string Kasim2020_C3_Display => SelectedEmployee?.Vacation2020.Kasim2020_C3.ToString();
        public string Kasim2020_C4_Display => SelectedEmployee?.Vacation2020.Kasim2020_C4.ToString();
        public string Kasim2020_C5_Display => SelectedEmployee?.Vacation2020.Kasim2020_C5.ToString();
        public string Kasim2020_C6_Display => SelectedEmployee?.Vacation2020.Kasim2020_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2020_C1_Display => SelectedEmployee?.Vacation2020.Aralik2020_C1.ToString();
        public string Aralik2020_C2_Display => SelectedEmployee?.Vacation2020.Aralik2020_C2.ToString();
        public string Aralik2020_C3_Display => SelectedEmployee?.Vacation2020.Aralik2020_C3.ToString();
        public string Aralik2020_C4_Display => SelectedEmployee?.Vacation2020.Aralik2020_C4.ToString();
        public string Aralik2020_C5_Display => SelectedEmployee?.Vacation2020.Aralik2020_C5.ToString();
        public string Aralik2020_C6_Display => SelectedEmployee?.Vacation2020.Aralik2020_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2020_C1_Display => Toplam2020_C1.ToString();
        public string Toplam2020_C2_Display => Toplam2020_C2.ToString();
        public string Toplam2020_C3_Display => Toplam2020_C3.ToString();
        public string Toplam2020_C4_Display => Toplam2020_C4.ToString();
        public string Toplam2020_C5_Display => Toplam2020_C5.ToString();
        public string Toplam2020_C6_Display => Toplam2020_C6.ToString();

        public int Toplam2020_C1 =>
            Int32.Parse(Ocak2020_C1_Display) +
            Int32.Parse(Subat2020_C1_Display) +
            Int32.Parse(Mart2020_C1_Display) +
            Int32.Parse(Nisan2020_C1_Display) +
            Int32.Parse(Mayis2020_C1_Display) +
            Int32.Parse(Haziran2020_C1_Display) +
            Int32.Parse(Temmuz2020_C1_Display) +
            Int32.Parse(Agustos2020_C1_Display) +
            Int32.Parse(Eylul2020_C1_Display) +
            Int32.Parse(Ekim2020_C1_Display) +
            Int32.Parse(Kasim2020_C1_Display) +
            Int32.Parse(Aralik2020_C1_Display);

        public int Toplam2020_C2 =>
            Int32.Parse(Ocak2020_C2_Display) +
            Int32.Parse(Subat2020_C2_Display) +
            Int32.Parse(Mart2020_C2_Display) +
            Int32.Parse(Nisan2020_C2_Display) +
            Int32.Parse(Mayis2020_C2_Display) +
            Int32.Parse(Haziran2020_C2_Display) +
            Int32.Parse(Temmuz2020_C2_Display) +
            Int32.Parse(Agustos2020_C2_Display) +
            Int32.Parse(Eylul2020_C2_Display) +
            Int32.Parse(Ekim2020_C2_Display) +
            Int32.Parse(Kasim2020_C2_Display) +
            Int32.Parse(Aralik2020_C2_Display);
        public int Toplam2020_C3 =>
            Int32.Parse(Ocak2020_C3_Display) +
            Int32.Parse(Subat2020_C3_Display) +
            Int32.Parse(Mart2020_C3_Display) +
            Int32.Parse(Nisan2020_C3_Display) +
            Int32.Parse(Mayis2020_C3_Display) +
            Int32.Parse(Haziran2020_C3_Display) +
            Int32.Parse(Temmuz2020_C3_Display) +
            Int32.Parse(Agustos2020_C3_Display) +
            Int32.Parse(Eylul2020_C3_Display) +
            Int32.Parse(Ekim2020_C3_Display) +
            Int32.Parse(Kasim2020_C3_Display) +
            Int32.Parse(Aralik2020_C3_Display);
        public int Toplam2020_C4 =>
            Int32.Parse(Ocak2020_C4_Display) +
            Int32.Parse(Subat2020_C4_Display) +
            Int32.Parse(Mart2020_C4_Display) +
            Int32.Parse(Nisan2020_C4_Display) +
            Int32.Parse(Mayis2020_C4_Display) +
            Int32.Parse(Haziran2020_C4_Display) +
            Int32.Parse(Temmuz2020_C4_Display) +
            Int32.Parse(Agustos2020_C4_Display) +
            Int32.Parse(Eylul2020_C4_Display) +
            Int32.Parse(Ekim2020_C4_Display) +
            Int32.Parse(Kasim2020_C4_Display) +
            Int32.Parse(Aralik2020_C4_Display);

        public int Toplam2020_C5 =>
            Int32.Parse(Ocak2020_C5_Display) +
            Int32.Parse(Subat2020_C5_Display) +
            Int32.Parse(Mart2020_C5_Display) +
            Int32.Parse(Nisan2020_C5_Display) +
            Int32.Parse(Mayis2020_C5_Display) +
            Int32.Parse(Haziran2020_C5_Display) +
            Int32.Parse(Temmuz2020_C5_Display) +
            Int32.Parse(Agustos2020_C5_Display) +
            Int32.Parse(Eylul2020_C5_Display) +
            Int32.Parse(Ekim2020_C5_Display) +
            Int32.Parse(Kasim2020_C5_Display) +
            Int32.Parse(Aralik2020_C5_Display);
        public int Toplam2020_C6 =>
            Int32.Parse(Ocak2020_C6_Display) +
            Int32.Parse(Subat2020_C6_Display) +
            Int32.Parse(Mart2020_C6_Display) +
            Int32.Parse(Nisan2020_C6_Display) +
            Int32.Parse(Mayis2020_C6_Display) +
            Int32.Parse(Haziran2020_C6_Display) +
            Int32.Parse(Temmuz2020_C6_Display) +
            Int32.Parse(Agustos2020_C6_Display) +
            Int32.Parse(Eylul2020_C6_Display) +
            Int32.Parse(Ekim2020_C6_Display) +
            Int32.Parse(Kasim2020_C6_Display) +
            Int32.Parse(Aralik2020_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2020_C1_Display));
            OnPropertyChanged(nameof(Ocak2020_C2_Display));
            OnPropertyChanged(nameof(Ocak2020_C3_Display));
            OnPropertyChanged(nameof(Ocak2020_C4_Display));
            OnPropertyChanged(nameof(Ocak2020_C5_Display));
            OnPropertyChanged(nameof(Ocak2020_C6_Display));

            OnPropertyChanged(nameof(Subat2020_C1_Display));
            OnPropertyChanged(nameof(Subat2020_C2_Display));
            OnPropertyChanged(nameof(Subat2020_C3_Display));
            OnPropertyChanged(nameof(Subat2020_C4_Display));
            OnPropertyChanged(nameof(Subat2020_C5_Display));
            OnPropertyChanged(nameof(Subat2020_C6_Display));

            OnPropertyChanged(nameof(Mart2020_C1_Display));
            OnPropertyChanged(nameof(Mart2020_C2_Display));
            OnPropertyChanged(nameof(Mart2020_C3_Display));
            OnPropertyChanged(nameof(Mart2020_C4_Display));
            OnPropertyChanged(nameof(Mart2020_C5_Display));
            OnPropertyChanged(nameof(Mart2020_C6_Display));

            OnPropertyChanged(nameof(Nisan2020_C1_Display));
            OnPropertyChanged(nameof(Nisan2020_C2_Display));
            OnPropertyChanged(nameof(Nisan2020_C3_Display));
            OnPropertyChanged(nameof(Nisan2020_C4_Display));
            OnPropertyChanged(nameof(Nisan2020_C5_Display));
            OnPropertyChanged(nameof(Nisan2020_C6_Display));

            OnPropertyChanged(nameof(Mayis2020_C1_Display));
            OnPropertyChanged(nameof(Mayis2020_C2_Display));
            OnPropertyChanged(nameof(Mayis2020_C3_Display));
            OnPropertyChanged(nameof(Mayis2020_C4_Display));
            OnPropertyChanged(nameof(Mayis2020_C5_Display));
            OnPropertyChanged(nameof(Mayis2020_C6_Display));

            OnPropertyChanged(nameof(Haziran2020_C1_Display));
            OnPropertyChanged(nameof(Haziran2020_C2_Display));
            OnPropertyChanged(nameof(Haziran2020_C3_Display));
            OnPropertyChanged(nameof(Haziran2020_C4_Display));
            OnPropertyChanged(nameof(Haziran2020_C5_Display));
            OnPropertyChanged(nameof(Haziran2020_C6_Display));

            OnPropertyChanged(nameof(Temmuz2020_C1_Display));
            OnPropertyChanged(nameof(Temmuz2020_C2_Display));
            OnPropertyChanged(nameof(Temmuz2020_C3_Display));
            OnPropertyChanged(nameof(Temmuz2020_C4_Display));
            OnPropertyChanged(nameof(Temmuz2020_C5_Display));
            OnPropertyChanged(nameof(Temmuz2020_C6_Display));

            OnPropertyChanged(nameof(Agustos2020_C1_Display));
            OnPropertyChanged(nameof(Agustos2020_C2_Display));
            OnPropertyChanged(nameof(Agustos2020_C3_Display));
            OnPropertyChanged(nameof(Agustos2020_C4_Display));
            OnPropertyChanged(nameof(Agustos2020_C5_Display));
            OnPropertyChanged(nameof(Agustos2020_C6_Display));

            OnPropertyChanged(nameof(Eylul2020_C1_Display));
            OnPropertyChanged(nameof(Eylul2020_C2_Display));
            OnPropertyChanged(nameof(Eylul2020_C3_Display));
            OnPropertyChanged(nameof(Eylul2020_C4_Display));
            OnPropertyChanged(nameof(Eylul2020_C5_Display));
            OnPropertyChanged(nameof(Eylul2020_C6_Display));

            OnPropertyChanged(nameof(Ekim2020_C1_Display));
            OnPropertyChanged(nameof(Ekim2020_C2_Display));
            OnPropertyChanged(nameof(Ekim2020_C3_Display));
            OnPropertyChanged(nameof(Ekim2020_C4_Display));
            OnPropertyChanged(nameof(Ekim2020_C5_Display));
            OnPropertyChanged(nameof(Ekim2020_C6_Display));

            OnPropertyChanged(nameof(Kasim2020_C1_Display));
            OnPropertyChanged(nameof(Kasim2020_C2_Display));
            OnPropertyChanged(nameof(Kasim2020_C3_Display));
            OnPropertyChanged(nameof(Kasim2020_C4_Display));
            OnPropertyChanged(nameof(Kasim2020_C5_Display));
            OnPropertyChanged(nameof(Kasim2020_C6_Display));

            OnPropertyChanged(nameof(Aralik2020_C1_Display));
            OnPropertyChanged(nameof(Aralik2020_C2_Display));
            OnPropertyChanged(nameof(Aralik2020_C3_Display));
            OnPropertyChanged(nameof(Aralik2020_C4_Display));
            OnPropertyChanged(nameof(Aralik2020_C5_Display));
            OnPropertyChanged(nameof(Aralik2020_C6_Display));

            OnPropertyChanged(nameof(Toplam2020_C1_Display));
            OnPropertyChanged(nameof(Toplam2020_C2_Display));
            OnPropertyChanged(nameof(Toplam2020_C3_Display));
            OnPropertyChanged(nameof(Toplam2020_C4_Display));
            OnPropertyChanged(nameof(Toplam2020_C5_Display));
            OnPropertyChanged(nameof(Toplam2020_C6_Display));

        }

    }
}
