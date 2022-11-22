using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class MilitaryStore : ViewModelBase
    {
        readonly IGetAllMilitaryServicesQuery _getAllMilitaryServices;
        readonly List<MilitaryServiceStatus> _militaries;
        public IEnumerable<MilitaryServiceStatus> Militaries => _militaries;

        public ObservableCollection<MilitaryListingItemViewModel> _militaryListingItemViewModels;

        public event Action MilitaryServicesLoaded;

        public MilitaryStore(IGetAllMilitaryServicesQuery getAllMilitaryServicesQuery)
        {
            _getAllMilitaryServices = getAllMilitaryServicesQuery;
            _militaries = new List<MilitaryServiceStatus>();

            _militaryListingItemViewModels = new ObservableCollection<MilitaryListingItemViewModel>();

            MilitaryServicesLoaded += MilitaryStore_MilitaryServicesLoaded;
        }

        public async Task LoadMilitaryServices()
        {
            IEnumerable<MilitaryServiceStatus> militaries = await _getAllMilitaryServices.GetAllMilitaries();

            _militaries.Clear();
            _militaries.AddRange(militaries);

            MilitaryServicesLoaded?.Invoke();
        }

        private void MilitaryStore_MilitaryServicesLoaded()
        {
            _militaryListingItemViewModels.Clear();
            foreach (MilitaryServiceStatus military in Militaries)
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
            MilitaryServicesLoaded += MilitaryStore_MilitaryServicesLoaded;
            base.Dispose();
        }
    }
}
