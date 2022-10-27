using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Ocak2019_C1_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C1;
        public int Ocak2019_C2_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C2;
        public int Ocak2019_C3_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C3;
        public int Ocak2019_C4_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C4;
        public int Ocak2019_C5_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C5;
        public int Ocak2019_C6_Display => (int)SelectedEmployee?.Vacation2019.Ocak2019_C6;
        #endregion

        #region ŞUBAT
        public int Subat2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C1);
        public int Subat2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C2);
        public int Subat2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C3);
        public int Subat2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C4);
        public int Subat2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C5);
        public int Subat2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Subat2019_C6);
        #endregion

        #region MART
        public int Mart2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C1);
        public int Mart2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C2);
        public int Mart2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C3);
        public int Mart2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C4);
        public int Mart2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C5);
        public int Mart2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Mart2019_C6);
        #endregion

        #region NİSAN
        public int Nisan2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C1);
        public int Nisan2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C2);
        public int Nisan2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C3);
        public int Nisan2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C4);
        public int Nisan2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C5);
        public int Nisan2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Nisan2019_C6);
        #endregion

        #region MAYIS
        public int Mayis2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C1);
        public int Mayis2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C2);
        public int Mayis2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C3);
        public int Mayis2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C4);
        public int Mayis2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C5);
        public int Mayis2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Mayis2019_C6);
        #endregion

        #region HAZİRAN
        public int Haziran2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C1);
        public int Haziran2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C2);
        public int Haziran2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C3);
        public int Haziran2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C4);
        public int Haziran2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C5);
        public int Haziran2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Haziran2019_C6);
        #endregion

        #region TEMMUZ
        public int Temmuz2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C1);
        public int Temmuz2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C2);
        public int Temmuz2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C3);
        public int Temmuz2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C4);
        public int Temmuz2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C5);
        public int Temmuz2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Temmuz2019_C6);
        #endregion

        #region AĞUSTOS
        public int Agustos2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C1);
        public int Agustos2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C2);
        public int Agustos2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C3);
        public int Agustos2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C4);
        public int Agustos2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C5);
        public int Agustos2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Agustos2019_C6);
        #endregion

        #region EYLÜL
        public int Eylul2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C1);
        public int Eylul2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C2);
        public int Eylul2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C3);
        public int Eylul2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C4);
        public int Eylul2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C5);
        public int Eylul2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Eylul2019_C6);
        #endregion

        #region EKİM
        public int Ekim2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C1);
        public int Ekim2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C2);
        public int Ekim2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C3);
        public int Ekim2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C4);
        public int Ekim2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C5);
        public int Ekim2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Ekim2019_C6);
        #endregion

        #region KASIM
        public int Kasim2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C1);
        public int Kasim2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C2);
        public int Kasim2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C3);
        public int Kasim2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C4);
        public int Kasim2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C5);
        public int Kasim2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Kasim2019_C6);
        #endregion

        #region ARALIK
        public int Aralik2019_C1_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C1);
        public int Aralik2019_C2_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C2);
        public int Aralik2019_C3_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C3);
        public int Aralik2019_C4_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C4);
        public int Aralik2019_C5_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C5);
        public int Aralik2019_C6_Display => (int)(SelectedEmployee?.Vacation2019.Aralik2019_C6);
        #endregion

        #region TOPLAM
        public int Toplam2019_C1_Display => Ocak2019_C1_Display + Subat2019_C1_Display + Mart2019_C1_Display + Nisan2019_C1_Display + Mayis2019_C1_Display + Haziran2019_C1_Display + Temmuz2019_C1_Display + Agustos2019_C1_Display + Eylul2019_C1_Display + Ekim2019_C1_Display + Kasim2019_C1_Display + Aralik2019_C1_Display;
        public int Toplam2019_C2_Display => Ocak2019_C2_Display + Subat2019_C2_Display + Mart2019_C2_Display + Nisan2019_C2_Display + Mayis2019_C2_Display + Haziran2019_C2_Display + Temmuz2019_C2_Display + Agustos2019_C2_Display + Eylul2019_C2_Display + Ekim2019_C2_Display + Kasim2019_C2_Display + Aralik2019_C2_Display;
        public int Toplam2019_C3_Display => Ocak2019_C3_Display + Subat2019_C3_Display + Mart2019_C3_Display + Nisan2019_C3_Display + Mayis2019_C3_Display + Haziran2019_C3_Display + Temmuz2019_C3_Display + Agustos2019_C3_Display + Eylul2019_C3_Display + Ekim2019_C3_Display + Kasim2019_C3_Display + Aralik2019_C3_Display;
        public int Toplam2019_C4_Display => Ocak2019_C4_Display + Subat2019_C4_Display + Mart2019_C4_Display + Nisan2019_C4_Display + Mayis2019_C4_Display + Haziran2019_C4_Display + Temmuz2019_C4_Display + Agustos2019_C4_Display + Eylul2019_C4_Display + Ekim2019_C4_Display + Kasim2019_C4_Display + Aralik2019_C4_Display;
        public int Toplam2019_C5_Display => Ocak2019_C5_Display + Subat2019_C5_Display + Mart2019_C5_Display + Nisan2019_C5_Display + Mayis2019_C5_Display + Haziran2019_C5_Display + Temmuz2019_C5_Display + Agustos2019_C5_Display + Eylul2019_C5_Display + Ekim2019_C5_Display + Kasim2019_C5_Display + Aralik2019_C5_Display;
        public int Toplam2019_C6_Display => Ocak2019_C6_Display + Subat2019_C6_Display + Mart2019_C6_Display + Nisan2019_C6_Display + Mayis2019_C6_Display + Haziran2019_C6_Display + Temmuz2019_C6_Display + Agustos2019_C6_Display + Eylul2019_C6_Display + Ekim2019_C6_Display + Kasim2019_C6_Display + Aralik2019_C6_Display;

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
