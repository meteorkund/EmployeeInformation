using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MaritialStat
{
    public class MaritialStatusListingViewModel : ViewModelBase
    {
        readonly MaritialStore _maritialStore;

        public IEnumerable<MaritialStatusListingItemViewModel> MaritialStatusListingItemViewModels => _maritialStore._maritialStatusListingItemViewModels;


        public MaritialStatusListingViewModel(EmployeeDetailsFormViewModel employeeDetailsFormViewModel, MaritialStore maritialStore)
        {
            _maritialStore = maritialStore;
        }


    }
}
