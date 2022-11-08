using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees
{
    public class EducationListingItemViewModel : ViewModelBase
    {
        public Education Education { get; private set; }

        public EducationListingItemViewModel(Education education)
        {
            Education = education;
        }

        public int EducationId => Education.Id;
        public string EducationDegree => Education.EducationDegree;
    }
}
