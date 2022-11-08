using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class EducationStore
    {
        readonly IGetAllEducationsQuery _getAllEducations;

        readonly List<Education> _educations;
        public IEnumerable<Education> Educations => _educations;

        public event Action EducationsLoaded;

        public EducationStore(IGetAllEducationsQuery getAllEducations)
        {
            _getAllEducations = getAllEducations;
            _educations = new List<Education>();
        }

        public async Task LoadEducations()
        {
            IEnumerable<Education> educations = await _getAllEducations.GetAllEducations();

            _educations.Clear();
            _educations.AddRange(educations);

            EducationsLoaded?.Invoke();
        }
    }
}
