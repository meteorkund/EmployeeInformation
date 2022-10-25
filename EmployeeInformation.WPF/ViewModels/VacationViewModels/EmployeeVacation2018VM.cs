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
        public int Ocak2018_C1_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c1;
        public int Ocak2018_C2_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c2;
        public int Ocak2018_C3_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c3;
        public int Ocak2018_C4_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c4;
        public int Ocak2018_C5_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c5;
        public int Ocak2018_C6_Display => (int)SelectedEmployee?.Vacation2018.Ocak2018_c6;
        #endregion
        #region ŞUBAT
        public int Subat2018_C1_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c1);
        public int Subat2018_C2_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c2);
        public int Subat2018_C3_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c3);
        public int Subat2018_C4_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c4);
        public int Subat2018_C5_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c5);
        public int Subat2018_C6_Display => (int)(SelectedEmployee?.Vacation2018.Subat2018_c6);
        #endregion

        public int Toplam2018_C1_Display => Ocak2018_C1_Display + Subat2018_C1_Display;
        public int Toplam2018_C2_Display => Ocak2018_C2_Display + Subat2018_C2_Display;
        public int Toplam2018_C3_Display => Ocak2018_C3_Display + Subat2018_C3_Display;
        public int Toplam2018_C4_Display => Ocak2018_C4_Display + Subat2018_C4_Display;
        public int Toplam2018_C5_Display => Ocak2018_C5_Display + Subat2018_C5_Display;
        public int Toplam2018_C6_Display => Ocak2018_C6_Display + Subat2018_C6_Display;


        public ICommand Submit2018Command { get; }


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

            OnPropertyChanged(nameof(Toplam2018_C1_Display));
            OnPropertyChanged(nameof(Toplam2018_C2_Display));

        }
    }
}
