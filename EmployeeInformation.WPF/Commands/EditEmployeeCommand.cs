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
                formViewModel.CreatedDate,
                new Vacation2018
                {
                    Ocak2018_C1 = formViewModel.Ocak2018_C1,
                    Ocak2018_C2 = formViewModel.Ocak2018_C2,
                    Ocak2018_C3 = formViewModel.Ocak2018_C3,
                    Ocak2018_C4 = formViewModel.Ocak2018_C4,
                    Ocak2018_C5 = formViewModel.Ocak2018_C5,
                    Ocak2018_C6 = formViewModel.Ocak2018_C6,

                    Subat2018_C1 = formViewModel.Subat2018_C1,
                    Subat2018_C2 = formViewModel.Subat2018_C2,
                    Subat2018_C3 = formViewModel.Subat2018_C3,
                    Subat2018_C4 = formViewModel.Subat2018_C4,
                    Subat2018_C5 = formViewModel.Subat2018_C5,
                    Subat2018_C6 = formViewModel.Subat2018_C6,

                    Mart2018_C1 = formViewModel.Mart2018_C1,
                    Mart2018_C2 = formViewModel.Mart2018_C2,
                    Mart2018_C3 = formViewModel.Mart2018_C3,
                    Mart2018_C4 = formViewModel.Mart2018_C4,
                    Mart2018_C5 = formViewModel.Mart2018_C5,
                    Mart2018_C6 = formViewModel.Mart2018_C6,

                    Nisan2018_C1 = formViewModel.Nisan2018_C1,
                    Nisan2018_C2 = formViewModel.Nisan2018_C2,
                    Nisan2018_C3 = formViewModel.Nisan2018_C3,
                    Nisan2018_C4 = formViewModel.Nisan2018_C4,
                    Nisan2018_C5 = formViewModel.Nisan2018_C5,
                    Nisan2018_C6 = formViewModel.Nisan2018_C6,

                    Mayis2018_C1 = formViewModel.Mayis2018_C1,
                    Mayis2018_C2 = formViewModel.Mayis2018_C2,
                    Mayis2018_C3 = formViewModel.Mayis2018_C3,
                    Mayis2018_C4 = formViewModel.Mayis2018_C4,
                    Mayis2018_C5 = formViewModel.Mayis2018_C5,
                    Mayis2018_C6 = formViewModel.Mayis2018_C6,

                    Haziran2018_C1 = formViewModel.Haziran2018_C1,
                    Haziran2018_C2 = formViewModel.Haziran2018_C2,
                    Haziran2018_C3 = formViewModel.Haziran2018_C3,
                    Haziran2018_C4 = formViewModel.Haziran2018_C4,
                    Haziran2018_C5 = formViewModel.Haziran2018_C5,
                    Haziran2018_C6 = formViewModel.Haziran2018_C6,

                    Temmuz2018_C1 = formViewModel.Temmuz2018_C1,
                    Temmuz2018_C2 = formViewModel.Temmuz2018_C2,
                    Temmuz2018_C3 = formViewModel.Temmuz2018_C3,
                    Temmuz2018_C4 = formViewModel.Temmuz2018_C4,
                    Temmuz2018_C5 = formViewModel.Temmuz2018_C5,
                    Temmuz2018_C6 = formViewModel.Temmuz2018_C6,

                    Agustos2018_C1 = formViewModel.Agustos2018_C1,
                    Agustos2018_C2 = formViewModel.Agustos2018_C2,
                    Agustos2018_C3 = formViewModel.Agustos2018_C3,
                    Agustos2018_C4 = formViewModel.Agustos2018_C4,
                    Agustos2018_C5 = formViewModel.Agustos2018_C5,
                    Agustos2018_C6 = formViewModel.Agustos2018_C6,

                    Eylul2018_C1 = formViewModel.Eylul2018_C1,
                    Eylul2018_C2 = formViewModel.Eylul2018_C2,
                    Eylul2018_C3 = formViewModel.Eylul2018_C3,
                    Eylul2018_C4 = formViewModel.Eylul2018_C4,
                    Eylul2018_C5 = formViewModel.Eylul2018_C5,
                    Eylul2018_C6 = formViewModel.Eylul2018_C6,

                    Ekim2018_C1 = formViewModel.Ekim2018_C1,
                    Ekim2018_C2 = formViewModel.Ekim2018_C2,
                    Ekim2018_C3 = formViewModel.Ekim2018_C3,
                    Ekim2018_C4 = formViewModel.Ekim2018_C4,
                    Ekim2018_C5 = formViewModel.Ekim2018_C5,
                    Ekim2018_C6 = formViewModel.Ekim2018_C6,

                    Kasim2018_C1 = formViewModel.Kasim2018_C1,
                    Kasim2018_C2 = formViewModel.Kasim2018_C2,
                    Kasim2018_C3 = formViewModel.Kasim2018_C3,
                    Kasim2018_C4 = formViewModel.Kasim2018_C4,
                    Kasim2018_C5 = formViewModel.Kasim2018_C5,
                    Kasim2018_C6 = formViewModel.Kasim2018_C6,

                    Aralik2018_C1 = formViewModel.Aralik2018_C1,
                    Aralik2018_C2 = formViewModel.Aralik2018_C2,
                    Aralik2018_C3 = formViewModel.Aralik2018_C3,
                    Aralik2018_C4 = formViewModel.Aralik2018_C4,
                    Aralik2018_C5 = formViewModel.Aralik2018_C5,
                    Aralik2018_C6 = formViewModel.Aralik2018_C6,
                });

            try
            {
                await _employeeStore.Update(employee);
                formViewModel.IsSaved = true;
                formViewModel.SaveStatus = "GÜNCELLEME BAŞARILI!";

            }
            catch (Exception)
            {
                formViewModel.IsSaved = false;
                formViewModel.ErrorMessage = "Personel güncelleme sırasında hata oluştu. Daha sonra tekrar deneyiniz.";
            }
            finally
            {
                formViewModel.IsSubmitting = false;
            }
        }
    }
}
