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

            Submit2018Command = new EditVacationViewModel();
        }

        #region OCAK
        public int Ocak2018_C1 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c1;
        public int Ocak2018_C2 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c2;
        public int Ocak2018_C3 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c3;
        public int Ocak2018_C4 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c4;
        public int Ocak2018_C5 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c5;
        public int Ocak2018_C6 => (int)SelectedEmployee?.Vacation2018.Ocak2018_c6;
        #endregion
        #region ŞUBAT
        public int Subat2018_C1 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c1);
        public int Subat2018_C2 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c2);
        public int Subat2018_C3 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c3);
        public int Subat2018_C4 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c4);
        public int Subat2018_C5 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c5);
        public int Subat2018_C6 => (int)(SelectedEmployee?.Vacation2018.Subat2018_c6);
        #endregion

        public int Toplam2018_C1 => Ocak2018_C1 + Subat2018_C1;
        public int Toplam2018_C2 => Ocak2018_C2 + Subat2018_C2;
        public int Toplam2018_C3 => Ocak2018_C3 + Subat2018_C3;
        public int Toplam2018_C4 => Ocak2018_C4 + Subat2018_C4;
        public int Toplam2018_C5 => Ocak2018_C5 + Subat2018_C5;
        public int Toplam2018_C6 => Ocak2018_C6 + Subat2018_C6;


        public ICommand Submit2018Command { get; }


        protected override void Dispose()
        {
            _selectedEmployeeStore.SelectedEmployeeChanged -= SelectedEmployeeStore_SelectedEmployeeChanged;
            base.Dispose();
        }


        private void SelectedEmployeeStore_SelectedEmployeeChanged()
        {
            OnPropertyChanged(nameof(Ocak2018_C1));
            OnPropertyChanged(nameof(Ocak2018_C2));
            OnPropertyChanged(nameof(Ocak2018_C3));
            OnPropertyChanged(nameof(Ocak2018_C4));
            OnPropertyChanged(nameof(Ocak2018_C5));
            OnPropertyChanged(nameof(Ocak2018_C6));

            OnPropertyChanged(nameof(Subat2018_C1));
            OnPropertyChanged(nameof(Subat2018_C2));
            OnPropertyChanged(nameof(Subat2018_C3));
            OnPropertyChanged(nameof(Subat2018_C4));
            OnPropertyChanged(nameof(Subat2018_C5));
            OnPropertyChanged(nameof(Subat2018_C6));

            OnPropertyChanged(nameof(Toplam2018_C1));
            OnPropertyChanged(nameof(Toplam2018_C2));

        }
    }
}
