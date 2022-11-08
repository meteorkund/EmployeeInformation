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
        readonly ObservableCollection<MilitaryListingItemViewModel> _militaryListingItemViewModels;
        readonly MilitaryStore _militaryStore;

        public IEnumerable<MilitaryListingItemViewModel> MilitaryListingItemViewModels => _militaryListingItemViewModels;

        public ICommand LoadMilitaryServicesCommand { get; }

        public MilitaryListingViewModel(MilitaryStore militaryStore)
        {
            _militaryStore = militaryStore;
            _militaryListingItemViewModels = new ObservableCollection<MilitaryListingItemViewModel>();

            LoadMilitaryServicesCommand = new LoadMilitaryServicesCommand(this, militaryStore);

            _militaryStore.MilitaryServicesLoaded += MilitaryStore_MilitaryServicesLoaded;
        }

        public static MilitaryListingViewModel LoadMilitaryServices(MilitaryStore militaryStore)
        {
            MilitaryListingViewModel viewModel = new MilitaryListingViewModel(militaryStore);
            viewModel.LoadMilitaryServicesCommand.Execute(null);
            return viewModel;
        }

        private void MilitaryStore_MilitaryServicesLoaded()
        {
            _militaryListingItemViewModels.Clear();
            foreach (MilitaryServiceStatus military in _militaryStore.Militaries)
            {
                AddMilitaryService(military);
            }
        }

        private void AddMilitaryService(MilitaryServiceStatus military)
        {
            MilitaryListingItemViewModel itemViewModel = new MilitaryListingItemViewModel(military);
            _militaryListingItemViewModels.Add(itemViewModel);
        }
        protected override void Dispose()
        {
            _militaryStore.MilitaryServicesLoaded += MilitaryStore_MilitaryServicesLoaded;
            base.Dispose();
        }
    }
}
