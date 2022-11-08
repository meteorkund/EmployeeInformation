using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands;

public class LoadMilitaryServicesCommand : CommandBase
{
    readonly MilitaryStore _militaryStore;
    public LoadMilitaryServicesCommand(MilitaryListingViewModel militaryListingViewModel, MilitaryStore militaryStore)
    {
        _militaryStore = militaryStore;
    }

    public override async void Execute(object? parameter)
    {
        try
        {
            await _militaryStore.LoadMilitaryServices();
        }
        catch
        {
            MessageBox.Show("ASKERLİK DURUMLARI YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
        }
    }
}
