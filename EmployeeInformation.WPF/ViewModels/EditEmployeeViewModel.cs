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
        public int EmployeeId { get; }
        public EmployeeDetailsFormViewModel EmployeeDetailsFormViewModel { get; }

        public EditEmployeeViewModel(Employee employee, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            EmployeeId = employee.Id;

            ICommand submitCommand = new EditEmployeeCommand(this, employeeStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            EmployeeDetailsFormViewModel = new EmployeeDetailsFormViewModel(submitCommand, cancelCommand)
            {
                IsAdding = false,

                CreatedDate = employee.CreatedDate,

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
                EkBilgi= employee.EkBilgi,
                
                Ocak2018_C1 = employee.Vacation2018.Ocak2018_C1,
                Ocak2018_C2 = employee.Vacation2018.Ocak2018_C2,
                Ocak2018_C3 = employee.Vacation2018.Ocak2018_C3,
                Ocak2018_C4 = employee.Vacation2018.Ocak2018_C4,
                Ocak2018_C5 = employee.Vacation2018.Ocak2018_C5,
                Ocak2018_C6 = employee.Vacation2018.Ocak2018_C6,

                Subat2018_C1 = employee.Vacation2018.Subat2018_C1,
                Subat2018_C2 = employee.Vacation2018.Subat2018_C2,
                Subat2018_C3 = employee.Vacation2018.Subat2018_C3,
                Subat2018_C4 = employee.Vacation2018.Subat2018_C4,
                Subat2018_C5 = employee.Vacation2018.Subat2018_C5,
                Subat2018_C6 = employee.Vacation2018.Subat2018_C6,

                Mart2018_C1 = employee.Vacation2018.Mart2018_C1,
                Mart2018_C2 = employee.Vacation2018.Mart2018_C2,
                Mart2018_C3 = employee.Vacation2018.Mart2018_C3,
                Mart2018_C4 = employee.Vacation2018.Mart2018_C4,
                Mart2018_C5 = employee.Vacation2018.Mart2018_C5,
                Mart2018_C6 = employee.Vacation2018.Mart2018_C6,

                Nisan2018_C1 = employee.Vacation2018.Nisan2018_C1,
                Nisan2018_C2 = employee.Vacation2018.Nisan2018_C2,
                Nisan2018_C3 = employee.Vacation2018.Nisan2018_C3,
                Nisan2018_C4 = employee.Vacation2018.Nisan2018_C4,
                Nisan2018_C5 = employee.Vacation2018.Nisan2018_C5,
                Nisan2018_C6 = employee.Vacation2018.Nisan2018_C6,

                Mayis2018_C1 = employee.Vacation2018.Mayis2018_C1,
                Mayis2018_C2 = employee.Vacation2018.Mayis2018_C2,
                Mayis2018_C3 = employee.Vacation2018.Mayis2018_C3,
                Mayis2018_C4 = employee.Vacation2018.Mayis2018_C4,
                Mayis2018_C5 = employee.Vacation2018.Mayis2018_C5,
                Mayis2018_C6 = employee.Vacation2018.Mayis2018_C6,

                Haziran2018_C1 = employee.Vacation2018.Haziran2018_C1,
                Haziran2018_C2 = employee.Vacation2018.Haziran2018_C2,
                Haziran2018_C3 = employee.Vacation2018.Haziran2018_C3,
                Haziran2018_C4 = employee.Vacation2018.Haziran2018_C4,
                Haziran2018_C5 = employee.Vacation2018.Haziran2018_C5,
                Haziran2018_C6 = employee.Vacation2018.Haziran2018_C6,

                Temmuz2018_C1 = employee.Vacation2018.Temmuz2018_C1,
                Temmuz2018_C2 = employee.Vacation2018.Temmuz2018_C2,
                Temmuz2018_C3 = employee.Vacation2018.Temmuz2018_C3,
                Temmuz2018_C4 = employee.Vacation2018.Temmuz2018_C4,
                Temmuz2018_C5 = employee.Vacation2018.Temmuz2018_C5,
                Temmuz2018_C6 = employee.Vacation2018.Temmuz2018_C6,

                Agustos2018_C1 = employee.Vacation2018.Agustos2018_C1,
                Agustos2018_C2 = employee.Vacation2018.Agustos2018_C2,
                Agustos2018_C3 = employee.Vacation2018.Agustos2018_C3,
                Agustos2018_C4 = employee.Vacation2018.Agustos2018_C4,
                Agustos2018_C5 = employee.Vacation2018.Agustos2018_C5,
                Agustos2018_C6 = employee.Vacation2018.Agustos2018_C6,

                Eylul2018_C1 = employee.Vacation2018.Eylul2018_C1,
                Eylul2018_C2 = employee.Vacation2018.Eylul2018_C2,
                Eylul2018_C3 = employee.Vacation2018.Eylul2018_C3,
                Eylul2018_C4 = employee.Vacation2018.Eylul2018_C4,
                Eylul2018_C5 = employee.Vacation2018.Eylul2018_C5,
                Eylul2018_C6 = employee.Vacation2018.Eylul2018_C6,

                Ekim2018_C1 = employee.Vacation2018.Ekim2018_C1,
                Ekim2018_C2 = employee.Vacation2018.Ekim2018_C2,
                Ekim2018_C3 = employee.Vacation2018.Ekim2018_C3,
                Ekim2018_C4 = employee.Vacation2018.Ekim2018_C4,
                Ekim2018_C5 = employee.Vacation2018.Ekim2018_C5,
                Ekim2018_C6 = employee.Vacation2018.Ekim2018_C6,

                Kasim2018_C1 = employee.Vacation2018.Kasim2018_C1,
                Kasim2018_C2 = employee.Vacation2018.Kasim2018_C2,
                Kasim2018_C3 = employee.Vacation2018.Kasim2018_C3,
                Kasim2018_C4 = employee.Vacation2018.Kasim2018_C4,
                Kasim2018_C5 = employee.Vacation2018.Kasim2018_C5,
                Kasim2018_C6 = employee.Vacation2018.Kasim2018_C6,

                Aralik2018_C1 = employee.Vacation2018.Aralik2018_C1,
                Aralik2018_C2 = employee.Vacation2018.Aralik2018_C2,
                Aralik2018_C3 = employee.Vacation2018.Aralik2018_C3,
                Aralik2018_C4 = employee.Vacation2018.Aralik2018_C4,
                Aralik2018_C5 = employee.Vacation2018.Aralik2018_C5,
                Aralik2018_C6 = employee.Vacation2018.Aralik2018_C6,
            };
        }
    }
}
