using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands
{

    public class LoadComboBoxItemsCommand : CommandBase
    {
        readonly DepartmentStore _departmentStore;
        readonly EducationStore _educationStore;
        readonly MaritialStore _maritialStore;
        readonly MilitaryStore _militaryStore;
        readonly SectorStore _sectorStore;


        public LoadComboBoxItemsCommand(DepartmentStore departmentStore, EducationStore educationStore, MaritialStore maritialStore, MilitaryStore militaryStore, SectorStore sectorStore)
        {
            _departmentStore = departmentStore;
            _educationStore = educationStore;
            _maritialStore = maritialStore;
            _militaryStore = militaryStore;
            _sectorStore = sectorStore;
        }

        public override async void Execute(object? parameter)
        {
            try
            {
                await _departmentStore.LoadDepartments();
                await _educationStore.LoadEducations();
                await _maritialStore.LoadMaritialStatus();
                await _militaryStore.LoadMilitaryServices();
                await _sectorStore.LoadSectors();
            }
            catch
            {
                MessageBox.Show("VERİLER YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
            }
        }
    }
}
