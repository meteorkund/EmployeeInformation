using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MaritialStat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores;

public class MaritialStore : ViewModelBase
{
    readonly IGetAllMaritialStatusQuery _getAllMaritialStatus;
    readonly List<Maritial> _maritialStatus;

    public IEnumerable<Maritial> MaritialStatus => _maritialStatus;

    public ObservableCollection<MaritialStatusListingItemViewModel> _maritialStatusListingItemViewModels;

    public event Action MaritialStatusLoaded;

    public MaritialStore(IGetAllMaritialStatusQuery getAllMaritialStatus)
    {
        _getAllMaritialStatus = getAllMaritialStatus;
        _maritialStatus = new List<Maritial>();

        _maritialStatusListingItemViewModels = new ObservableCollection<MaritialStatusListingItemViewModel>();

        MaritialStatusLoaded += MaritialStore_MaritialStatusLoaded;

    }

    public async Task LoadMaritialStatus()
    {
        IEnumerable<Maritial> maritialStatuses = await _getAllMaritialStatus.GetAllMaritalStatus();

        _maritialStatus.Clear();
        _maritialStatus.AddRange(maritialStatuses);

        MaritialStatusLoaded?.Invoke();
    }

    private void MaritialStore_MaritialStatusLoaded()
    {
        _maritialStatusListingItemViewModels.Clear();
        foreach (Maritial maritialStatus in MaritialStatus)
        {
            AddMaritialStatus(maritialStatus);
        }
    }

    private void AddMaritialStatus(Maritial maritialStatus)
    {
        MaritialStatusListingItemViewModel viewModel = new MaritialStatusListingItemViewModel(maritialStatus);
        _maritialStatusListingItemViewModels.Add(viewModel);
    }

    protected override void Dispose()
    {
        MaritialStatusLoaded -= MaritialStore_MaritialStatusLoaded;
    }
}
