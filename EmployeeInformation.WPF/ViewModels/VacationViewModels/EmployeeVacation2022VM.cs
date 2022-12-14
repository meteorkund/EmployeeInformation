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
    public class EmployeeVacation2022VM : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        public Employee SelectedEmployee => _selectedEmployeeStore.SelectedEmployee;


        public EmployeeVacation2022VM(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;
            _selectedEmployeeStore.SelectedEmployeeChanged += SelectedEmployeeStore_SelectedEmployeeChanged;

        }

        #region OCAK
        public string Ocak2022_C1_Display => SelectedEmployee?.Vacation2022.Ocak2022_C1.ToString();
        public string Ocak2022_C2_Display => SelectedEmployee?.Vacation2022.Ocak2022_C2.ToString();
        public string Ocak2022_C3_Display => SelectedEmployee?.Vacation2022.Ocak2022_C3.ToString();
        public string Ocak2022_C4_Display => SelectedEmployee?.Vacation2022.Ocak2022_C4.ToString();
        public string Ocak2022_C5_Display => SelectedEmployee?.Vacation2022.Ocak2022_C5.ToString();
        public string Ocak2022_C6_Display => SelectedEmployee?.Vacation2022.Ocak2022_C6.ToString();
        #endregion

        #region ŞUBAT
        public string Subat2022_C1_Display => SelectedEmployee?.Vacation2022.Subat2022_C1.ToString();
        public string Subat2022_C2_Display => SelectedEmployee?.Vacation2022.Subat2022_C2.ToString();
        public string Subat2022_C3_Display => SelectedEmployee?.Vacation2022.Subat2022_C3.ToString();
        public string Subat2022_C4_Display => SelectedEmployee?.Vacation2022.Subat2022_C4.ToString();
        public string Subat2022_C5_Display => SelectedEmployee?.Vacation2022.Subat2022_C5.ToString();
        public string Subat2022_C6_Display => SelectedEmployee?.Vacation2022.Subat2022_C6.ToString();
        #endregion

        #region MART
        public string Mart2022_C1_Display => SelectedEmployee?.Vacation2022.Mart2022_C1.ToString();
        public string Mart2022_C2_Display => SelectedEmployee?.Vacation2022.Mart2022_C2.ToString();
        public string Mart2022_C3_Display => SelectedEmployee?.Vacation2022.Mart2022_C3.ToString();
        public string Mart2022_C4_Display => SelectedEmployee?.Vacation2022.Mart2022_C4.ToString();
        public string Mart2022_C5_Display => SelectedEmployee?.Vacation2022.Mart2022_C5.ToString();
        public string Mart2022_C6_Display => SelectedEmployee?.Vacation2022.Mart2022_C6.ToString();
        #endregion

        #region NİSAN
        public string Nisan2022_C1_Display => SelectedEmployee?.Vacation2022.Nisan2022_C1.ToString();
        public string Nisan2022_C2_Display => SelectedEmployee?.Vacation2022.Nisan2022_C2.ToString();
        public string Nisan2022_C3_Display => SelectedEmployee?.Vacation2022.Nisan2022_C3.ToString();
        public string Nisan2022_C4_Display => SelectedEmployee?.Vacation2022.Nisan2022_C4.ToString();
        public string Nisan2022_C5_Display => SelectedEmployee?.Vacation2022.Nisan2022_C5.ToString();
        public string Nisan2022_C6_Display => SelectedEmployee?.Vacation2022.Nisan2022_C6.ToString();
        #endregion

        #region MAYIS
        public string Mayis2022_C1_Display => SelectedEmployee?.Vacation2022.Mayis2022_C1.ToString();
        public string Mayis2022_C2_Display => SelectedEmployee?.Vacation2022.Mayis2022_C2.ToString();
        public string Mayis2022_C3_Display => SelectedEmployee?.Vacation2022.Mayis2022_C3.ToString();
        public string Mayis2022_C4_Display => SelectedEmployee?.Vacation2022.Mayis2022_C4.ToString();
        public string Mayis2022_C5_Display => SelectedEmployee?.Vacation2022.Mayis2022_C5.ToString();
        public string Mayis2022_C6_Display => SelectedEmployee?.Vacation2022.Mayis2022_C6.ToString();
        #endregion

        #region HAZİRAN
        public string Haziran2022_C1_Display => SelectedEmployee?.Vacation2022.Haziran2022_C1.ToString();
        public string Haziran2022_C2_Display => SelectedEmployee?.Vacation2022.Haziran2022_C2.ToString();
        public string Haziran2022_C3_Display => SelectedEmployee?.Vacation2022.Haziran2022_C3.ToString();
        public string Haziran2022_C4_Display => SelectedEmployee?.Vacation2022.Haziran2022_C4.ToString();
        public string Haziran2022_C5_Display => SelectedEmployee?.Vacation2022.Haziran2022_C5.ToString();
        public string Haziran2022_C6_Display => SelectedEmployee?.Vacation2022.Haziran2022_C6.ToString();
        #endregion

        #region TEMMUZ
        public string Temmuz2022_C1_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C1.ToString();
        public string Temmuz2022_C2_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C2.ToString();
        public string Temmuz2022_C3_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C3.ToString();
        public string Temmuz2022_C4_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C4.ToString();
        public string Temmuz2022_C5_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C5.ToString();
        public string Temmuz2022_C6_Display => SelectedEmployee?.Vacation2022.Temmuz2022_C6.ToString();
        #endregion

        #region AĞUSTOS
        public string Agustos2022_C1_Display => SelectedEmployee?.Vacation2022.Agustos2022_C1.ToString();
        public string Agustos2022_C2_Display => SelectedEmployee?.Vacation2022.Agustos2022_C2.ToString();
        public string Agustos2022_C3_Display => SelectedEmployee?.Vacation2022.Agustos2022_C3.ToString();
        public string Agustos2022_C4_Display => SelectedEmployee?.Vacation2022.Agustos2022_C4.ToString();
        public string Agustos2022_C5_Display => SelectedEmployee?.Vacation2022.Agustos2022_C5.ToString();
        public string Agustos2022_C6_Display => SelectedEmployee?.Vacation2022.Agustos2022_C6.ToString();
        #endregion

        #region EYLÜL
        public string Eylul2022_C1_Display => SelectedEmployee?.Vacation2022.Eylul2022_C1.ToString();
        public string Eylul2022_C2_Display => SelectedEmployee?.Vacation2022.Eylul2022_C2.ToString();
        public string Eylul2022_C3_Display => SelectedEmployee?.Vacation2022.Eylul2022_C3.ToString();
        public string Eylul2022_C4_Display => SelectedEmployee?.Vacation2022.Eylul2022_C4.ToString();
        public string Eylul2022_C5_Display => SelectedEmployee?.Vacation2022.Eylul2022_C5.ToString();
        public string Eylul2022_C6_Display => SelectedEmployee?.Vacation2022.Eylul2022_C6.ToString();
        #endregion

        #region EKİM
        public string Ekim2022_C1_Display => SelectedEmployee?.Vacation2022.Ekim2022_C1.ToString();
        public string Ekim2022_C2_Display => SelectedEmployee?.Vacation2022.Ekim2022_C2.ToString();
        public string Ekim2022_C3_Display => SelectedEmployee?.Vacation2022.Ekim2022_C3.ToString();
        public string Ekim2022_C4_Display => SelectedEmployee?.Vacation2022.Ekim2022_C4.ToString();
        public string Ekim2022_C5_Display => SelectedEmployee?.Vacation2022.Ekim2022_C5.ToString();
        public string Ekim2022_C6_Display => SelectedEmployee?.Vacation2022.Ekim2022_C6.ToString();
        #endregion

        #region KASIM
        public string Kasim2022_C1_Display => SelectedEmployee?.Vacation2022.Kasim2022_C1.ToString();
        public string Kasim2022_C2_Display => SelectedEmployee?.Vacation2022.Kasim2022_C2.ToString();
        public string Kasim2022_C3_Display => SelectedEmployee?.Vacation2022.Kasim2022_C3.ToString();
        public string Kasim2022_C4_Display => SelectedEmployee?.Vacation2022.Kasim2022_C4.ToString();
        public string Kasim2022_C5_Display => SelectedEmployee?.Vacation2022.Kasim2022_C5.ToString();
        public string Kasim2022_C6_Display => SelectedEmployee?.Vacation2022.Kasim2022_C6.ToString();
        #endregion

        #region ARALIK
        public string Aralik2022_C1_Display => SelectedEmployee?.Vacation2022.Aralik2022_C1.ToString();
        public string Aralik2022_C2_Display => SelectedEmployee?.Vacation2022.Aralik2022_C2.ToString();
        public string Aralik2022_C3_Display => SelectedEmployee?.Vacation2022.Aralik2022_C3.ToString();
        public string Aralik2022_C4_Display => SelectedEmployee?.Vacation2022.Aralik2022_C4.ToString();
        public string Aralik2022_C5_Display => SelectedEmployee?.Vacation2022.Aralik2022_C5.ToString();
        public string Aralik2022_C6_Display => SelectedEmployee?.Vacation2022.Aralik2022_C6.ToString();
        #endregion

        #region TOPLAM
        public string Toplam2022_C1_Display => Toplam2022_C1.ToString();
        public string Toplam2022_C2_Display => Toplam2022_C2.ToString();
        public string Toplam2022_C3_Display => Toplam2022_C3.ToString();
        public string Toplam2022_C4_Display => Toplam2022_C4.ToString();
        public string Toplam2022_C5_Display => Toplam2022_C5.ToString();
        public string Toplam2022_C6_Display => Toplam2022_C6.ToString();

        public int Toplam2022_C1 =>
            Int32.Parse(Ocak2022_C1_Display) +
            Int32.Parse(Subat2022_C1_Display) +
            Int32.Parse(Mart2022_C1_Display) +
            Int32.Parse(Nisan2022_C1_Display) +
            Int32.Parse(Mayis2022_C1_Display) +
            Int32.Parse(Haziran2022_C1_Display) +
            Int32.Parse(Temmuz2022_C1_Display) +
            Int32.Parse(Agustos2022_C1_Display) +
            Int32.Parse(Eylul2022_C1_Display) +
            Int32.Parse(Ekim2022_C1_Display) +
            Int32.Parse(Kasim2022_C1_Display) +
            Int32.Parse(Aralik2022_C1_Display);

        public int Toplam2022_C2 =>
            Int32.Parse(Ocak2022_C2_Display) +
            Int32.Parse(Subat2022_C2_Display) +
            Int32.Parse(Mart2022_C2_Display) +
            Int32.Parse(Nisan2022_C2_Display) +
            Int32.Parse(Mayis2022_C2_Display) +
            Int32.Parse(Haziran2022_C2_Display) +
            Int32.Parse(Temmuz2022_C2_Display) +
            Int32.Parse(Agustos2022_C2_Display) +
            Int32.Parse(Eylul2022_C2_Display) +
            Int32.Parse(Ekim2022_C2_Display) +
            Int32.Parse(Kasim2022_C2_Display) +
            Int32.Parse(Aralik2022_C2_Display);
        public int Toplam2022_C3 =>
            Int32.Parse(Ocak2022_C3_Display) +
            Int32.Parse(Subat2022_C3_Display) +
            Int32.Parse(Mart2022_C3_Display) +
            Int32.Parse(Nisan2022_C3_Display) +
            Int32.Parse(Mayis2022_C3_Display) +
            Int32.Parse(Haziran2022_C3_Display) +
            Int32.Parse(Temmuz2022_C3_Display) +
            Int32.Parse(Agustos2022_C3_Display) +
            Int32.Parse(Eylul2022_C3_Display) +
            Int32.Parse(Ekim2022_C3_Display) +
            Int32.Parse(Kasim2022_C3_Display) +
            Int32.Parse(Aralik2022_C3_Display);
        public int Toplam2022_C4 =>
            Int32.Parse(Ocak2022_C4_Display) +
            Int32.Parse(Subat2022_C4_Display) +
            Int32.Parse(Mart2022_C4_Display) +
            Int32.Parse(Nisan2022_C4_Display) +
            Int32.Parse(Mayis2022_C4_Display) +
            Int32.Parse(Haziran2022_C4_Display) +
            Int32.Parse(Temmuz2022_C4_Display) +
            Int32.Parse(Agustos2022_C4_Display) +
            Int32.Parse(Eylul2022_C4_Display) +
            Int32.Parse(Ekim2022_C4_Display) +
            Int32.Parse(Kasim2022_C4_Display) +
            Int32.Parse(Aralik2022_C4_Display);

        public int Toplam2022_C5 =>
            Int32.Parse(Ocak2022_C5_Display) +
            Int32.Parse(Subat2022_C5_Display) +
            Int32.Parse(Mart2022_C5_Display) +
            Int32.Parse(Nisan2022_C5_Display) +
            Int32.Parse(Mayis2022_C5_Display) +
            Int32.Parse(Haziran2022_C5_Display) +
            Int32.Parse(Temmuz2022_C5_Display) +
            Int32.Parse(Agustos2022_C5_Display) +
            Int32.Parse(Eylul2022_C5_Display) +
            Int32.Parse(Ekim2022_C5_Display) +
            Int32.Parse(Kasim2022_C5_Display) +
            Int32.Parse(Aralik2022_C5_Display);
        public int Toplam2022_C6 =>
            Int32.Parse(Ocak2022_C6_Display) +
            Int32.Parse(Subat2022_C6_Display) +
            Int32.Parse(Mart2022_C6_Display) +
            Int32.Parse(Nisan2022_C6_Display) +
            Int32.Parse(Mayis2022_C6_Display) +
            Int32.Parse(Haziran2022_C6_Display) +
            Int32.Parse(Temmuz2022_C6_Display) +
            Int32.Parse(Agustos2022_C6_Display) +
            Int32.Parse(Eylul2022_C6_Display) +
            Int32.Parse(Ekim2022_C6_Display) +
            Int32.Parse(Kasim2022_C6_Display) +
            Int32.Parse(Aralik2022_C6_Display);

        #endregion


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2022_C1_Display));
            OnPropertyChanged(nameof(Ocak2022_C2_Display));
            OnPropertyChanged(nameof(Ocak2022_C3_Display));
            OnPropertyChanged(nameof(Ocak2022_C4_Display));
            OnPropertyChanged(nameof(Ocak2022_C5_Display));
            OnPropertyChanged(nameof(Ocak2022_C6_Display));

            OnPropertyChanged(nameof(Subat2022_C1_Display));
            OnPropertyChanged(nameof(Subat2022_C2_Display));
            OnPropertyChanged(nameof(Subat2022_C3_Display));
            OnPropertyChanged(nameof(Subat2022_C4_Display));
            OnPropertyChanged(nameof(Subat2022_C5_Display));
            OnPropertyChanged(nameof(Subat2022_C6_Display));

            OnPropertyChanged(nameof(Mart2022_C1_Display));
            OnPropertyChanged(nameof(Mart2022_C2_Display));
            OnPropertyChanged(nameof(Mart2022_C3_Display));
            OnPropertyChanged(nameof(Mart2022_C4_Display));
            OnPropertyChanged(nameof(Mart2022_C5_Display));
            OnPropertyChanged(nameof(Mart2022_C6_Display));

            OnPropertyChanged(nameof(Nisan2022_C1_Display));
            OnPropertyChanged(nameof(Nisan2022_C2_Display));
            OnPropertyChanged(nameof(Nisan2022_C3_Display));
            OnPropertyChanged(nameof(Nisan2022_C4_Display));
            OnPropertyChanged(nameof(Nisan2022_C5_Display));
            OnPropertyChanged(nameof(Nisan2022_C6_Display));

            OnPropertyChanged(nameof(Mayis2022_C1_Display));
            OnPropertyChanged(nameof(Mayis2022_C2_Display));
            OnPropertyChanged(nameof(Mayis2022_C3_Display));
            OnPropertyChanged(nameof(Mayis2022_C4_Display));
            OnPropertyChanged(nameof(Mayis2022_C5_Display));
            OnPropertyChanged(nameof(Mayis2022_C6_Display));

            OnPropertyChanged(nameof(Haziran2022_C1_Display));
            OnPropertyChanged(nameof(Haziran2022_C2_Display));
            OnPropertyChanged(nameof(Haziran2022_C3_Display));
            OnPropertyChanged(nameof(Haziran2022_C4_Display));
            OnPropertyChanged(nameof(Haziran2022_C5_Display));
            OnPropertyChanged(nameof(Haziran2022_C6_Display));

            OnPropertyChanged(nameof(Temmuz2022_C1_Display));
            OnPropertyChanged(nameof(Temmuz2022_C2_Display));
            OnPropertyChanged(nameof(Temmuz2022_C3_Display));
            OnPropertyChanged(nameof(Temmuz2022_C4_Display));
            OnPropertyChanged(nameof(Temmuz2022_C5_Display));
            OnPropertyChanged(nameof(Temmuz2022_C6_Display));

            OnPropertyChanged(nameof(Agustos2022_C1_Display));
            OnPropertyChanged(nameof(Agustos2022_C2_Display));
            OnPropertyChanged(nameof(Agustos2022_C3_Display));
            OnPropertyChanged(nameof(Agustos2022_C4_Display));
            OnPropertyChanged(nameof(Agustos2022_C5_Display));
            OnPropertyChanged(nameof(Agustos2022_C6_Display));

            OnPropertyChanged(nameof(Eylul2022_C1_Display));
            OnPropertyChanged(nameof(Eylul2022_C2_Display));
            OnPropertyChanged(nameof(Eylul2022_C3_Display));
            OnPropertyChanged(nameof(Eylul2022_C4_Display));
            OnPropertyChanged(nameof(Eylul2022_C5_Display));
            OnPropertyChanged(nameof(Eylul2022_C6_Display));

            OnPropertyChanged(nameof(Ekim2022_C1_Display));
            OnPropertyChanged(nameof(Ekim2022_C2_Display));
            OnPropertyChanged(nameof(Ekim2022_C3_Display));
            OnPropertyChanged(nameof(Ekim2022_C4_Display));
            OnPropertyChanged(nameof(Ekim2022_C5_Display));
            OnPropertyChanged(nameof(Ekim2022_C6_Display));

            OnPropertyChanged(nameof(Kasim2022_C1_Display));
            OnPropertyChanged(nameof(Kasim2022_C2_Display));
            OnPropertyChanged(nameof(Kasim2022_C3_Display));
            OnPropertyChanged(nameof(Kasim2022_C4_Display));
            OnPropertyChanged(nameof(Kasim2022_C5_Display));
            OnPropertyChanged(nameof(Kasim2022_C6_Display));

            OnPropertyChanged(nameof(Aralik2022_C1_Display));
            OnPropertyChanged(nameof(Aralik2022_C2_Display));
            OnPropertyChanged(nameof(Aralik2022_C3_Display));
            OnPropertyChanged(nameof(Aralik2022_C4_Display));
            OnPropertyChanged(nameof(Aralik2022_C5_Display));
            OnPropertyChanged(nameof(Aralik2022_C6_Display));

            OnPropertyChanged(nameof(Toplam2022_C1_Display));
            OnPropertyChanged(nameof(Toplam2022_C2_Display));
            OnPropertyChanged(nameof(Toplam2022_C3_Display));
            OnPropertyChanged(nameof(Toplam2022_C4_Display));
            OnPropertyChanged(nameof(Toplam2022_C5_Display));
            OnPropertyChanged(nameof(Toplam2022_C6_Display));

        }

    }
}
