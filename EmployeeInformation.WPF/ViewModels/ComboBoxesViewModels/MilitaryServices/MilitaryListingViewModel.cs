using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices
{
    public class MilitaryListingViewModel : ViewModelBase
    {
        readonly MilitaryStore _militaryStore;

        public IEnumerable<MilitaryListingItemViewModel> MilitaryListingItemViewModels =>_militaryStore._militaryListingItemViewModels;


        public MilitaryListingViewModel(EmployeeDetailsFormViewModel employeeDetailsFormViewModel, MilitaryStore militaryStore)
        {
            _militaryStore = militaryStore;
        }


    }
}
