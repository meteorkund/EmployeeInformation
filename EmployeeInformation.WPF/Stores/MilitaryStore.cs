using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class MilitaryStore
    {
        readonly IGetAllMilitaryServicesQuery _getAllMilitaryServices;
        readonly List<MilitaryServiceStatus> _militaries;
        public IEnumerable<MilitaryServiceStatus> Militaries => _militaries;
        public event Action MilitaryServicesLoaded;

        public MilitaryStore(IGetAllMilitaryServicesQuery getAllMilitaryServicesQuery)
        {
            _getAllMilitaryServices = getAllMilitaryServicesQuery;
            _militaries = new List<MilitaryServiceStatus>();
        }

        public async Task LoadMilitaryServices()
        {
            IEnumerable<MilitaryServiceStatus> militaries = await _getAllMilitaryServices.GetAllMilitaries();

            _militaries.Clear();
            _militaries.AddRange(militaries);

            MilitaryServicesLoaded?.Invoke();
        }
    }
}
