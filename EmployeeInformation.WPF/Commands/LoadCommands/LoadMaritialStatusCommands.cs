using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MaritialStat;
using System;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands;

public class LoadMaritialStatusCommands : CommandBase
{

    readonly MaritialStore _maritialStore;
    public LoadMaritialStatusCommands(MaritialStatusListingViewModel maritialStatusListingViewModel, MaritialStore maritialStore)
    {
        _maritialStore = maritialStore;
    }

    public override async void Execute(object? parameter)
    {
        try
        {
            await _maritialStore.LoadMaritialStatus();
        }
        catch (Exception)
        {

            MessageBox.Show("MEDENİ DURUMLAR YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
        }
    }
}
