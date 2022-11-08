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

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees
{
    public class EducationListingViewModel : ViewModelBase
    {
        readonly ObservableCollection<EducationListingItemViewModel> _educationListingItemViewModels;
        readonly EducationStore _educationStore;
        public IEnumerable<EducationListingItemViewModel> EducationListingItemViewModels => _educationListingItemViewModels;

        public ICommand LoadEducationsCommand { get; }

        public EducationListingViewModel(EducationStore educationStore)
        {
            _educationStore = educationStore;
            _educationListingItemViewModels = new ObservableCollection<EducationListingItemViewModel>();
            LoadEducationsCommand = new LoadEducationsCommand(this, educationStore);
            _educationStore.EducationsLoaded += EducationStore_EducationsLoaded;
        }

        public static EducationListingViewModel LoadEducations(EducationStore educationStore)
        {
            EducationListingViewModel viewModel = new EducationListingViewModel(educationStore);
            viewModel.LoadEducationsCommand.Execute(null);
            return viewModel;
        }

        private void EducationStore_EducationsLoaded()
        {
            _educationListingItemViewModels.Clear();
            foreach (Education education in _educationStore.Educations)
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
            _educationStore.EducationsLoaded -= EducationStore_EducationsLoaded;
            base.Dispose();
        }
    }
}
