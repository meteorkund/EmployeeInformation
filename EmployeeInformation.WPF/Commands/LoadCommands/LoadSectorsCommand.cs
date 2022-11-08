using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Sectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands
{
    public class LoadSectorsCommand : CommandBase
    {

        readonly SectorStore _sectorStore;

        public LoadSectorsCommand(SectorListingViewModel sectorListingViewModel, SectorStore sectorStore)
        {
            _sectorStore = sectorStore;
        }

        public override async void Execute(object? parameter)
        {
            try
            {
                await _sectorStore.LoadSectors();
            }
            catch
            {
                MessageBox.Show("SEKTÖRLER YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
            }
        }
    }
}
