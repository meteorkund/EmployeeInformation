using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Commands
{
    public class EditEmployeeCommand : AsyncCommandBase
    {
        readonly EditEmployeeViewModel _editEmployeeViewModel;
        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeeStore _employeeStore;

        public EditEmployeeCommand(EditEmployeeViewModel editEmployeeViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            _editEmployeeViewModel = editEmployeeViewModel;
            _employeeStore = employeeStore;
            _modalNavigationStore = modalNavigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            EmployeeDetailsFormViewModel formViewModel = _editEmployeeViewModel.EmployeeDetailsFormViewModel;

            formViewModel.ErrorMessage = null;
            formViewModel.IsSubmitting = true;
            formViewModel.IsSaved = true;
            formViewModel.SaveStatus = "PERSONEL BİLGİLERİ GÜNCELLENİYOR...";

            Employee employee = new Employee(
                _editEmployeeViewModel.EmployeeId,
                formViewModel.PhotoSource,
                formViewModel.Isim,
                formViewModel.Soyisim,
                formViewModel.Durum,
                formViewModel.TCKimlik,
                formViewModel.DogumTarihi,
                formViewModel.MedeniDurum,
                formViewModel.EgitimDurumu,
                formViewModel.Askerlik,
                formViewModel.Departman,
                formViewModel.Gorev,
                formViewModel.IseGiris,
                formViewModel.IstenCikis,
                formViewModel.Maas,
                formViewModel.CepTel,
                formViewModel.CalismaSuresi,
                formViewModel.BaslamaTarihi,
                formViewModel.EvAdresi,
                formViewModel.EkBilgi,
                new Vacation2018 { Id = _editEmployeeViewModel.EmployeeId }
                );

            try
            {
                await _employeeStore.Update(employee);
                await Task.Delay(3000);
                formViewModel.IsSaved = true;
                formViewModel.SaveStatus = "GÜNCELLEME BAŞARILI!";

            }
            catch (Exception)
            {
                formViewModel.IsSaved= false;
                formViewModel.ErrorMessage = "Personel güncelleme sırasında hata oluştu. Daha sonra tekrar deneyiniz.";
            }
            finally
            {
                formViewModel.IsSubmitting = false;
            }
        }
    }
}
