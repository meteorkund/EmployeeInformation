using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Sectors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class SectorStore : ViewModelBase
    {
        readonly IGetAllSectorsQuery _getAllSectors;

        readonly List<Sector> _sectors;
        public IEnumerable<Sector> Sectors => _sectors;
        public ObservableCollection<SectorListingItemViewModel> _sectorListingItemViewModels;


        public event Action SectorsLoaded;

        public SectorStore(IGetAllSectorsQuery getAllSectors)
        {
            _getAllSectors = getAllSectors;
            _sectors = new List<Sector>();

            _sectorListingItemViewModels = new ObservableCollection<SectorListingItemViewModel>();

            SectorsLoaded += SectorStore_SectorsLoaded;

        }

        public async Task LoadSectors()
        {
            IEnumerable<Sector> sectors = await _getAllSectors.GetAllSectors();

            _sectors.Clear();
            _sectors.AddRange(sectors);

            SectorsLoaded?.Invoke();
        }

        private void SectorStore_SectorsLoaded()
        {
            _sectorListingItemViewModels.Clear();
            foreach (Sector sector in Sectors)
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
            SectorsLoaded -= SectorStore_SectorsLoaded;
            base.Dispose();
        }
    }
}
