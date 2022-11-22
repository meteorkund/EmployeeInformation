using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees;

public class EducationListingViewModel : ViewModelBase
{
    readonly EducationStore _educationStore;
    public IEnumerable<EducationListingItemViewModel> EducationListingItemViewModels => _educationStore._educationListingItemViewModels;


    public EducationListingViewModel(EmployeeDetailsFormViewModel employeeDetailsFormViewModel, EducationStore educationStore)
    {
        _educationStore = educationStore;
    }


}
