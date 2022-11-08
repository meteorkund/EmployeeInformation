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
        readonly ObservableCollection<MaritialStatusListingItemViewModel> _maritialStatusListingItemViewModels;
        readonly MaritialStore _maritialStore;

        public IEnumerable<MaritialStatusListingItemViewModel> MaritialStatusListingItemViewModels => _maritialStatusListingItemViewModels;

        public ICommand LoadMaritialStatusCommand { get; }

        public MaritialStatusListingViewModel(MaritialStore maritialStore)
        {
            _maritialStore = maritialStore;
            _maritialStatusListingItemViewModels = new ObservableCollection<MaritialStatusListingItemViewModel>();

            LoadMaritialStatusCommand = new LoadMaritialStatusCommands(this, maritialStore);

            _maritialStore.MaritialStatusLoaded += MaritialStore_MaritialStatusLoaded;
        }

        public static MaritialStatusListingViewModel LoadMaritialStatus(MaritialStore maritialStore)
        {
            MaritialStatusListingViewModel viewModel = new MaritialStatusListingViewModel(maritialStore);
            viewModel.LoadMaritialStatusCommand.Execute(null);
            return viewModel;
        }
        private void MaritialStore_MaritialStatusLoaded()
        {
            _maritialStatusListingItemViewModels.Clear();
            foreach (Maritial maritialStatus in _maritialStore.MaritialStatus)
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
            _maritialStore.MaritialStatusLoaded -= MaritialStore_MaritialStatusLoaded;
        }
    }
}
