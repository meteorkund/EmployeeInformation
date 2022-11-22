using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Sectors;

public class SectorListingViewModel : ViewModelBase
{
    readonly SectorStore _sectorStore;
    public IEnumerable<SectorListingItemViewModel> SectorListingItemViewModels => _sectorStore._sectorListingItemViewModels;


    public SectorListingViewModel(EmployeeDetailsFormViewModel employeeDetailsFormViewModel, SectorStore sectorStore)
    {
        _sectorStore = sectorStore;

    }

}
