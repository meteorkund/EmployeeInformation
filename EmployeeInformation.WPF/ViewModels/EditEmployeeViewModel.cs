using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EditEmployeeViewModel : ViewModelBase
    {
        public Guid EmployeeId { get; }
        public EmployeeDetailsFormViewModel EmployeeDetailsFormViewModel { get; }

        public EditEmployeeViewModel(Employee employee, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            EmployeeId = employee.Id;

            ICommand submitCommand = new EditEmployeeCommand(this, employeeStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            EmployeeDetailsFormViewModel = new EmployeeDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Durum = employee.Durum,
                Isim = employee.Isim,
                Soyisim = employee.Soyisim,
                TCKimlik = employee.TCKimlik,
                Departman = employee.Departman,
                DogumTarihi = employee.DogumTarihi,
                Gorev = employee.Gorev,
                MedeniDurum = employee.MedeniDurum,
                Maas = employee.Maas,
                EgitimDurumu = employee.EgitimDurumu,
                CepTel = employee.CepTel,
                Askerlik = employee.Askerlik,
                BaslamaTarihi = employee.BaslamaTarihi,
                CalismaSuresi = employee.CalismaSuresi,
                IseGiris = employee.IseGiris,
                IstenCikis = employee.IstenCikis,
                EvAdresi = employee.Adres,
                EkBilgi= employee.EkBilgi               

            };
        }
    }
}
