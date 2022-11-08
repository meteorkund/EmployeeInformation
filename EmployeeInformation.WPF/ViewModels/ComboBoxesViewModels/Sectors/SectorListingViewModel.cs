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
using System.Windows.Documents;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Sectors
{
    public class SectorListingViewModel : ViewModelBase
    {
        readonly ObservableCollection<SectorListingItemViewModel> _sectorListingItemViewModels;
        readonly SectorStore _sectorStore;
        public IEnumerable<SectorListingItemViewModel> SectorListingItemViewModels => _sectorListingItemViewModels;

        public ICommand LoadSectorsCommand { get; }

        public SectorListingViewModel(SectorStore sectorStore)
        {
            _sectorStore = sectorStore;
            _sectorListingItemViewModels = new ObservableCollection<SectorListingItemViewModel>();
            LoadSectorsCommand = new LoadSectorsCommand(this, sectorStore);
            _sectorStore.SectorsLoaded += SectorStore_SectorsLoaded;
        }

        public static SectorListingViewModel LoadSectors(SectorStore sectorStore)
        {
            SectorListingViewModel viewModel = new SectorListingViewModel(sectorStore);
            viewModel.LoadSectorsCommand.Execute(null);
            return viewModel;
        }

        private void SectorStore_SectorsLoaded()
        {
            _sectorListingItemViewModels.Clear();
            foreach (Sector sector in _sectorStore.Sectors)
            {
                AddSector(sector);
            }
        }

        private void AddSector(Sector sector)
        {
            SectorListingItemViewModel itemViewModel = new SectorListingItemViewModel(sector);

            _sectorListingItemViewModels.Add(itemViewModel);
        }

        protected override void Dispose()
        {
            _sectorStore.SectorsLoaded -= SectorStore_SectorsLoaded;
            base.Dispose();
        }
    }
}
