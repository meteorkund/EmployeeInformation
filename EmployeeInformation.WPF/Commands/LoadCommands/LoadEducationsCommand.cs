using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands
{
    public class LoadEducationsCommand : CommandBase
    {
        readonly EducationStore _educationStore;

        public LoadEducationsCommand(EducationListingViewModel educationListingViewModel, EducationStore educationStore)
        {
            _educationStore = educationStore;
        }

        public override async void Execute(object? parameter)
        {
            try
            {
                await _educationStore.LoadEducations();
            }
            catch
            {
                MessageBox.Show("EĞİTİMLER YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
            }
        }
    }
}
