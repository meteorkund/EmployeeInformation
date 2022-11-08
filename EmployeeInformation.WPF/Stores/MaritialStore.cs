using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class MaritialStore
    {
        readonly IGetAllMaritialStatusQuery _getAllMaritialStatus;
        readonly List<Maritial> _maritialStatus;

        public IEnumerable<Maritial> MaritialStatus => _maritialStatus;
        public event Action MaritialStatusLoaded;

        public MaritialStore(IGetAllMaritialStatusQuery getAllMaritialStatus)
        {
            _getAllMaritialStatus = getAllMaritialStatus;
            _maritialStatus = new List<Maritial>();
        }

        public async Task LoadMaritialStatus()
        {
            IEnumerable<Maritial> maritialStatuses = await _getAllMaritialStatus.GetAllMaritalStatus();

            _maritialStatus.Clear();
            _maritialStatus.AddRange(maritialStatuses);

            MaritialStatusLoaded?.Invoke();
        }
    }
}
