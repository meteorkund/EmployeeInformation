using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class EducationStore : ViewModelBase
    {
        readonly IGetAllEducationsQuery _getAllEducations;

        readonly List<Education> _educations;
        public IEnumerable<Education> Educations => _educations;

        public ObservableCollection<EducationListingItemViewModel> _educationListingItemViewModels;

        public event Action EducationsLoaded;

        public EducationStore(IGetAllEducationsQuery getAllEducations)
        {
            _getAllEducations = getAllEducations;
            _educations = new List<Education>();

            _educationListingItemViewModels = new ObservableCollection<EducationListingItemViewModel>();

            EducationsLoaded += EducationStore_EducationsLoaded;

        }

        public async Task LoadEducations()
        {
            IEnumerable<Education> educations = await _getAllEducations.GetAllEducations();

            _educations.Clear();
            _educations.AddRange(educations);

            EducationsLoaded?.Invoke();
        }

        private void EducationStore_EducationsLoaded()
        {
            _educationListingItemViewModels.Clear();
            foreach (Education education in Educations)
            {
                AddEducation(education);
            }
        }

        private void AddEducation(Education education)
        {
            EducationListingItemViewModel itemViewModel = new EducationListingItemViewModel(education);

            _educationListingItemViewModels.Add(itemViewModel);
        }

        protected override void Dispose()
        {
            EducationsLoaded -= EducationStore_EducationsLoaded;
            base.Dispose();
        }
    }
}
