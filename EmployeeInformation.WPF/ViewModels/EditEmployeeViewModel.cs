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
                PhotoSource = employee.Fotograf,
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

                #region 2018
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
                #endregion

                #region 2019
                Ocak2019_C1 = employee.Vacation2019.Ocak2019_C1,
                Ocak2019_C2 = employee.Vacation2019.Ocak2019_C2,
                Ocak2019_C3 = employee.Vacation2019.Ocak2019_C3,
                Ocak2019_C4 = employee.Vacation2019.Ocak2019_C4,
                Ocak2019_C5 = employee.Vacation2019.Ocak2019_C5,
                Ocak2019_C6 = employee.Vacation2019.Ocak2019_C6,

                Subat2019_C1 = employee.Vacation2019.Subat2019_C1,
                Subat2019_C2 = employee.Vacation2019.Subat2019_C2,
                Subat2019_C3 = employee.Vacation2019.Subat2019_C3,
                Subat2019_C4 = employee.Vacation2019.Subat2019_C4,
                Subat2019_C5 = employee.Vacation2019.Subat2019_C5,
                Subat2019_C6 = employee.Vacation2019.Subat2019_C6,

                Mart2019_C1 = employee.Vacation2019.Mart2019_C1,
                Mart2019_C2 = employee.Vacation2019.Mart2019_C2,
                Mart2019_C3 = employee.Vacation2019.Mart2019_C3,
                Mart2019_C4 = employee.Vacation2019.Mart2019_C4,
                Mart2019_C5 = employee.Vacation2019.Mart2019_C5,
                Mart2019_C6 = employee.Vacation2019.Mart2019_C6,

                Nisan2019_C1 = employee.Vacation2019.Nisan2019_C1,
                Nisan2019_C2 = employee.Vacation2019.Nisan2019_C2,
                Nisan2019_C3 = employee.Vacation2019.Nisan2019_C3,
                Nisan2019_C4 = employee.Vacation2019.Nisan2019_C4,
                Nisan2019_C5 = employee.Vacation2019.Nisan2019_C5,
                Nisan2019_C6 = employee.Vacation2019.Nisan2019_C6,

                Mayis2019_C1 = employee.Vacation2019.Mayis2019_C1,
                Mayis2019_C2 = employee.Vacation2019.Mayis2019_C2,
                Mayis2019_C3 = employee.Vacation2019.Mayis2019_C3,
                Mayis2019_C4 = employee.Vacation2019.Mayis2019_C4,
                Mayis2019_C5 = employee.Vacation2019.Mayis2019_C5,
                Mayis2019_C6 = employee.Vacation2019.Mayis2019_C6,

                Haziran2019_C1 = employee.Vacation2019.Haziran2019_C1,
                Haziran2019_C2 = employee.Vacation2019.Haziran2019_C2,
                Haziran2019_C3 = employee.Vacation2019.Haziran2019_C3,
                Haziran2019_C4 = employee.Vacation2019.Haziran2019_C4,
                Haziran2019_C5 = employee.Vacation2019.Haziran2019_C5,
                Haziran2019_C6 = employee.Vacation2019.Haziran2019_C6,

                Temmuz2019_C1 = employee.Vacation2019.Temmuz2019_C1,
                Temmuz2019_C2 = employee.Vacation2019.Temmuz2019_C2,
                Temmuz2019_C3 = employee.Vacation2019.Temmuz2019_C3,
                Temmuz2019_C4 = employee.Vacation2019.Temmuz2019_C4,
                Temmuz2019_C5 = employee.Vacation2019.Temmuz2019_C5,
                Temmuz2019_C6 = employee.Vacation2019.Temmuz2019_C6,

                Agustos2019_C1 = employee.Vacation2019.Agustos2019_C1,
                Agustos2019_C2 = employee.Vacation2019.Agustos2019_C2,
                Agustos2019_C3 = employee.Vacation2019.Agustos2019_C3,
                Agustos2019_C4 = employee.Vacation2019.Agustos2019_C4,
                Agustos2019_C5 = employee.Vacation2019.Agustos2019_C5,
                Agustos2019_C6 = employee.Vacation2019.Agustos2019_C6,

                Eylul2019_C1 = employee.Vacation2019.Eylul2019_C1,
                Eylul2019_C2 = employee.Vacation2019.Eylul2019_C2,
                Eylul2019_C3 = employee.Vacation2019.Eylul2019_C3,
                Eylul2019_C4 = employee.Vacation2019.Eylul2019_C4,
                Eylul2019_C5 = employee.Vacation2019.Eylul2019_C5,
                Eylul2019_C6 = employee.Vacation2019.Eylul2019_C6,

                Ekim2019_C1 = employee.Vacation2019.Ekim2019_C1,
                Ekim2019_C2 = employee.Vacation2019.Ekim2019_C2,
                Ekim2019_C3 = employee.Vacation2019.Ekim2019_C3,
                Ekim2019_C4 = employee.Vacation2019.Ekim2019_C4,
                Ekim2019_C5 = employee.Vacation2019.Ekim2019_C5,
                Ekim2019_C6 = employee.Vacation2019.Ekim2019_C6,

                Kasim2019_C1 = employee.Vacation2019.Kasim2019_C1,
                Kasim2019_C2 = employee.Vacation2019.Kasim2019_C2,
                Kasim2019_C3 = employee.Vacation2019.Kasim2019_C3,
                Kasim2019_C4 = employee.Vacation2019.Kasim2019_C4,
                Kasim2019_C5 = employee.Vacation2019.Kasim2019_C5,
                Kasim2019_C6 = employee.Vacation2019.Kasim2019_C6,

                Aralik2019_C1 = employee.Vacation2019.Aralik2019_C1,
                Aralik2019_C2 = employee.Vacation2019.Aralik2019_C2,
                Aralik2019_C3 = employee.Vacation2019.Aralik2019_C3,
                Aralik2019_C4 = employee.Vacation2019.Aralik2019_C4,
                Aralik2019_C5 = employee.Vacation2019.Aralik2019_C5,
                Aralik2019_C6 = employee.Vacation2019.Aralik2019_C6,
                #endregion

                #region 2020
                Ocak2020_C1 = employee.Vacation2020.Ocak2020_C1,
                Ocak2020_C2 = employee.Vacation2020.Ocak2020_C2,
                Ocak2020_C3 = employee.Vacation2020.Ocak2020_C3,
                Ocak2020_C4 = employee.Vacation2020.Ocak2020_C4,
                Ocak2020_C5 = employee.Vacation2020.Ocak2020_C5,
                Ocak2020_C6 = employee.Vacation2020.Ocak2020_C6,

                Subat2020_C1 = employee.Vacation2020.Subat2020_C1,
                Subat2020_C2 = employee.Vacation2020.Subat2020_C2,
                Subat2020_C3 = employee.Vacation2020.Subat2020_C3,
                Subat2020_C4 = employee.Vacation2020.Subat2020_C4,
                Subat2020_C5 = employee.Vacation2020.Subat2020_C5,
                Subat2020_C6 = employee.Vacation2020.Subat2020_C6,

                Mart2020_C1 = employee.Vacation2020.Mart2020_C1,
                Mart2020_C2 = employee.Vacation2020.Mart2020_C2,
                Mart2020_C3 = employee.Vacation2020.Mart2020_C3,
                Mart2020_C4 = employee.Vacation2020.Mart2020_C4,
                Mart2020_C5 = employee.Vacation2020.Mart2020_C5,
                Mart2020_C6 = employee.Vacation2020.Mart2020_C6,

                Nisan2020_C1 = employee.Vacation2020.Nisan2020_C1,
                Nisan2020_C2 = employee.Vacation2020.Nisan2020_C2,
                Nisan2020_C3 = employee.Vacation2020.Nisan2020_C3,
                Nisan2020_C4 = employee.Vacation2020.Nisan2020_C4,
                Nisan2020_C5 = employee.Vacation2020.Nisan2020_C5,
                Nisan2020_C6 = employee.Vacation2020.Nisan2020_C6,

                Mayis2020_C1 = employee.Vacation2020.Mayis2020_C1,
                Mayis2020_C2 = employee.Vacation2020.Mayis2020_C2,
                Mayis2020_C3 = employee.Vacation2020.Mayis2020_C3,
                Mayis2020_C4 = employee.Vacation2020.Mayis2020_C4,
                Mayis2020_C5 = employee.Vacation2020.Mayis2020_C5,
                Mayis2020_C6 = employee.Vacation2020.Mayis2020_C6,

                Haziran2020_C1 = employee.Vacation2020.Haziran2020_C1,
                Haziran2020_C2 = employee.Vacation2020.Haziran2020_C2,
                Haziran2020_C3 = employee.Vacation2020.Haziran2020_C3,
                Haziran2020_C4 = employee.Vacation2020.Haziran2020_C4,
                Haziran2020_C5 = employee.Vacation2020.Haziran2020_C5,
                Haziran2020_C6 = employee.Vacation2020.Haziran2020_C6,

                Temmuz2020_C1 = employee.Vacation2020.Temmuz2020_C1,
                Temmuz2020_C2 = employee.Vacation2020.Temmuz2020_C2,
                Temmuz2020_C3 = employee.Vacation2020.Temmuz2020_C3,
                Temmuz2020_C4 = employee.Vacation2020.Temmuz2020_C4,
                Temmuz2020_C5 = employee.Vacation2020.Temmuz2020_C5,
                Temmuz2020_C6 = employee.Vacation2020.Temmuz2020_C6,

                Agustos2020_C1 = employee.Vacation2020.Agustos2020_C1,
                Agustos2020_C2 = employee.Vacation2020.Agustos2020_C2,
                Agustos2020_C3 = employee.Vacation2020.Agustos2020_C3,
                Agustos2020_C4 = employee.Vacation2020.Agustos2020_C4,
                Agustos2020_C5 = employee.Vacation2020.Agustos2020_C5,
                Agustos2020_C6 = employee.Vacation2020.Agustos2020_C6,

                Eylul2020_C1 = employee.Vacation2020.Eylul2020_C1,
                Eylul2020_C2 = employee.Vacation2020.Eylul2020_C2,
                Eylul2020_C3 = employee.Vacation2020.Eylul2020_C3,
                Eylul2020_C4 = employee.Vacation2020.Eylul2020_C4,
                Eylul2020_C5 = employee.Vacation2020.Eylul2020_C5,
                Eylul2020_C6 = employee.Vacation2020.Eylul2020_C6,

                Ekim2020_C1 = employee.Vacation2020.Ekim2020_C1,
                Ekim2020_C2 = employee.Vacation2020.Ekim2020_C2,
                Ekim2020_C3 = employee.Vacation2020.Ekim2020_C3,
                Ekim2020_C4 = employee.Vacation2020.Ekim2020_C4,
                Ekim2020_C5 = employee.Vacation2020.Ekim2020_C5,
                Ekim2020_C6 = employee.Vacation2020.Ekim2020_C6,

                Kasim2020_C1 = employee.Vacation2020.Kasim2020_C1,
                Kasim2020_C2 = employee.Vacation2020.Kasim2020_C2,
                Kasim2020_C3 = employee.Vacation2020.Kasim2020_C3,
                Kasim2020_C4 = employee.Vacation2020.Kasim2020_C4,
                Kasim2020_C5 = employee.Vacation2020.Kasim2020_C5,
                Kasim2020_C6 = employee.Vacation2020.Kasim2020_C6,

                Aralik2020_C1 = employee.Vacation2020.Aralik2020_C1,
                Aralik2020_C2 = employee.Vacation2020.Aralik2020_C2,
                Aralik2020_C3 = employee.Vacation2020.Aralik2020_C3,
                Aralik2020_C4 = employee.Vacation2020.Aralik2020_C4,
                Aralik2020_C5 = employee.Vacation2020.Aralik2020_C5,
                Aralik2020_C6 = employee.Vacation2020.Aralik2020_C6,
                #endregion

                #region 2021
                Ocak2021_C1 = employee.Vacation2021.Ocak2021_C1,
                Ocak2021_C2 = employee.Vacation2021.Ocak2021_C2,
                Ocak2021_C3 = employee.Vacation2021.Ocak2021_C3,
                Ocak2021_C4 = employee.Vacation2021.Ocak2021_C4,
                Ocak2021_C5 = employee.Vacation2021.Ocak2021_C5,
                Ocak2021_C6 = employee.Vacation2021.Ocak2021_C6,

                Subat2021_C1 = employee.Vacation2021.Subat2021_C1,
                Subat2021_C2 = employee.Vacation2021.Subat2021_C2,
                Subat2021_C3 = employee.Vacation2021.Subat2021_C3,
                Subat2021_C4 = employee.Vacation2021.Subat2021_C4,
                Subat2021_C5 = employee.Vacation2021.Subat2021_C5,
                Subat2021_C6 = employee.Vacation2021.Subat2021_C6,

                Mart2021_C1 = employee.Vacation2021.Mart2021_C1,
                Mart2021_C2 = employee.Vacation2021.Mart2021_C2,
                Mart2021_C3 = employee.Vacation2021.Mart2021_C3,
                Mart2021_C4 = employee.Vacation2021.Mart2021_C4,
                Mart2021_C5 = employee.Vacation2021.Mart2021_C5,
                Mart2021_C6 = employee.Vacation2021.Mart2021_C6,

                Nisan2021_C1 = employee.Vacation2021.Nisan2021_C1,
                Nisan2021_C2 = employee.Vacation2021.Nisan2021_C2,
                Nisan2021_C3 = employee.Vacation2021.Nisan2021_C3,
                Nisan2021_C4 = employee.Vacation2021.Nisan2021_C4,
                Nisan2021_C5 = employee.Vacation2021.Nisan2021_C5,
                Nisan2021_C6 = employee.Vacation2021.Nisan2021_C6,

                Mayis2021_C1 = employee.Vacation2021.Mayis2021_C1,
                Mayis2021_C2 = employee.Vacation2021.Mayis2021_C2,
                Mayis2021_C3 = employee.Vacation2021.Mayis2021_C3,
                Mayis2021_C4 = employee.Vacation2021.Mayis2021_C4,
                Mayis2021_C5 = employee.Vacation2021.Mayis2021_C5,
                Mayis2021_C6 = employee.Vacation2021.Mayis2021_C6,

                Haziran2021_C1 = employee.Vacation2021.Haziran2021_C1,
                Haziran2021_C2 = employee.Vacation2021.Haziran2021_C2,
                Haziran2021_C3 = employee.Vacation2021.Haziran2021_C3,
                Haziran2021_C4 = employee.Vacation2021.Haziran2021_C4,
                Haziran2021_C5 = employee.Vacation2021.Haziran2021_C5,
                Haziran2021_C6 = employee.Vacation2021.Haziran2021_C6,

                Temmuz2021_C1 = employee.Vacation2021.Temmuz2021_C1,
                Temmuz2021_C2 = employee.Vacation2021.Temmuz2021_C2,
                Temmuz2021_C3 = employee.Vacation2021.Temmuz2021_C3,
                Temmuz2021_C4 = employee.Vacation2021.Temmuz2021_C4,
                Temmuz2021_C5 = employee.Vacation2021.Temmuz2021_C5,
                Temmuz2021_C6 = employee.Vacation2021.Temmuz2021_C6,

                Agustos2021_C1 = employee.Vacation2021.Agustos2021_C1,
                Agustos2021_C2 = employee.Vacation2021.Agustos2021_C2,
                Agustos2021_C3 = employee.Vacation2021.Agustos2021_C3,
                Agustos2021_C4 = employee.Vacation2021.Agustos2021_C4,
                Agustos2021_C5 = employee.Vacation2021.Agustos2021_C5,
                Agustos2021_C6 = employee.Vacation2021.Agustos2021_C6,

                Eylul2021_C1 = employee.Vacation2021.Eylul2021_C1,
                Eylul2021_C2 = employee.Vacation2021.Eylul2021_C2,
                Eylul2021_C3 = employee.Vacation2021.Eylul2021_C3,
                Eylul2021_C4 = employee.Vacation2021.Eylul2021_C4,
                Eylul2021_C5 = employee.Vacation2021.Eylul2021_C5,
                Eylul2021_C6 = employee.Vacation2021.Eylul2021_C6,

                Ekim2021_C1 = employee.Vacation2021.Ekim2021_C1,
                Ekim2021_C2 = employee.Vacation2021.Ekim2021_C2,
                Ekim2021_C3 = employee.Vacation2021.Ekim2021_C3,
                Ekim2021_C4 = employee.Vacation2021.Ekim2021_C4,
                Ekim2021_C5 = employee.Vacation2021.Ekim2021_C5,
                Ekim2021_C6 = employee.Vacation2021.Ekim2021_C6,

                Kasim2021_C1 = employee.Vacation2021.Kasim2021_C1,
                Kasim2021_C2 = employee.Vacation2021.Kasim2021_C2,
                Kasim2021_C3 = employee.Vacation2021.Kasim2021_C3,
                Kasim2021_C4 = employee.Vacation2021.Kasim2021_C4,
                Kasim2021_C5 = employee.Vacation2021.Kasim2021_C5,
                Kasim2021_C6 = employee.Vacation2021.Kasim2021_C6,

                Aralik2021_C1 = employee.Vacation2021.Aralik2021_C1,
                Aralik2021_C2 = employee.Vacation2021.Aralik2021_C2,
                Aralik2021_C3 = employee.Vacation2021.Aralik2021_C3,
                Aralik2021_C4 = employee.Vacation2021.Aralik2021_C4,
                Aralik2021_C5 = employee.Vacation2021.Aralik2021_C5,
                Aralik2021_C6 = employee.Vacation2021.Aralik2021_C6,
                #endregion

                #region 2022
                Ocak2022_C1 = employee.Vacation2022.Ocak2022_C1,
                Ocak2022_C2 = employee.Vacation2022.Ocak2022_C2,
                Ocak2022_C3 = employee.Vacation2022.Ocak2022_C3,
                Ocak2022_C4 = employee.Vacation2022.Ocak2022_C4,
                Ocak2022_C5 = employee.Vacation2022.Ocak2022_C5,
                Ocak2022_C6 = employee.Vacation2022.Ocak2022_C6,

                Subat2022_C1 = employee.Vacation2022.Subat2022_C1,
                Subat2022_C2 = employee.Vacation2022.Subat2022_C2,
                Subat2022_C3 = employee.Vacation2022.Subat2022_C3,
                Subat2022_C4 = employee.Vacation2022.Subat2022_C4,
                Subat2022_C5 = employee.Vacation2022.Subat2022_C5,
                Subat2022_C6 = employee.Vacation2022.Subat2022_C6,

                Mart2022_C1 = employee.Vacation2022.Mart2022_C1,
                Mart2022_C2 = employee.Vacation2022.Mart2022_C2,
                Mart2022_C3 = employee.Vacation2022.Mart2022_C3,
                Mart2022_C4 = employee.Vacation2022.Mart2022_C4,
                Mart2022_C5 = employee.Vacation2022.Mart2022_C5,
                Mart2022_C6 = employee.Vacation2022.Mart2022_C6,

                Nisan2022_C1 = employee.Vacation2022.Nisan2022_C1,
                Nisan2022_C2 = employee.Vacation2022.Nisan2022_C2,
                Nisan2022_C3 = employee.Vacation2022.Nisan2022_C3,
                Nisan2022_C4 = employee.Vacation2022.Nisan2022_C4,
                Nisan2022_C5 = employee.Vacation2022.Nisan2022_C5,
                Nisan2022_C6 = employee.Vacation2022.Nisan2022_C6,

                Mayis2022_C1 = employee.Vacation2022.Mayis2022_C1,
                Mayis2022_C2 = employee.Vacation2022.Mayis2022_C2,
                Mayis2022_C3 = employee.Vacation2022.Mayis2022_C3,
                Mayis2022_C4 = employee.Vacation2022.Mayis2022_C4,
                Mayis2022_C5 = employee.Vacation2022.Mayis2022_C5,
                Mayis2022_C6 = employee.Vacation2022.Mayis2022_C6,

                Haziran2022_C1 = employee.Vacation2022.Haziran2022_C1,
                Haziran2022_C2 = employee.Vacation2022.Haziran2022_C2,
                Haziran2022_C3 = employee.Vacation2022.Haziran2022_C3,
                Haziran2022_C4 = employee.Vacation2022.Haziran2022_C4,
                Haziran2022_C5 = employee.Vacation2022.Haziran2022_C5,
                Haziran2022_C6 = employee.Vacation2022.Haziran2022_C6,

                Temmuz2022_C1 = employee.Vacation2022.Temmuz2022_C1,
                Temmuz2022_C2 = employee.Vacation2022.Temmuz2022_C2,
                Temmuz2022_C3 = employee.Vacation2022.Temmuz2022_C3,
                Temmuz2022_C4 = employee.Vacation2022.Temmuz2022_C4,
                Temmuz2022_C5 = employee.Vacation2022.Temmuz2022_C5,
                Temmuz2022_C6 = employee.Vacation2022.Temmuz2022_C6,

                Agustos2022_C1 = employee.Vacation2022.Agustos2022_C1,
                Agustos2022_C2 = employee.Vacation2022.Agustos2022_C2,
                Agustos2022_C3 = employee.Vacation2022.Agustos2022_C3,
                Agustos2022_C4 = employee.Vacation2022.Agustos2022_C4,
                Agustos2022_C5 = employee.Vacation2022.Agustos2022_C5,
                Agustos2022_C6 = employee.Vacation2022.Agustos2022_C6,

                Eylul2022_C1 = employee.Vacation2022.Eylul2022_C1,
                Eylul2022_C2 = employee.Vacation2022.Eylul2022_C2,
                Eylul2022_C3 = employee.Vacation2022.Eylul2022_C3,
                Eylul2022_C4 = employee.Vacation2022.Eylul2022_C4,
                Eylul2022_C5 = employee.Vacation2022.Eylul2022_C5,
                Eylul2022_C6 = employee.Vacation2022.Eylul2022_C6,

                Ekim2022_C1 = employee.Vacation2022.Ekim2022_C1,
                Ekim2022_C2 = employee.Vacation2022.Ekim2022_C2,
                Ekim2022_C3 = employee.Vacation2022.Ekim2022_C3,
                Ekim2022_C4 = employee.Vacation2022.Ekim2022_C4,
                Ekim2022_C5 = employee.Vacation2022.Ekim2022_C5,
                Ekim2022_C6 = employee.Vacation2022.Ekim2022_C6,

                Kasim2022_C1 = employee.Vacation2022.Kasim2022_C1,
                Kasim2022_C2 = employee.Vacation2022.Kasim2022_C2,
                Kasim2022_C3 = employee.Vacation2022.Kasim2022_C3,
                Kasim2022_C4 = employee.Vacation2022.Kasim2022_C4,
                Kasim2022_C5 = employee.Vacation2022.Kasim2022_C5,
                Kasim2022_C6 = employee.Vacation2022.Kasim2022_C6,

                Aralik2022_C1 = employee.Vacation2022.Aralik2022_C1,
                Aralik2022_C2 = employee.Vacation2022.Aralik2022_C2,
                Aralik2022_C3 = employee.Vacation2022.Aralik2022_C3,
                Aralik2022_C4 = employee.Vacation2022.Aralik2022_C4,
                Aralik2022_C5 = employee.Vacation2022.Aralik2022_C5,
                Aralik2022_C6 = employee.Vacation2022.Aralik2022_C6,
                #endregion

                #region 2023
                Ocak2023_C1 = employee.Vacation2023.Ocak2023_C1,
                Ocak2023_C2 = employee.Vacation2023.Ocak2023_C2,
                Ocak2023_C3 = employee.Vacation2023.Ocak2023_C3,
                Ocak2023_C4 = employee.Vacation2023.Ocak2023_C4,
                Ocak2023_C5 = employee.Vacation2023.Ocak2023_C5,
                Ocak2023_C6 = employee.Vacation2023.Ocak2023_C6,

                Subat2023_C1 = employee.Vacation2023.Subat2023_C1,
                Subat2023_C2 = employee.Vacation2023.Subat2023_C2,
                Subat2023_C3 = employee.Vacation2023.Subat2023_C3,
                Subat2023_C4 = employee.Vacation2023.Subat2023_C4,
                Subat2023_C5 = employee.Vacation2023.Subat2023_C5,
                Subat2023_C6 = employee.Vacation2023.Subat2023_C6,

                Mart2023_C1 = employee.Vacation2023.Mart2023_C1,
                Mart2023_C2 = employee.Vacation2023.Mart2023_C2,
                Mart2023_C3 = employee.Vacation2023.Mart2023_C3,
                Mart2023_C4 = employee.Vacation2023.Mart2023_C4,
                Mart2023_C5 = employee.Vacation2023.Mart2023_C5,
                Mart2023_C6 = employee.Vacation2023.Mart2023_C6,

                Nisan2023_C1 = employee.Vacation2023.Nisan2023_C1,
                Nisan2023_C2 = employee.Vacation2023.Nisan2023_C2,
                Nisan2023_C3 = employee.Vacation2023.Nisan2023_C3,
                Nisan2023_C4 = employee.Vacation2023.Nisan2023_C4,
                Nisan2023_C5 = employee.Vacation2023.Nisan2023_C5,
                Nisan2023_C6 = employee.Vacation2023.Nisan2023_C6,

                Mayis2023_C1 = employee.Vacation2023.Mayis2023_C1,
                Mayis2023_C2 = employee.Vacation2023.Mayis2023_C2,
                Mayis2023_C3 = employee.Vacation2023.Mayis2023_C3,
                Mayis2023_C4 = employee.Vacation2023.Mayis2023_C4,
                Mayis2023_C5 = employee.Vacation2023.Mayis2023_C5,
                Mayis2023_C6 = employee.Vacation2023.Mayis2023_C6,

                Haziran2023_C1 = employee.Vacation2023.Haziran2023_C1,
                Haziran2023_C2 = employee.Vacation2023.Haziran2023_C2,
                Haziran2023_C3 = employee.Vacation2023.Haziran2023_C3,
                Haziran2023_C4 = employee.Vacation2023.Haziran2023_C4,
                Haziran2023_C5 = employee.Vacation2023.Haziran2023_C5,
                Haziran2023_C6 = employee.Vacation2023.Haziran2023_C6,

                Temmuz2023_C1 = employee.Vacation2023.Temmuz2023_C1,
                Temmuz2023_C2 = employee.Vacation2023.Temmuz2023_C2,
                Temmuz2023_C3 = employee.Vacation2023.Temmuz2023_C3,
                Temmuz2023_C4 = employee.Vacation2023.Temmuz2023_C4,
                Temmuz2023_C5 = employee.Vacation2023.Temmuz2023_C5,
                Temmuz2023_C6 = employee.Vacation2023.Temmuz2023_C6,

                Agustos2023_C1 = employee.Vacation2023.Agustos2023_C1,
                Agustos2023_C2 = employee.Vacation2023.Agustos2023_C2,
                Agustos2023_C3 = employee.Vacation2023.Agustos2023_C3,
                Agustos2023_C4 = employee.Vacation2023.Agustos2023_C4,
                Agustos2023_C5 = employee.Vacation2023.Agustos2023_C5,
                Agustos2023_C6 = employee.Vacation2023.Agustos2023_C6,

                Eylul2023_C1 = employee.Vacation2023.Eylul2023_C1,
                Eylul2023_C2 = employee.Vacation2023.Eylul2023_C2,
                Eylul2023_C3 = employee.Vacation2023.Eylul2023_C3,
                Eylul2023_C4 = employee.Vacation2023.Eylul2023_C4,
                Eylul2023_C5 = employee.Vacation2023.Eylul2023_C5,
                Eylul2023_C6 = employee.Vacation2023.Eylul2023_C6,

                Ekim2023_C1 = employee.Vacation2023.Ekim2023_C1,
                Ekim2023_C2 = employee.Vacation2023.Ekim2023_C2,
                Ekim2023_C3 = employee.Vacation2023.Ekim2023_C3,
                Ekim2023_C4 = employee.Vacation2023.Ekim2023_C4,
                Ekim2023_C5 = employee.Vacation2023.Ekim2023_C5,
                Ekim2023_C6 = employee.Vacation2023.Ekim2023_C6,

                Kasim2023_C1 = employee.Vacation2023.Kasim2023_C1,
                Kasim2023_C2 = employee.Vacation2023.Kasim2023_C2,
                Kasim2023_C3 = employee.Vacation2023.Kasim2023_C3,
                Kasim2023_C4 = employee.Vacation2023.Kasim2023_C4,
                Kasim2023_C5 = employee.Vacation2023.Kasim2023_C5,
                Kasim2023_C6 = employee.Vacation2023.Kasim2023_C6,

                Aralik2023_C1 = employee.Vacation2023.Aralik2023_C1,
                Aralik2023_C2 = employee.Vacation2023.Aralik2023_C2,
                Aralik2023_C3 = employee.Vacation2023.Aralik2023_C3,
                Aralik2023_C4 = employee.Vacation2023.Aralik2023_C4,
                Aralik2023_C5 = employee.Vacation2023.Aralik2023_C5,
                Aralik2023_C6 = employee.Vacation2023.Aralik2023_C6,
                #endregion
            };
        }
    }
}
