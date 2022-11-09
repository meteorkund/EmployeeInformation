using EmployeeInformation.WPF.Stores;

namespace EmployeeInformation.WPF.ViewModels;

public class MainViewModel : ViewModelBase
{
    readonly ModalNavigationStore _modalNavigationStore;
    public ViewModelBase CurrentModalViewModel => _modalNavigationStore.CurrentViewModel;
    public EmployeesViewModel EmployeesViewModel { get; }

    public bool IsModalOpen => _modalNavigationStore.IsOpen;

    public MainViewModel(ModalNavigationStore modalNavigationStore, EmployeesViewModel employeesViewModel)
    {
        _modalNavigationStore = modalNavigationStore;
        EmployeesViewModel = employeesViewModel;

        _modalNavigationStore.CurrentViewModelChanged += _modalNavigationStore_CurrentViewModelChanged;

    }

    private void _modalNavigationStore_CurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentModalViewModel));
        OnPropertyChanged(nameof(IsModalOpen));
    }

    protected override void Dispose()
    {
        _modalNavigationStore.CurrentViewModelChanged -= _modalNavigationStore_CurrentViewModelChanged;

        base.Dispose();
    }



}
