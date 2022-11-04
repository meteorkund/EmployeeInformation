using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Converters;
using EmployeeInformation.WPF.Stores;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Win32;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeDetailsFormViewModel : ViewModelBase
    {

        #region KİŞİSEL BİLGİLER

        private string _isim;
        public string Isim
        {
            get { return _isim; }
            set
            {
                _isim = value;
                OnPropertyChanged(nameof(Isim));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private string _soyisim;

        public string Soyisim
        {
            get { return _soyisim; }
            set
            {
                _soyisim = value;
                OnPropertyChanged(nameof(Soyisim));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        private int _dosyaNo;

        public int DosyaNo
        {
            get { return _dosyaNo; }
            set
            {
                _dosyaNo = value;
                OnPropertyChanged(nameof(DosyaNo));
            }
        }


        private string _tcKimlik;

        public string TCKimlik
        {
            get { return _tcKimlik; }
            set
            {
                _tcKimlik = value;
                OnPropertyChanged(nameof(TCKimlik));
            }
        }


        private string _dogumTarihi;

        public string DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                _dogumTarihi = value;
                OnPropertyChanged(nameof(DogumTarihi));
            }
        }


        private string _gorev;

        public string Gorev
        {
            get { return _gorev; }
            set
            {
                _gorev = value;
                OnPropertyChanged(nameof(Gorev));
            }
        }

        private string _medeniDurum;

        public string MedeniDurum
        {
            get { return _medeniDurum; }
            set
            {
                _medeniDurum = value;
                OnPropertyChanged(nameof(MedeniDurum));
            }
        }

        private string _maas;

        public string Maas
        {
            get { return _maas; }
            set
            {
                _maas = value;
                OnPropertyChanged(nameof(Maas));
            }
        }

        private string _egitimDurumu;

        public string EgitimDurumu
        {
            get { return _egitimDurumu; }
            set
            {
                _egitimDurumu = value;
                OnPropertyChanged(nameof(EgitimDurumu));
            }
        }

        private string _cepTel;

        public string CepTel
        {
            get { return _cepTel; }
            set
            {
                _cepTel = value;
                OnPropertyChanged(nameof(CepTel));
            }
        }

        private string _askerlik;

        public string Askerlik
        {
            get { return _askerlik; }
            set
            {
                _askerlik = value;
                OnPropertyChanged(nameof(Askerlik));
            }
        }

        private string _baslamaTarihi;

        public string BaslamaTarihi
        {
            get { return _baslamaTarihi; }
            set
            {
                _baslamaTarihi = value;
                OnPropertyChanged(nameof(BaslamaTarihi));
            }
        }

        private string _calismaSuresi;

        public string CalismaSuresi
        {
            get { return _calismaSuresi; }
            set
            {
                _calismaSuresi = value;
                OnPropertyChanged(nameof(CalismaSuresi));
            }
        }


        private string _iseGiris;

        public string IseGiris
        {
            get { return _iseGiris; }
            set
            {
                _iseGiris = value;
                OnPropertyChanged(nameof(IseGiris));
            }
        }

        private string _istenCikis;

        public string IstenCikis
        {
            get { return _istenCikis; }
            set
            {
                _istenCikis = value;
                OnPropertyChanged(nameof(IstenCikis));
            }
        }


        private bool _durum = true;

        public bool Durum
        {
            get { return _durum; }
            set
            {
                _durum = value;
                OnPropertyChanged(nameof(Durum));
            }
        }

        private string _evAdresi;

        public string EvAdresi
        {
            get { return _evAdresi; }
            set
            {
                _evAdresi = value;
                OnPropertyChanged(nameof(EvAdresi));
            }
        }

        private string _ekBilgi;


        public string EkBilgi
        {
            get { return _ekBilgi; }
            set
            {
                _ekBilgi = value;
                OnPropertyChanged(nameof(EkBilgi));
            }
        }

        private string _photoSource = "/Assets/MemetAvatar.jpg";
        public string PhotoSource
        {
            get { return _photoSource; }
            set
            {
                _photoSource = value;
                OnPropertyChanged(nameof(PhotoSource));
            }
        }

        private bool _isSubmitting;

        public bool IsSubmitting
        {
            get { return _isSubmitting; }
            set
            {
                _isSubmitting = value;
                OnPropertyChanged(nameof(IsSubmitting));
            }
        }


        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }

        private string _saveStatus;

        public string SaveStatus
        {
            get { return _saveStatus; }
            set
            {
                _saveStatus = value;
                OnPropertyChanged(nameof(SaveStatus));
            }
        }


        private bool _isSaved;

        public bool IsSaved
        {
            get { return _isSaved; }
            set
            {
                _isSaved = value;
                OnPropertyChanged(nameof(IsSaved));
            }
        }

        private bool _isAdding;

        public bool IsAdding
        {
            get { return _isAdding; }
            set
            {
                _isAdding = value;
                OnPropertyChanged(nameof(IsAdding));
            }
        }




        #endregion

        #region IZIN 2018


        private int _ocak2018_C1;
        public int Ocak2018_C1
        {
            get { return _ocak2018_C1; }
            set
            {
                _ocak2018_C1 = value;
                OnPropertyChanged(nameof(Ocak2018_C1));
            }
        }

        private int _ocak2018_C2;
        public int Ocak2018_C2
        {
            get { return _ocak2018_C2; }
            set
            {
                _ocak2018_C2 = value;
                OnPropertyChanged(nameof(Ocak2018_C2));
            }
        }

        private int _ocak2018_C3;
        public int Ocak2018_C3
        {
            get { return _ocak2018_C3; }
            set
            {
                _ocak2018_C3 = value;
                OnPropertyChanged(nameof(Ocak2018_C3));
            }
        }

        private int _ocak2018_C4;
        public int Ocak2018_C4
        {
            get { return _ocak2018_C4; }
            set
            {
                _ocak2018_C4 = value;
                OnPropertyChanged(nameof(Ocak2018_C4));
            }
        }

        private int _ocak2018_C5;
        public int Ocak2018_C5
        {
            get { return _ocak2018_C5; }
            set
            {
                _ocak2018_C5 = value;
                OnPropertyChanged(nameof(Ocak2018_C5));
            }
        }

        private int _ocak2018_C6;
        public int Ocak2018_C6
        {
            get { return _ocak2018_C6; }
            set
            {
                _ocak2018_C6 = value;
                OnPropertyChanged(nameof(Ocak2018_C6));
            }
        }

        private int _subat2018_C1;
        public int Subat2018_C1
        {
            get { return _subat2018_C1; }
            set
            {
                _subat2018_C1 = value;
                OnPropertyChanged(nameof(Subat2018_C1));
            }
        }

        private int _subat2018_C2;
        public int Subat2018_C2
        {
            get { return _subat2018_C2; }
            set
            {
                _subat2018_C2 = value;
                OnPropertyChanged(nameof(Subat2018_C2));
            }
        }

        private int _subat2018_C3;
        public int Subat2018_C3
        {
            get { return _subat2018_C3; }
            set
            {
                _subat2018_C3 = value;
                OnPropertyChanged(nameof(Subat2018_C3));
            }
        }

        private int _subat2018_C4;
        public int Subat2018_C4
        {
            get { return _subat2018_C4; }
            set
            {
                _subat2018_C4 = value;
                OnPropertyChanged(nameof(Subat2018_C4));
            }
        }

        private int _subat2018_C5;
        public int Subat2018_C5
        {
            get { return _subat2018_C5; }
            set
            {
                _subat2018_C5 = value;
                OnPropertyChanged(nameof(Subat2018_C5));
            }
        }

        private int _subat2018_C6;
        public int Subat2018_C6
        {
            get { return _subat2018_C6; }
            set
            {
                _subat2018_C6 = value;
                OnPropertyChanged(nameof(Subat2018_C6));
            }
        }

        private int _mart2018_C1;
        public int Mart2018_C1
        {
            get { return _mart2018_C1; }
            set
            {
                _mart2018_C1 = value;
                OnPropertyChanged(nameof(Mart2018_C1));
            }
        }

        private int _mart2018_C2;
        public int Mart2018_C2
        {
            get { return _mart2018_C2; }
            set
            {
                _mart2018_C2 = value;
                OnPropertyChanged(nameof(Mart2018_C2));
            }
        }

        private int _mart2018_C3;
        public int Mart2018_C3
        {
            get { return _mart2018_C3; }
            set
            {
                _mart2018_C3 = value;
                OnPropertyChanged(nameof(Mart2018_C3));
            }
        }

        private int _mart2018_C4;
        public int Mart2018_C4
        {
            get { return _mart2018_C4; }
            set
            {
                _mart2018_C4 = value;
                OnPropertyChanged(nameof(Mart2018_C4));
            }
        }

        private int _mart2018_C5;
        public int Mart2018_C5
        {
            get { return _mart2018_C5; }
            set
            {
                _mart2018_C5 = value;
                OnPropertyChanged(nameof(Mart2018_C5));
            }
        }

        private int _mart2018_C6;
        public int Mart2018_C6
        {
            get { return _mart2018_C6; }
            set
            {
                _mart2018_C6 = value;
                OnPropertyChanged(nameof(Mart2018_C6));
            }
        }
        private int _nisan2018_C1;
        public int Nisan2018_C1
        {
            get { return _nisan2018_C1; }
            set
            {
                _nisan2018_C1 = value;
                OnPropertyChanged(nameof(Nisan2018_C1));
            }
        }

        private int _nisan2018_C2;
        public int Nisan2018_C2
        {
            get { return _nisan2018_C2; }
            set
            {
                _nisan2018_C2 = value;
                OnPropertyChanged(nameof(Nisan2018_C2));
            }
        }

        private int _nisan2018_C3;
        public int Nisan2018_C3
        {
            get { return _nisan2018_C3; }
            set
            {
                _nisan2018_C3 = value;
                OnPropertyChanged(nameof(Nisan2018_C3));
            }
        }

        private int _nisan2018_C4;
        public int Nisan2018_C4
        {
            get { return _nisan2018_C4; }
            set
            {
                _nisan2018_C4 = value;
                OnPropertyChanged(nameof(Nisan2018_C4));
            }
        }

        private int _nisan2018_C5;
        public int Nisan2018_C5
        {
            get { return _nisan2018_C5; }
            set
            {
                _nisan2018_C5 = value;
                OnPropertyChanged(nameof(Nisan2018_C5));
            }
        }

        private int _nisan2018_C6;
        public int Nisan2018_C6
        {
            get { return _nisan2018_C6; }
            set
            {
                _nisan2018_C6 = value;
                OnPropertyChanged(nameof(Nisan2018_C6));
            }
        }

        private int _mayis2018_C1;
        public int Mayis2018_C1
        {
            get { return _mayis2018_C1; }
            set
            {
                _mayis2018_C1 = value;
                OnPropertyChanged(nameof(Mayis2018_C1));
            }
        }

        private int _mayis2018_C2;
        public int Mayis2018_C2
        {
            get { return _mayis2018_C2; }
            set
            {
                _mayis2018_C2 = value;
                OnPropertyChanged(nameof(Mayis2018_C2));
            }
        }

        private int _mayis2018_C3;
        public int Mayis2018_C3
        {
            get { return _mayis2018_C3; }
            set
            {
                _mayis2018_C3 = value;
                OnPropertyChanged(nameof(Mayis2018_C3));
            }
        }

        private int _mayis2018_C4;
        public int Mayis2018_C4
        {
            get { return _mayis2018_C4; }
            set
            {
                _mayis2018_C4 = value;
                OnPropertyChanged(nameof(Mayis2018_C4));
            }
        }

        private int _mayis2018_C5;
        public int Mayis2018_C5
        {
            get { return _mayis2018_C5; }
            set
            {
                _mayis2018_C5 = value;
                OnPropertyChanged(nameof(Mayis2018_C5));
            }
        }

        private int _mayis2018_C6;
        public int Mayis2018_C6
        {
            get { return _mayis2018_C6; }
            set
            {
                _mayis2018_C6 = value;
                OnPropertyChanged(nameof(Mayis2018_C6));
            }
        }

        private int _haziran2018_C1;
        public int Haziran2018_C1
        {
            get { return _haziran2018_C1; }
            set
            {
                _haziran2018_C1 = value;
                OnPropertyChanged(nameof(Haziran2018_C1));
            }
        }

        private int _haziran2018_C2;
        public int Haziran2018_C2
        {
            get { return _haziran2018_C2; }
            set
            {
                _haziran2018_C2 = value;
                OnPropertyChanged(nameof(Haziran2018_C2));
            }
        }

        private int _haziran2018_C3;
        public int Haziran2018_C3
        {
            get { return _haziran2018_C3; }
            set
            {
                _haziran2018_C3 = value;
                OnPropertyChanged(nameof(Haziran2018_C3));
            }
        }

        private int _haziran2018_C4;
        public int Haziran2018_C4
        {
            get { return _haziran2018_C4; }
            set
            {
                _haziran2018_C4 = value;
                OnPropertyChanged(nameof(Haziran2018_C4));
            }
        }

        private int _haziran2018_C5;
        public int Haziran2018_C5
        {
            get { return _haziran2018_C5; }
            set
            {
                _haziran2018_C5 = value;
                OnPropertyChanged(nameof(Haziran2018_C5));
            }
        }

        private int _haziran2018_C6;
        public int Haziran2018_C6
        {
            get { return _haziran2018_C6; }
            set
            {
                _haziran2018_C6 = value;
                OnPropertyChanged(nameof(Haziran2018_C6));
            }
        }

        private int _temmuz2018_C1;
        public int Temmuz2018_C1
        {
            get { return _temmuz2018_C1; }
            set
            {
                _temmuz2018_C1 = value;
                OnPropertyChanged(nameof(Temmuz2018_C1));
            }
        }

        private int _temmuz2018_C2;
        public int Temmuz2018_C2
        {
            get { return _temmuz2018_C2; }
            set
            {
                _temmuz2018_C2 = value;
                OnPropertyChanged(nameof(Temmuz2018_C2));
            }
        }

        private int _temmuz2018_C3;
        public int Temmuz2018_C3
        {
            get { return _temmuz2018_C3; }
            set
            {
                _temmuz2018_C3 = value;
                OnPropertyChanged(nameof(Temmuz2018_C3));
            }
        }

        private int _temmuz2018_C4;
        public int Temmuz2018_C4
        {
            get { return _temmuz2018_C4; }
            set
            {
                _temmuz2018_C4 = value;
                OnPropertyChanged(nameof(Temmuz2018_C4));
            }
        }

        private int _temmuz2018_C5;
        public int Temmuz2018_C5
        {
            get { return _temmuz2018_C5; }
            set
            {
                _temmuz2018_C5 = value;
                OnPropertyChanged(nameof(Temmuz2018_C5));
            }
        }

        private int _temmuz2018_C6;
        public int Temmuz2018_C6
        {
            get { return _temmuz2018_C6; }
            set
            {
                _temmuz2018_C6 = value;
                OnPropertyChanged(nameof(Temmuz2018_C6));
            }
        }

        private int _agustos2018_C1;
        public int Agustos2018_C1
        {
            get { return _agustos2018_C1; }
            set
            {
                _agustos2018_C1 = value;
                OnPropertyChanged(nameof(Agustos2018_C1));
            }
        }

        private int _agustos2018_C2;
        public int Agustos2018_C2
        {
            get { return _agustos2018_C2; }
            set
            {
                _agustos2018_C2 = value;
                OnPropertyChanged(nameof(Agustos2018_C2));
            }
        }

        private int _agustos2018_C3;
        public int Agustos2018_C3
        {
            get { return _agustos2018_C3; }
            set
            {
                _agustos2018_C3 = value;
                OnPropertyChanged(nameof(Agustos2018_C3));
            }
        }

        private int _agustos2018_C4;
        public int Agustos2018_C4
        {
            get { return _agustos2018_C4; }
            set
            {
                _agustos2018_C4 = value;
                OnPropertyChanged(nameof(Agustos2018_C4));
            }
        }

        private int _agustos2018_C5;
        public int Agustos2018_C5
        {
            get { return _agustos2018_C5; }
            set
            {
                _agustos2018_C5 = value;
                OnPropertyChanged(nameof(Agustos2018_C5));
            }
        }

        private int _agustos2018_C6;
        public int Agustos2018_C6
        {
            get { return _agustos2018_C6; }
            set
            {
                _agustos2018_C6 = value;
                OnPropertyChanged(nameof(Agustos2018_C6));
            }
        }

        private int _eylul2018_C1;
        public int Eylul2018_C1
        {
            get { return _eylul2018_C1; }
            set
            {
                _eylul2018_C1 = value;
                OnPropertyChanged(nameof(Eylul2018_C1));
            }
        }

        private int _eylul2018_C2;
        public int Eylul2018_C2
        {
            get { return _eylul2018_C2; }
            set
            {
                _eylul2018_C2 = value;
                OnPropertyChanged(nameof(Eylul2018_C2));
            }
        }

        private int _eylul2018_C3;
        public int Eylul2018_C3
        {
            get { return _eylul2018_C3; }
            set
            {
                _eylul2018_C3 = value;
                OnPropertyChanged(nameof(Eylul2018_C3));
            }
        }

        private int _eylul2018_C4;
        public int Eylul2018_C4
        {
            get { return _eylul2018_C4; }
            set
            {
                _eylul2018_C4 = value;
                OnPropertyChanged(nameof(Eylul2018_C4));
            }
        }

        private int _eylul2018_C5;
        public int Eylul2018_C5
        {
            get { return _eylul2018_C5; }
            set
            {
                _eylul2018_C5 = value;
                OnPropertyChanged(nameof(Eylul2018_C5));
            }
        }

        private int _eylul2018_C6;
        public int Eylul2018_C6
        {
            get { return _eylul2018_C6; }
            set
            {
                _eylul2018_C6 = value;
                OnPropertyChanged(nameof(Eylul2018_C6));
            }
        }

        private int _ekim2018_C1;
        public int Ekim2018_C1
        {
            get { return _ekim2018_C1; }
            set
            {
                _ekim2018_C1 = value;
                OnPropertyChanged(nameof(Ekim2018_C1));
            }
        }

        private int _ekim2018_C2;
        public int Ekim2018_C2
        {
            get { return _ekim2018_C2; }
            set
            {
                _ekim2018_C2 = value;
                OnPropertyChanged(nameof(Ekim2018_C2));
            }
        }

        private int _ekim2018_C3;
        public int Ekim2018_C3
        {
            get { return _ekim2018_C3; }
            set
            {
                _ekim2018_C3 = value;
                OnPropertyChanged(nameof(Ekim2018_C3));
            }
        }

        private int _ekim2018_C4;
        public int Ekim2018_C4
        {
            get { return _ekim2018_C4; }
            set
            {
                _ekim2018_C4 = value;
                OnPropertyChanged(nameof(Ekim2018_C4));
            }
        }

        private int _ekim2018_C5;
        public int Ekim2018_C5
        {
            get { return _ekim2018_C5; }
            set
            {
                _ekim2018_C5 = value;
                OnPropertyChanged(nameof(Ekim2018_C5));
            }
        }

        private int _ekim2018_C6;
        public int Ekim2018_C6
        {
            get { return _ekim2018_C6; }
            set
            {
                _ekim2018_C6 = value;
                OnPropertyChanged(nameof(Ekim2018_C6));
            }
        }

        private int _kasim2018_C1;
        public int Kasim2018_C1
        {
            get { return _kasim2018_C1; }
            set
            {
                _kasim2018_C1 = value;
                OnPropertyChanged(nameof(Kasim2018_C1));
            }
        }

        private int _kasim2018_C2;
        public int Kasim2018_C2
        {
            get { return _kasim2018_C2; }
            set
            {
                _kasim2018_C2 = value;
                OnPropertyChanged(nameof(Kasim2018_C2));
            }
        }

        private int _kasim2018_C3;
        public int Kasim2018_C3
        {
            get { return _kasim2018_C3; }
            set
            {
                _kasim2018_C3 = value;
                OnPropertyChanged(nameof(Kasim2018_C3));
            }
        }

        private int _kasim2018_C4;
        public int Kasim2018_C4
        {
            get { return _kasim2018_C4; }
            set
            {
                _kasim2018_C4 = value;
                OnPropertyChanged(nameof(Kasim2018_C4));
            }
        }

        private int _kasim2018_C5;
        public int Kasim2018_C5
        {
            get { return _kasim2018_C5; }
            set
            {
                _kasim2018_C5 = value;
                OnPropertyChanged(nameof(Kasim2018_C5));
            }
        }

        private int _kasim2018_C6;
        public int Kasim2018_C6
        {
            get { return _kasim2018_C6; }
            set
            {
                _kasim2018_C6 = value;
                OnPropertyChanged(nameof(Kasim2018_C6));
            }
        }
        private int _aralik2018_C1;
        public int Aralik2018_C1
        {
            get { return _aralik2018_C1; }
            set
            {
                _aralik2018_C1 = value;
                OnPropertyChanged(nameof(Aralik2018_C1));
            }
        }

        private int _aralik2018_C2;
        public int Aralik2018_C2
        {
            get { return _aralik2018_C2; }
            set
            {
                _aralik2018_C2 = value;
                OnPropertyChanged(nameof(Aralik2018_C2));
            }
        }

        private int _aralik2018_C3;
        public int Aralik2018_C3
        {
            get { return _aralik2018_C3; }
            set
            {
                _aralik2018_C3 = value;
                OnPropertyChanged(nameof(Aralik2018_C3));
            }
        }

        private int _aralik2018_C4;
        public int Aralik2018_C4
        {
            get { return _aralik2018_C4; }
            set
            {
                _aralik2018_C4 = value;
                OnPropertyChanged(nameof(Aralik2018_C4));
            }
        }

        private int _aralik2018_C5;
        public int Aralik2018_C5
        {
            get { return _aralik2018_C5; }
            set
            {
                _aralik2018_C5 = value;
                OnPropertyChanged(nameof(Aralik2018_C5));
            }
        }

        private int _aralik2018_C6;
        public int Aralik2018_C6
        {
            get { return _aralik2018_C6; }
            set
            {
                _aralik2018_C6 = value;
                OnPropertyChanged(nameof(Aralik2018_C6));
            }
        }

        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }


        #endregion

        #region IZIN 2019


        private int _ocak2019_C1;
        public int Ocak2019_C1
        {
            get { return _ocak2019_C1; }
            set
            {
                _ocak2019_C1 = value;
                OnPropertyChanged(nameof(Ocak2019_C1));
            }
        }

        private int _ocak2019_C2;
        public int Ocak2019_C2
        {
            get { return _ocak2019_C2; }
            set
            {
                _ocak2019_C2 = value;
                OnPropertyChanged(nameof(Ocak2019_C2));
            }
        }

        private int _ocak2019_C3;
        public int Ocak2019_C3
        {
            get { return _ocak2019_C3; }
            set
            {
                _ocak2019_C3 = value;
                OnPropertyChanged(nameof(Ocak2019_C3));
            }
        }

        private int _ocak2019_C4;
        public int Ocak2019_C4
        {
            get { return _ocak2019_C4; }
            set
            {
                _ocak2019_C4 = value;
                OnPropertyChanged(nameof(Ocak2019_C4));
            }
        }

        private int _ocak2019_C5;
        public int Ocak2019_C5
        {
            get { return _ocak2019_C5; }
            set
            {
                _ocak2019_C5 = value;
                OnPropertyChanged(nameof(Ocak2019_C5));
            }
        }

        private int _ocak2019_C6;
        public int Ocak2019_C6
        {
            get { return _ocak2019_C6; }
            set
            {
                _ocak2019_C6 = value;
                OnPropertyChanged(nameof(Ocak2019_C6));
            }
        }

        private int _subat2019_C1;
        public int Subat2019_C1
        {
            get { return _subat2019_C1; }
            set
            {
                _subat2019_C1 = value;
                OnPropertyChanged(nameof(Subat2019_C1));
            }
        }

        private int _subat2019_C2;
        public int Subat2019_C2
        {
            get { return _subat2019_C2; }
            set
            {
                _subat2019_C2 = value;
                OnPropertyChanged(nameof(Subat2019_C2));
            }
        }

        private int _subat2019_C3;
        public int Subat2019_C3
        {
            get { return _subat2019_C3; }
            set
            {
                _subat2019_C3 = value;
                OnPropertyChanged(nameof(Subat2019_C3));
            }
        }

        private int _subat2019_C4;
        public int Subat2019_C4
        {
            get { return _subat2019_C4; }
            set
            {
                _subat2019_C4 = value;
                OnPropertyChanged(nameof(Subat2019_C4));
            }
        }

        private int _subat2019_C5;
        public int Subat2019_C5
        {
            get { return _subat2019_C5; }
            set
            {
                _subat2019_C5 = value;
                OnPropertyChanged(nameof(Subat2019_C5));
            }
        }

        private int _subat2019_C6;
        public int Subat2019_C6
        {
            get { return _subat2019_C6; }
            set
            {
                _subat2019_C6 = value;
                OnPropertyChanged(nameof(Subat2019_C6));
            }
        }

        private int _mart2019_C1;
        public int Mart2019_C1
        {
            get { return _mart2019_C1; }
            set
            {
                _mart2019_C1 = value;
                OnPropertyChanged(nameof(Mart2019_C1));
            }
        }

        private int _mart2019_C2;
        public int Mart2019_C2
        {
            get { return _mart2019_C2; }
            set
            {
                _mart2019_C2 = value;
                OnPropertyChanged(nameof(Mart2019_C2));
            }
        }

        private int _mart2019_C3;
        public int Mart2019_C3
        {
            get { return _mart2019_C3; }
            set
            {
                _mart2019_C3 = value;
                OnPropertyChanged(nameof(Mart2019_C3));
            }
        }

        private int _mart2019_C4;
        public int Mart2019_C4
        {
            get { return _mart2019_C4; }
            set
            {
                _mart2019_C4 = value;
                OnPropertyChanged(nameof(Mart2019_C4));
            }
        }

        private int _mart2019_C5;
        public int Mart2019_C5
        {
            get { return _mart2019_C5; }
            set
            {
                _mart2019_C5 = value;
                OnPropertyChanged(nameof(Mart2019_C5));
            }
        }

        private int _mart2019_C6;
        public int Mart2019_C6
        {
            get { return _mart2019_C6; }
            set
            {
                _mart2019_C6 = value;
                OnPropertyChanged(nameof(Mart2019_C6));
            }
        }
        private int _nisan2019_C1;
        public int Nisan2019_C1
        {
            get { return _nisan2019_C1; }
            set
            {
                _nisan2019_C1 = value;
                OnPropertyChanged(nameof(Nisan2019_C1));
            }
        }

        private int _nisan2019_C2;
        public int Nisan2019_C2
        {
            get { return _nisan2019_C2; }
            set
            {
                _nisan2019_C2 = value;
                OnPropertyChanged(nameof(Nisan2019_C2));
            }
        }

        private int _nisan2019_C3;
        public int Nisan2019_C3
        {
            get { return _nisan2019_C3; }
            set
            {
                _nisan2019_C3 = value;
                OnPropertyChanged(nameof(Nisan2019_C3));
            }
        }

        private int _nisan2019_C4;
        public int Nisan2019_C4
        {
            get { return _nisan2019_C4; }
            set
            {
                _nisan2019_C4 = value;
                OnPropertyChanged(nameof(Nisan2019_C4));
            }
        }

        private int _nisan2019_C5;
        public int Nisan2019_C5
        {
            get { return _nisan2019_C5; }
            set
            {
                _nisan2019_C5 = value;
                OnPropertyChanged(nameof(Nisan2019_C5));
            }
        }

        private int _nisan2019_C6;
        public int Nisan2019_C6
        {
            get { return _nisan2019_C6; }
            set
            {
                _nisan2019_C6 = value;
                OnPropertyChanged(nameof(Nisan2019_C6));
            }
        }

        private int _mayis2019_C1;
        public int Mayis2019_C1
        {
            get { return _mayis2019_C1; }
            set
            {
                _mayis2019_C1 = value;
                OnPropertyChanged(nameof(Mayis2019_C1));
            }
        }

        private int _mayis2019_C2;
        public int Mayis2019_C2
        {
            get { return _mayis2019_C2; }
            set
            {
                _mayis2019_C2 = value;
                OnPropertyChanged(nameof(Mayis2019_C2));
            }
        }

        private int _mayis2019_C3;
        public int Mayis2019_C3
        {
            get { return _mayis2019_C3; }
            set
            {
                _mayis2019_C3 = value;
                OnPropertyChanged(nameof(Mayis2019_C3));
            }
        }

        private int _mayis2019_C4;
        public int Mayis2019_C4
        {
            get { return _mayis2019_C4; }
            set
            {
                _mayis2019_C4 = value;
                OnPropertyChanged(nameof(Mayis2019_C4));
            }
        }

        private int _mayis2019_C5;
        public int Mayis2019_C5
        {
            get { return _mayis2019_C5; }
            set
            {
                _mayis2019_C5 = value;
                OnPropertyChanged(nameof(Mayis2019_C5));
            }
        }

        private int _mayis2019_C6;
        public int Mayis2019_C6
        {
            get { return _mayis2019_C6; }
            set
            {
                _mayis2019_C6 = value;
                OnPropertyChanged(nameof(Mayis2019_C6));
            }
        }

        private int _haziran2019_C1;
        public int Haziran2019_C1
        {
            get { return _haziran2019_C1; }
            set
            {
                _haziran2019_C1 = value;
                OnPropertyChanged(nameof(Haziran2019_C1));
            }
        }

        private int _haziran2019_C2;
        public int Haziran2019_C2
        {
            get { return _haziran2019_C2; }
            set
            {
                _haziran2019_C2 = value;
                OnPropertyChanged(nameof(Haziran2019_C2));
            }
        }

        private int _haziran2019_C3;
        public int Haziran2019_C3
        {
            get { return _haziran2019_C3; }
            set
            {
                _haziran2019_C3 = value;
                OnPropertyChanged(nameof(Haziran2019_C3));
            }
        }

        private int _haziran2019_C4;
        public int Haziran2019_C4
        {
            get { return _haziran2019_C4; }
            set
            {
                _haziran2019_C4 = value;
                OnPropertyChanged(nameof(Haziran2019_C4));
            }
        }

        private int _haziran2019_C5;
        public int Haziran2019_C5
        {
            get { return _haziran2019_C5; }
            set
            {
                _haziran2019_C5 = value;
                OnPropertyChanged(nameof(Haziran2019_C5));
            }
        }

        private int _haziran2019_C6;
        public int Haziran2019_C6
        {
            get { return _haziran2019_C6; }
            set
            {
                _haziran2019_C6 = value;
                OnPropertyChanged(nameof(Haziran2019_C6));
            }
        }

        private int _temmuz2019_C1;
        public int Temmuz2019_C1
        {
            get { return _temmuz2019_C1; }
            set
            {
                _temmuz2019_C1 = value;
                OnPropertyChanged(nameof(Temmuz2019_C1));
            }
        }

        private int _temmuz2019_C2;
        public int Temmuz2019_C2
        {
            get { return _temmuz2019_C2; }
            set
            {
                _temmuz2019_C2 = value;
                OnPropertyChanged(nameof(Temmuz2019_C2));
            }
        }

        private int _temmuz2019_C3;
        public int Temmuz2019_C3
        {
            get { return _temmuz2019_C3; }
            set
            {
                _temmuz2019_C3 = value;
                OnPropertyChanged(nameof(Temmuz2019_C3));
            }
        }

        private int _temmuz2019_C4;
        public int Temmuz2019_C4
        {
            get { return _temmuz2019_C4; }
            set
            {
                _temmuz2019_C4 = value;
                OnPropertyChanged(nameof(Temmuz2019_C4));
            }
        }

        private int _temmuz2019_C5;
        public int Temmuz2019_C5
        {
            get { return _temmuz2019_C5; }
            set
            {
                _temmuz2019_C5 = value;
                OnPropertyChanged(nameof(Temmuz2019_C5));
            }
        }

        private int _temmuz2019_C6;
        public int Temmuz2019_C6
        {
            get { return _temmuz2019_C6; }
            set
            {
                _temmuz2019_C6 = value;
                OnPropertyChanged(nameof(Temmuz2019_C6));
            }
        }

        private int _agustos2019_C1;
        public int Agustos2019_C1
        {
            get { return _agustos2019_C1; }
            set
            {
                _agustos2019_C1 = value;
                OnPropertyChanged(nameof(Agustos2019_C1));
            }
        }

        private int _agustos2019_C2;
        public int Agustos2019_C2
        {
            get { return _agustos2019_C2; }
            set
            {
                _agustos2019_C2 = value;
                OnPropertyChanged(nameof(Agustos2019_C2));
            }
        }

        private int _agustos2019_C3;
        public int Agustos2019_C3
        {
            get { return _agustos2019_C3; }
            set
            {
                _agustos2019_C3 = value;
                OnPropertyChanged(nameof(Agustos2019_C3));
            }
        }

        private int _agustos2019_C4;
        public int Agustos2019_C4
        {
            get { return _agustos2019_C4; }
            set
            {
                _agustos2019_C4 = value;
                OnPropertyChanged(nameof(Agustos2019_C4));
            }
        }

        private int _agustos2019_C5;
        public int Agustos2019_C5
        {
            get { return _agustos2019_C5; }
            set
            {
                _agustos2019_C5 = value;
                OnPropertyChanged(nameof(Agustos2019_C5));
            }
        }

        private int _agustos2019_C6;
        public int Agustos2019_C6
        {
            get { return _agustos2019_C6; }
            set
            {
                _agustos2019_C6 = value;
                OnPropertyChanged(nameof(Agustos2019_C6));
            }
        }

        private int _eylul2019_C1;
        public int Eylul2019_C1
        {
            get { return _eylul2019_C1; }
            set
            {
                _eylul2019_C1 = value;
                OnPropertyChanged(nameof(Eylul2019_C1));
            }
        }

        private int _eylul2019_C2;
        public int Eylul2019_C2
        {
            get { return _eylul2019_C2; }
            set
            {
                _eylul2019_C2 = value;
                OnPropertyChanged(nameof(Eylul2019_C2));
            }
        }

        private int _eylul2019_C3;
        public int Eylul2019_C3
        {
            get { return _eylul2019_C3; }
            set
            {
                _eylul2019_C3 = value;
                OnPropertyChanged(nameof(Eylul2019_C3));
            }
        }

        private int _eylul2019_C4;
        public int Eylul2019_C4
        {
            get { return _eylul2019_C4; }
            set
            {
                _eylul2019_C4 = value;
                OnPropertyChanged(nameof(Eylul2019_C4));
            }
        }

        private int _eylul2019_C5;
        public int Eylul2019_C5
        {
            get { return _eylul2019_C5; }
            set
            {
                _eylul2019_C5 = value;
                OnPropertyChanged(nameof(Eylul2019_C5));
            }
        }

        private int _eylul2019_C6;
        public int Eylul2019_C6
        {
            get { return _eylul2019_C6; }
            set
            {
                _eylul2019_C6 = value;
                OnPropertyChanged(nameof(Eylul2019_C6));
            }
        }

        private int _ekim2019_C1;
        public int Ekim2019_C1
        {
            get { return _ekim2019_C1; }
            set
            {
                _ekim2019_C1 = value;
                OnPropertyChanged(nameof(Ekim2019_C1));
            }
        }

        private int _ekim2019_C2;
        public int Ekim2019_C2
        {
            get { return _ekim2019_C2; }
            set
            {
                _ekim2019_C2 = value;
                OnPropertyChanged(nameof(Ekim2019_C2));
            }
        }

        private int _ekim2019_C3;
        public int Ekim2019_C3
        {
            get { return _ekim2019_C3; }
            set
            {
                _ekim2019_C3 = value;
                OnPropertyChanged(nameof(Ekim2019_C3));
            }
        }

        private int _ekim2019_C4;
        public int Ekim2019_C4
        {
            get { return _ekim2019_C4; }
            set
            {
                _ekim2019_C4 = value;
                OnPropertyChanged(nameof(Ekim2019_C4));
            }
        }

        private int _ekim2019_C5;
        public int Ekim2019_C5
        {
            get { return _ekim2019_C5; }
            set
            {
                _ekim2019_C5 = value;
                OnPropertyChanged(nameof(Ekim2019_C5));
            }
        }

        private int _ekim2019_C6;
        public int Ekim2019_C6
        {
            get { return _ekim2019_C6; }
            set
            {
                _ekim2019_C6 = value;
                OnPropertyChanged(nameof(Ekim2019_C6));
            }
        }

        private int _kasim2019_C1;
        public int Kasim2019_C1
        {
            get { return _kasim2019_C1; }
            set
            {
                _kasim2019_C1 = value;
                OnPropertyChanged(nameof(Kasim2019_C1));
            }
        }

        private int _kasim2019_C2;
        public int Kasim2019_C2
        {
            get { return _kasim2019_C2; }
            set
            {
                _kasim2019_C2 = value;
                OnPropertyChanged(nameof(Kasim2019_C2));
            }
        }

        private int _kasim2019_C3;
        public int Kasim2019_C3
        {
            get { return _kasim2019_C3; }
            set
            {
                _kasim2019_C3 = value;
                OnPropertyChanged(nameof(Kasim2019_C3));
            }
        }

        private int _kasim2019_C4;
        public int Kasim2019_C4
        {
            get { return _kasim2019_C4; }
            set
            {
                _kasim2019_C4 = value;
                OnPropertyChanged(nameof(Kasim2019_C4));
            }
        }

        private int _kasim2019_C5;
        public int Kasim2019_C5
        {
            get { return _kasim2019_C5; }
            set
            {
                _kasim2019_C5 = value;
                OnPropertyChanged(nameof(Kasim2019_C5));
            }
        }

        private int _kasim2019_C6;
        public int Kasim2019_C6
        {
            get { return _kasim2019_C6; }
            set
            {
                _kasim2019_C6 = value;
                OnPropertyChanged(nameof(Kasim2019_C6));
            }
        }
        private int _aralik2019_C1;
        public int Aralik2019_C1
        {
            get { return _aralik2019_C1; }
            set
            {
                _aralik2019_C1 = value;
                OnPropertyChanged(nameof(Aralik2019_C1));
            }
        }

        private int _aralik2019_C2;
        public int Aralik2019_C2
        {
            get { return _aralik2019_C2; }
            set
            {
                _aralik2019_C2 = value;
                OnPropertyChanged(nameof(Aralik2019_C2));
            }
        }

        private int _aralik2019_C3;
        public int Aralik2019_C3
        {
            get { return _aralik2019_C3; }
            set
            {
                _aralik2019_C3 = value;
                OnPropertyChanged(nameof(Aralik2019_C3));
            }
        }

        private int _aralik2019_C4;
        public int Aralik2019_C4
        {
            get { return _aralik2019_C4; }
            set
            {
                _aralik2019_C4 = value;
                OnPropertyChanged(nameof(Aralik2019_C4));
            }
        }

        private int _aralik2019_C5;
        public int Aralik2019_C5
        {
            get { return _aralik2019_C5; }
            set
            {
                _aralik2019_C5 = value;
                OnPropertyChanged(nameof(Aralik2019_C5));
            }
        }

        private int _aralik2019_C6;
        public int Aralik2019_C6
        {
            get { return _aralik2019_C6; }
            set
            {
                _aralik2019_C6 = value;
                OnPropertyChanged(nameof(Aralik2019_C6));
            }
        }
        #endregion

        #region IZIN 2020


        private int _ocak2020_C1;
        public int Ocak2020_C1
        {
            get { return _ocak2020_C1; }
            set
            {
                _ocak2020_C1 = value;
                OnPropertyChanged(nameof(Ocak2020_C1));
            }
        }

        private int _ocak2020_C2;
        public int Ocak2020_C2
        {
            get { return _ocak2020_C2; }
            set
            {
                _ocak2020_C2 = value;
                OnPropertyChanged(nameof(Ocak2020_C2));
            }
        }

        private int _ocak2020_C3;
        public int Ocak2020_C3
        {
            get { return _ocak2020_C3; }
            set
            {
                _ocak2020_C3 = value;
                OnPropertyChanged(nameof(Ocak2020_C3));
            }
        }

        private int _ocak2020_C4;
        public int Ocak2020_C4
        {
            get { return _ocak2020_C4; }
            set
            {
                _ocak2020_C4 = value;
                OnPropertyChanged(nameof(Ocak2020_C4));
            }
        }

        private int _ocak2020_C5;
        public int Ocak2020_C5
        {
            get { return _ocak2020_C5; }
            set
            {
                _ocak2020_C5 = value;
                OnPropertyChanged(nameof(Ocak2020_C5));
            }
        }

        private int _ocak2020_C6;
        public int Ocak2020_C6
        {
            get { return _ocak2020_C6; }
            set
            {
                _ocak2020_C6 = value;
                OnPropertyChanged(nameof(Ocak2020_C6));
            }
        }

        private int _subat2020_C1;
        public int Subat2020_C1
        {
            get { return _subat2020_C1; }
            set
            {
                _subat2020_C1 = value;
                OnPropertyChanged(nameof(Subat2020_C1));
            }
        }

        private int _subat2020_C2;
        public int Subat2020_C2
        {
            get { return _subat2020_C2; }
            set
            {
                _subat2020_C2 = value;
                OnPropertyChanged(nameof(Subat2020_C2));
            }
        }

        private int _subat2020_C3;
        public int Subat2020_C3
        {
            get { return _subat2020_C3; }
            set
            {
                _subat2020_C3 = value;
                OnPropertyChanged(nameof(Subat2020_C3));
            }
        }

        private int _subat2020_C4;
        public int Subat2020_C4
        {
            get { return _subat2020_C4; }
            set
            {
                _subat2020_C4 = value;
                OnPropertyChanged(nameof(Subat2020_C4));
            }
        }

        private int _subat2020_C5;
        public int Subat2020_C5
        {
            get { return _subat2020_C5; }
            set
            {
                _subat2020_C5 = value;
                OnPropertyChanged(nameof(Subat2020_C5));
            }
        }

        private int _subat2020_C6;
        public int Subat2020_C6
        {
            get { return _subat2020_C6; }
            set
            {
                _subat2020_C6 = value;
                OnPropertyChanged(nameof(Subat2020_C6));
            }
        }

        private int _mart2020_C1;
        public int Mart2020_C1
        {
            get { return _mart2020_C1; }
            set
            {
                _mart2020_C1 = value;
                OnPropertyChanged(nameof(Mart2020_C1));
            }
        }

        private int _mart2020_C2;
        public int Mart2020_C2
        {
            get { return _mart2020_C2; }
            set
            {
                _mart2020_C2 = value;
                OnPropertyChanged(nameof(Mart2020_C2));
            }
        }

        private int _mart2020_C3;
        public int Mart2020_C3
        {
            get { return _mart2020_C3; }
            set
            {
                _mart2020_C3 = value;
                OnPropertyChanged(nameof(Mart2020_C3));
            }
        }

        private int _mart2020_C4;
        public int Mart2020_C4
        {
            get { return _mart2020_C4; }
            set
            {
                _mart2020_C4 = value;
                OnPropertyChanged(nameof(Mart2020_C4));
            }
        }

        private int _mart2020_C5;
        public int Mart2020_C5
        {
            get { return _mart2020_C5; }
            set
            {
                _mart2020_C5 = value;
                OnPropertyChanged(nameof(Mart2020_C5));
            }
        }

        private int _mart2020_C6;
        public int Mart2020_C6
        {
            get { return _mart2020_C6; }
            set
            {
                _mart2020_C6 = value;
                OnPropertyChanged(nameof(Mart2020_C6));
            }
        }
        private int _nisan2020_C1;
        public int Nisan2020_C1
        {
            get { return _nisan2020_C1; }
            set
            {
                _nisan2020_C1 = value;
                OnPropertyChanged(nameof(Nisan2020_C1));
            }
        }

        private int _nisan2020_C2;
        public int Nisan2020_C2
        {
            get { return _nisan2020_C2; }
            set
            {
                _nisan2020_C2 = value;
                OnPropertyChanged(nameof(Nisan2020_C2));
            }
        }

        private int _nisan2020_C3;
        public int Nisan2020_C3
        {
            get { return _nisan2020_C3; }
            set
            {
                _nisan2020_C3 = value;
                OnPropertyChanged(nameof(Nisan2020_C3));
            }
        }

        private int _nisan2020_C4;
        public int Nisan2020_C4
        {
            get { return _nisan2020_C4; }
            set
            {
                _nisan2020_C4 = value;
                OnPropertyChanged(nameof(Nisan2020_C4));
            }
        }

        private int _nisan2020_C5;
        public int Nisan2020_C5
        {
            get { return _nisan2020_C5; }
            set
            {
                _nisan2020_C5 = value;
                OnPropertyChanged(nameof(Nisan2020_C5));
            }
        }

        private int _nisan2020_C6;
        public int Nisan2020_C6
        {
            get { return _nisan2020_C6; }
            set
            {
                _nisan2020_C6 = value;
                OnPropertyChanged(nameof(Nisan2020_C6));
            }
        }

        private int _mayis2020_C1;
        public int Mayis2020_C1
        {
            get { return _mayis2020_C1; }
            set
            {
                _mayis2020_C1 = value;
                OnPropertyChanged(nameof(Mayis2020_C1));
            }
        }

        private int _mayis2020_C2;
        public int Mayis2020_C2
        {
            get { return _mayis2020_C2; }
            set
            {
                _mayis2020_C2 = value;
                OnPropertyChanged(nameof(Mayis2020_C2));
            }
        }

        private int _mayis2020_C3;
        public int Mayis2020_C3
        {
            get { return _mayis2020_C3; }
            set
            {
                _mayis2020_C3 = value;
                OnPropertyChanged(nameof(Mayis2020_C3));
            }
        }

        private int _mayis2020_C4;
        public int Mayis2020_C4
        {
            get { return _mayis2020_C4; }
            set
            {
                _mayis2020_C4 = value;
                OnPropertyChanged(nameof(Mayis2020_C4));
            }
        }

        private int _mayis2020_C5;
        public int Mayis2020_C5
        {
            get { return _mayis2020_C5; }
            set
            {
                _mayis2020_C5 = value;
                OnPropertyChanged(nameof(Mayis2020_C5));
            }
        }

        private int _mayis2020_C6;
        public int Mayis2020_C6
        {
            get { return _mayis2020_C6; }
            set
            {
                _mayis2020_C6 = value;
                OnPropertyChanged(nameof(Mayis2020_C6));
            }
        }

        private int _haziran2020_C1;
        public int Haziran2020_C1
        {
            get { return _haziran2020_C1; }
            set
            {
                _haziran2020_C1 = value;
                OnPropertyChanged(nameof(Haziran2020_C1));
            }
        }

        private int _haziran2020_C2;
        public int Haziran2020_C2
        {
            get { return _haziran2020_C2; }
            set
            {
                _haziran2020_C2 = value;
                OnPropertyChanged(nameof(Haziran2020_C2));
            }
        }

        private int _haziran2020_C3;
        public int Haziran2020_C3
        {
            get { return _haziran2020_C3; }
            set
            {
                _haziran2020_C3 = value;
                OnPropertyChanged(nameof(Haziran2020_C3));
            }
        }

        private int _haziran2020_C4;
        public int Haziran2020_C4
        {
            get { return _haziran2020_C4; }
            set
            {
                _haziran2020_C4 = value;
                OnPropertyChanged(nameof(Haziran2020_C4));
            }
        }

        private int _haziran2020_C5;
        public int Haziran2020_C5
        {
            get { return _haziran2020_C5; }
            set
            {
                _haziran2020_C5 = value;
                OnPropertyChanged(nameof(Haziran2020_C5));
            }
        }

        private int _haziran2020_C6;
        public int Haziran2020_C6
        {
            get { return _haziran2020_C6; }
            set
            {
                _haziran2020_C6 = value;
                OnPropertyChanged(nameof(Haziran2020_C6));
            }
        }

        private int _temmuz2020_C1;
        public int Temmuz2020_C1
        {
            get { return _temmuz2020_C1; }
            set
            {
                _temmuz2020_C1 = value;
                OnPropertyChanged(nameof(Temmuz2020_C1));
            }
        }

        private int _temmuz2020_C2;
        public int Temmuz2020_C2
        {
            get { return _temmuz2020_C2; }
            set
            {
                _temmuz2020_C2 = value;
                OnPropertyChanged(nameof(Temmuz2020_C2));
            }
        }

        private int _temmuz2020_C3;
        public int Temmuz2020_C3
        {
            get { return _temmuz2020_C3; }
            set
            {
                _temmuz2020_C3 = value;
                OnPropertyChanged(nameof(Temmuz2020_C3));
            }
        }

        private int _temmuz2020_C4;
        public int Temmuz2020_C4
        {
            get { return _temmuz2020_C4; }
            set
            {
                _temmuz2020_C4 = value;
                OnPropertyChanged(nameof(Temmuz2020_C4));
            }
        }

        private int _temmuz2020_C5;
        public int Temmuz2020_C5
        {
            get { return _temmuz2020_C5; }
            set
            {
                _temmuz2020_C5 = value;
                OnPropertyChanged(nameof(Temmuz2020_C5));
            }
        }

        private int _temmuz2020_C6;
        public int Temmuz2020_C6
        {
            get { return _temmuz2020_C6; }
            set
            {
                _temmuz2020_C6 = value;
                OnPropertyChanged(nameof(Temmuz2020_C6));
            }
        }

        private int _agustos2020_C1;
        public int Agustos2020_C1
        {
            get { return _agustos2020_C1; }
            set
            {
                _agustos2020_C1 = value;
                OnPropertyChanged(nameof(Agustos2020_C1));
            }
        }

        private int _agustos2020_C2;
        public int Agustos2020_C2
        {
            get { return _agustos2020_C2; }
            set
            {
                _agustos2020_C2 = value;
                OnPropertyChanged(nameof(Agustos2020_C2));
            }
        }

        private int _agustos2020_C3;
        public int Agustos2020_C3
        {
            get { return _agustos2020_C3; }
            set
            {
                _agustos2020_C3 = value;
                OnPropertyChanged(nameof(Agustos2020_C3));
            }
        }

        private int _agustos2020_C4;
        public int Agustos2020_C4
        {
            get { return _agustos2020_C4; }
            set
            {
                _agustos2020_C4 = value;
                OnPropertyChanged(nameof(Agustos2020_C4));
            }
        }

        private int _agustos2020_C5;
        public int Agustos2020_C5
        {
            get { return _agustos2020_C5; }
            set
            {
                _agustos2020_C5 = value;
                OnPropertyChanged(nameof(Agustos2020_C5));
            }
        }

        private int _agustos2020_C6;
        public int Agustos2020_C6
        {
            get { return _agustos2020_C6; }
            set
            {
                _agustos2020_C6 = value;
                OnPropertyChanged(nameof(Agustos2020_C6));
            }
        }

        private int _eylul2020_C1;
        public int Eylul2020_C1
        {
            get { return _eylul2020_C1; }
            set
            {
                _eylul2020_C1 = value;
                OnPropertyChanged(nameof(Eylul2020_C1));
            }
        }

        private int _eylul2020_C2;
        public int Eylul2020_C2
        {
            get { return _eylul2020_C2; }
            set
            {
                _eylul2020_C2 = value;
                OnPropertyChanged(nameof(Eylul2020_C2));
            }
        }

        private int _eylul2020_C3;
        public int Eylul2020_C3
        {
            get { return _eylul2020_C3; }
            set
            {
                _eylul2020_C3 = value;
                OnPropertyChanged(nameof(Eylul2020_C3));
            }
        }

        private int _eylul2020_C4;
        public int Eylul2020_C4
        {
            get { return _eylul2020_C4; }
            set
            {
                _eylul2020_C4 = value;
                OnPropertyChanged(nameof(Eylul2020_C4));
            }
        }

        private int _eylul2020_C5;
        public int Eylul2020_C5
        {
            get { return _eylul2020_C5; }
            set
            {
                _eylul2020_C5 = value;
                OnPropertyChanged(nameof(Eylul2020_C5));
            }
        }

        private int _eylul2020_C6;
        public int Eylul2020_C6
        {
            get { return _eylul2020_C6; }
            set
            {
                _eylul2020_C6 = value;
                OnPropertyChanged(nameof(Eylul2020_C6));
            }
        }

        private int _ekim2020_C1;
        public int Ekim2020_C1
        {
            get { return _ekim2020_C1; }
            set
            {
                _ekim2020_C1 = value;
                OnPropertyChanged(nameof(Ekim2020_C1));
            }
        }

        private int _ekim2020_C2;
        public int Ekim2020_C2
        {
            get { return _ekim2020_C2; }
            set
            {
                _ekim2020_C2 = value;
                OnPropertyChanged(nameof(Ekim2020_C2));
            }
        }

        private int _ekim2020_C3;
        public int Ekim2020_C3
        {
            get { return _ekim2020_C3; }
            set
            {
                _ekim2020_C3 = value;
                OnPropertyChanged(nameof(Ekim2020_C3));
            }
        }

        private int _ekim2020_C4;
        public int Ekim2020_C4
        {
            get { return _ekim2020_C4; }
            set
            {
                _ekim2020_C4 = value;
                OnPropertyChanged(nameof(Ekim2020_C4));
            }
        }

        private int _ekim2020_C5;
        public int Ekim2020_C5
        {
            get { return _ekim2020_C5; }
            set
            {
                _ekim2020_C5 = value;
                OnPropertyChanged(nameof(Ekim2020_C5));
            }
        }

        private int _ekim2020_C6;
        public int Ekim2020_C6
        {
            get { return _ekim2020_C6; }
            set
            {
                _ekim2020_C6 = value;
                OnPropertyChanged(nameof(Ekim2020_C6));
            }
        }

        private int _kasim2020_C1;
        public int Kasim2020_C1
        {
            get { return _kasim2020_C1; }
            set
            {
                _kasim2020_C1 = value;
                OnPropertyChanged(nameof(Kasim2020_C1));
            }
        }

        private int _kasim2020_C2;
        public int Kasim2020_C2
        {
            get { return _kasim2020_C2; }
            set
            {
                _kasim2020_C2 = value;
                OnPropertyChanged(nameof(Kasim2020_C2));
            }
        }

        private int _kasim2020_C3;
        public int Kasim2020_C3
        {
            get { return _kasim2020_C3; }
            set
            {
                _kasim2020_C3 = value;
                OnPropertyChanged(nameof(Kasim2020_C3));
            }
        }

        private int _kasim2020_C4;
        public int Kasim2020_C4
        {
            get { return _kasim2020_C4; }
            set
            {
                _kasim2020_C4 = value;
                OnPropertyChanged(nameof(Kasim2020_C4));
            }
        }

        private int _kasim2020_C5;
        public int Kasim2020_C5
        {
            get { return _kasim2020_C5; }
            set
            {
                _kasim2020_C5 = value;
                OnPropertyChanged(nameof(Kasim2020_C5));
            }
        }

        private int _kasim2020_C6;
        public int Kasim2020_C6
        {
            get { return _kasim2020_C6; }
            set
            {
                _kasim2020_C6 = value;
                OnPropertyChanged(nameof(Kasim2020_C6));
            }
        }
        private int _aralik2020_C1;
        public int Aralik2020_C1
        {
            get { return _aralik2020_C1; }
            set
            {
                _aralik2020_C1 = value;
                OnPropertyChanged(nameof(Aralik2020_C1));
            }
        }

        private int _aralik2020_C2;
        public int Aralik2020_C2
        {
            get { return _aralik2020_C2; }
            set
            {
                _aralik2020_C2 = value;
                OnPropertyChanged(nameof(Aralik2020_C2));
            }
        }

        private int _aralik2020_C3;
        public int Aralik2020_C3
        {
            get { return _aralik2020_C3; }
            set
            {
                _aralik2020_C3 = value;
                OnPropertyChanged(nameof(Aralik2020_C3));
            }
        }

        private int _aralik2020_C4;
        public int Aralik2020_C4
        {
            get { return _aralik2020_C4; }
            set
            {
                _aralik2020_C4 = value;
                OnPropertyChanged(nameof(Aralik2020_C4));
            }
        }

        private int _aralik2020_C5;
        public int Aralik2020_C5
        {
            get { return _aralik2020_C5; }
            set
            {
                _aralik2020_C5 = value;
                OnPropertyChanged(nameof(Aralik2020_C5));
            }
        }

        private int _aralik2020_C6;
        public int Aralik2020_C6
        {
            get { return _aralik2020_C6; }
            set
            {
                _aralik2020_C6 = value;
                OnPropertyChanged(nameof(Aralik2020_C6));
            }
        }
        #endregion

        #region IZIN 2021


        private int _ocak2021_C1;
        public int Ocak2021_C1
        {
            get { return _ocak2021_C1; }
            set
            {
                _ocak2021_C1 = value;
                OnPropertyChanged(nameof(Ocak2021_C1));
            }
        }

        private int _ocak2021_C2;
        public int Ocak2021_C2
        {
            get { return _ocak2021_C2; }
            set
            {
                _ocak2021_C2 = value;
                OnPropertyChanged(nameof(Ocak2021_C2));
            }
        }

        private int _ocak2021_C3;
        public int Ocak2021_C3
        {
            get { return _ocak2021_C3; }
            set
            {
                _ocak2021_C3 = value;
                OnPropertyChanged(nameof(Ocak2021_C3));
            }
        }

        private int _ocak2021_C4;
        public int Ocak2021_C4
        {
            get { return _ocak2021_C4; }
            set
            {
                _ocak2021_C4 = value;
                OnPropertyChanged(nameof(Ocak2021_C4));
            }
        }

        private int _ocak2021_C5;
        public int Ocak2021_C5
        {
            get { return _ocak2021_C5; }
            set
            {
                _ocak2021_C5 = value;
                OnPropertyChanged(nameof(Ocak2021_C5));
            }
        }

        private int _ocak2021_C6;
        public int Ocak2021_C6
        {
            get { return _ocak2021_C6; }
            set
            {
                _ocak2021_C6 = value;
                OnPropertyChanged(nameof(Ocak2021_C6));
            }
        }

        private int _subat2021_C1;
        public int Subat2021_C1
        {
            get { return _subat2021_C1; }
            set
            {
                _subat2021_C1 = value;
                OnPropertyChanged(nameof(Subat2021_C1));
            }
        }

        private int _subat2021_C2;
        public int Subat2021_C2
        {
            get { return _subat2021_C2; }
            set
            {
                _subat2021_C2 = value;
                OnPropertyChanged(nameof(Subat2021_C2));
            }
        }

        private int _subat2021_C3;
        public int Subat2021_C3
        {
            get { return _subat2021_C3; }
            set
            {
                _subat2021_C3 = value;
                OnPropertyChanged(nameof(Subat2021_C3));
            }
        }

        private int _subat2021_C4;
        public int Subat2021_C4
        {
            get { return _subat2021_C4; }
            set
            {
                _subat2021_C4 = value;
                OnPropertyChanged(nameof(Subat2021_C4));
            }
        }

        private int _subat2021_C5;
        public int Subat2021_C5
        {
            get { return _subat2021_C5; }
            set
            {
                _subat2021_C5 = value;
                OnPropertyChanged(nameof(Subat2021_C5));
            }
        }

        private int _subat2021_C6;
        public int Subat2021_C6
        {
            get { return _subat2021_C6; }
            set
            {
                _subat2021_C6 = value;
                OnPropertyChanged(nameof(Subat2021_C6));
            }
        }

        private int _mart2021_C1;
        public int Mart2021_C1
        {
            get { return _mart2021_C1; }
            set
            {
                _mart2021_C1 = value;
                OnPropertyChanged(nameof(Mart2021_C1));
            }
        }

        private int _mart2021_C2;
        public int Mart2021_C2
        {
            get { return _mart2021_C2; }
            set
            {
                _mart2021_C2 = value;
                OnPropertyChanged(nameof(Mart2021_C2));
            }
        }

        private int _mart2021_C3;
        public int Mart2021_C3
        {
            get { return _mart2021_C3; }
            set
            {
                _mart2021_C3 = value;
                OnPropertyChanged(nameof(Mart2021_C3));
            }
        }

        private int _mart2021_C4;
        public int Mart2021_C4
        {
            get { return _mart2021_C4; }
            set
            {
                _mart2021_C4 = value;
                OnPropertyChanged(nameof(Mart2021_C4));
            }
        }

        private int _mart2021_C5;
        public int Mart2021_C5
        {
            get { return _mart2021_C5; }
            set
            {
                _mart2021_C5 = value;
                OnPropertyChanged(nameof(Mart2021_C5));
            }
        }

        private int _mart2021_C6;
        public int Mart2021_C6
        {
            get { return _mart2021_C6; }
            set
            {
                _mart2021_C6 = value;
                OnPropertyChanged(nameof(Mart2021_C6));
            }
        }
        private int _nisan2021_C1;
        public int Nisan2021_C1
        {
            get { return _nisan2021_C1; }
            set
            {
                _nisan2021_C1 = value;
                OnPropertyChanged(nameof(Nisan2021_C1));
            }
        }

        private int _nisan2021_C2;
        public int Nisan2021_C2
        {
            get { return _nisan2021_C2; }
            set
            {
                _nisan2021_C2 = value;
                OnPropertyChanged(nameof(Nisan2021_C2));
            }
        }

        private int _nisan2021_C3;
        public int Nisan2021_C3
        {
            get { return _nisan2021_C3; }
            set
            {
                _nisan2021_C3 = value;
                OnPropertyChanged(nameof(Nisan2021_C3));
            }
        }

        private int _nisan2021_C4;
        public int Nisan2021_C4
        {
            get { return _nisan2021_C4; }
            set
            {
                _nisan2021_C4 = value;
                OnPropertyChanged(nameof(Nisan2021_C4));
            }
        }

        private int _nisan2021_C5;
        public int Nisan2021_C5
        {
            get { return _nisan2021_C5; }
            set
            {
                _nisan2021_C5 = value;
                OnPropertyChanged(nameof(Nisan2021_C5));
            }
        }

        private int _nisan2021_C6;
        public int Nisan2021_C6
        {
            get { return _nisan2021_C6; }
            set
            {
                _nisan2021_C6 = value;
                OnPropertyChanged(nameof(Nisan2021_C6));
            }
        }

        private int _mayis2021_C1;
        public int Mayis2021_C1
        {
            get { return _mayis2021_C1; }
            set
            {
                _mayis2021_C1 = value;
                OnPropertyChanged(nameof(Mayis2021_C1));
            }
        }

        private int _mayis2021_C2;
        public int Mayis2021_C2
        {
            get { return _mayis2021_C2; }
            set
            {
                _mayis2021_C2 = value;
                OnPropertyChanged(nameof(Mayis2021_C2));
            }
        }

        private int _mayis2021_C3;
        public int Mayis2021_C3
        {
            get { return _mayis2021_C3; }
            set
            {
                _mayis2021_C3 = value;
                OnPropertyChanged(nameof(Mayis2021_C3));
            }
        }

        private int _mayis2021_C4;
        public int Mayis2021_C4
        {
            get { return _mayis2021_C4; }
            set
            {
                _mayis2021_C4 = value;
                OnPropertyChanged(nameof(Mayis2021_C4));
            }
        }

        private int _mayis2021_C5;
        public int Mayis2021_C5
        {
            get { return _mayis2021_C5; }
            set
            {
                _mayis2021_C5 = value;
                OnPropertyChanged(nameof(Mayis2021_C5));
            }
        }

        private int _mayis2021_C6;
        public int Mayis2021_C6
        {
            get { return _mayis2021_C6; }
            set
            {
                _mayis2021_C6 = value;
                OnPropertyChanged(nameof(Mayis2021_C6));
            }
        }

        private int _haziran2021_C1;
        public int Haziran2021_C1
        {
            get { return _haziran2021_C1; }
            set
            {
                _haziran2021_C1 = value;
                OnPropertyChanged(nameof(Haziran2021_C1));
            }
        }

        private int _haziran2021_C2;
        public int Haziran2021_C2
        {
            get { return _haziran2021_C2; }
            set
            {
                _haziran2021_C2 = value;
                OnPropertyChanged(nameof(Haziran2021_C2));
            }
        }

        private int _haziran2021_C3;
        public int Haziran2021_C3
        {
            get { return _haziran2021_C3; }
            set
            {
                _haziran2021_C3 = value;
                OnPropertyChanged(nameof(Haziran2021_C3));
            }
        }

        private int _haziran2021_C4;
        public int Haziran2021_C4
        {
            get { return _haziran2021_C4; }
            set
            {
                _haziran2021_C4 = value;
                OnPropertyChanged(nameof(Haziran2021_C4));
            }
        }

        private int _haziran2021_C5;
        public int Haziran2021_C5
        {
            get { return _haziran2021_C5; }
            set
            {
                _haziran2021_C5 = value;
                OnPropertyChanged(nameof(Haziran2021_C5));
            }
        }

        private int _haziran2021_C6;
        public int Haziran2021_C6
        {
            get { return _haziran2021_C6; }
            set
            {
                _haziran2021_C6 = value;
                OnPropertyChanged(nameof(Haziran2021_C6));
            }
        }

        private int _temmuz2021_C1;
        public int Temmuz2021_C1
        {
            get { return _temmuz2021_C1; }
            set
            {
                _temmuz2021_C1 = value;
                OnPropertyChanged(nameof(Temmuz2021_C1));
            }
        }

        private int _temmuz2021_C2;
        public int Temmuz2021_C2
        {
            get { return _temmuz2021_C2; }
            set
            {
                _temmuz2021_C2 = value;
                OnPropertyChanged(nameof(Temmuz2021_C2));
            }
        }

        private int _temmuz2021_C3;
        public int Temmuz2021_C3
        {
            get { return _temmuz2021_C3; }
            set
            {
                _temmuz2021_C3 = value;
                OnPropertyChanged(nameof(Temmuz2021_C3));
            }
        }

        private int _temmuz2021_C4;
        public int Temmuz2021_C4
        {
            get { return _temmuz2021_C4; }
            set
            {
                _temmuz2021_C4 = value;
                OnPropertyChanged(nameof(Temmuz2021_C4));
            }
        }

        private int _temmuz2021_C5;
        public int Temmuz2021_C5
        {
            get { return _temmuz2021_C5; }
            set
            {
                _temmuz2021_C5 = value;
                OnPropertyChanged(nameof(Temmuz2021_C5));
            }
        }

        private int _temmuz2021_C6;
        public int Temmuz2021_C6
        {
            get { return _temmuz2021_C6; }
            set
            {
                _temmuz2021_C6 = value;
                OnPropertyChanged(nameof(Temmuz2021_C6));
            }
        }

        private int _agustos2021_C1;
        public int Agustos2021_C1
        {
            get { return _agustos2021_C1; }
            set
            {
                _agustos2021_C1 = value;
                OnPropertyChanged(nameof(Agustos2021_C1));
            }
        }

        private int _agustos2021_C2;
        public int Agustos2021_C2
        {
            get { return _agustos2021_C2; }
            set
            {
                _agustos2021_C2 = value;
                OnPropertyChanged(nameof(Agustos2021_C2));
            }
        }

        private int _agustos2021_C3;
        public int Agustos2021_C3
        {
            get { return _agustos2021_C3; }
            set
            {
                _agustos2021_C3 = value;
                OnPropertyChanged(nameof(Agustos2021_C3));
            }
        }

        private int _agustos2021_C4;
        public int Agustos2021_C4
        {
            get { return _agustos2021_C4; }
            set
            {
                _agustos2021_C4 = value;
                OnPropertyChanged(nameof(Agustos2021_C4));
            }
        }

        private int _agustos2021_C5;
        public int Agustos2021_C5
        {
            get { return _agustos2021_C5; }
            set
            {
                _agustos2021_C5 = value;
                OnPropertyChanged(nameof(Agustos2021_C5));
            }
        }

        private int _agustos2021_C6;
        public int Agustos2021_C6
        {
            get { return _agustos2021_C6; }
            set
            {
                _agustos2021_C6 = value;
                OnPropertyChanged(nameof(Agustos2021_C6));
            }
        }

        private int _eylul2021_C1;
        public int Eylul2021_C1
        {
            get { return _eylul2021_C1; }
            set
            {
                _eylul2021_C1 = value;
                OnPropertyChanged(nameof(Eylul2021_C1));
            }
        }

        private int _eylul2021_C2;
        public int Eylul2021_C2
        {
            get { return _eylul2021_C2; }
            set
            {
                _eylul2021_C2 = value;
                OnPropertyChanged(nameof(Eylul2021_C2));
            }
        }

        private int _eylul2021_C3;
        public int Eylul2021_C3
        {
            get { return _eylul2021_C3; }
            set
            {
                _eylul2021_C3 = value;
                OnPropertyChanged(nameof(Eylul2021_C3));
            }
        }

        private int _eylul2021_C4;
        public int Eylul2021_C4
        {
            get { return _eylul2021_C4; }
            set
            {
                _eylul2021_C4 = value;
                OnPropertyChanged(nameof(Eylul2021_C4));
            }
        }

        private int _eylul2021_C5;
        public int Eylul2021_C5
        {
            get { return _eylul2021_C5; }
            set
            {
                _eylul2021_C5 = value;
                OnPropertyChanged(nameof(Eylul2021_C5));
            }
        }

        private int _eylul2021_C6;
        public int Eylul2021_C6
        {
            get { return _eylul2021_C6; }
            set
            {
                _eylul2021_C6 = value;
                OnPropertyChanged(nameof(Eylul2021_C6));
            }
        }

        private int _ekim2021_C1;
        public int Ekim2021_C1
        {
            get { return _ekim2021_C1; }
            set
            {
                _ekim2021_C1 = value;
                OnPropertyChanged(nameof(Ekim2021_C1));
            }
        }

        private int _ekim2021_C2;
        public int Ekim2021_C2
        {
            get { return _ekim2021_C2; }
            set
            {
                _ekim2021_C2 = value;
                OnPropertyChanged(nameof(Ekim2021_C2));
            }
        }

        private int _ekim2021_C3;
        public int Ekim2021_C3
        {
            get { return _ekim2021_C3; }
            set
            {
                _ekim2021_C3 = value;
                OnPropertyChanged(nameof(Ekim2021_C3));
            }
        }

        private int _ekim2021_C4;
        public int Ekim2021_C4
        {
            get { return _ekim2021_C4; }
            set
            {
                _ekim2021_C4 = value;
                OnPropertyChanged(nameof(Ekim2021_C4));
            }
        }

        private int _ekim2021_C5;
        public int Ekim2021_C5
        {
            get { return _ekim2021_C5; }
            set
            {
                _ekim2021_C5 = value;
                OnPropertyChanged(nameof(Ekim2021_C5));
            }
        }

        private int _ekim2021_C6;
        public int Ekim2021_C6
        {
            get { return _ekim2021_C6; }
            set
            {
                _ekim2021_C6 = value;
                OnPropertyChanged(nameof(Ekim2021_C6));
            }
        }

        private int _kasim2021_C1;
        public int Kasim2021_C1
        {
            get { return _kasim2021_C1; }
            set
            {
                _kasim2021_C1 = value;
                OnPropertyChanged(nameof(Kasim2021_C1));
            }
        }

        private int _kasim2021_C2;
        public int Kasim2021_C2
        {
            get { return _kasim2021_C2; }
            set
            {
                _kasim2021_C2 = value;
                OnPropertyChanged(nameof(Kasim2021_C2));
            }
        }

        private int _kasim2021_C3;
        public int Kasim2021_C3
        {
            get { return _kasim2021_C3; }
            set
            {
                _kasim2021_C3 = value;
                OnPropertyChanged(nameof(Kasim2021_C3));
            }
        }

        private int _kasim2021_C4;
        public int Kasim2021_C4
        {
            get { return _kasim2021_C4; }
            set
            {
                _kasim2021_C4 = value;
                OnPropertyChanged(nameof(Kasim2021_C4));
            }
        }

        private int _kasim2021_C5;
        public int Kasim2021_C5
        {
            get { return _kasim2021_C5; }
            set
            {
                _kasim2021_C5 = value;
                OnPropertyChanged(nameof(Kasim2021_C5));
            }
        }

        private int _kasim2021_C6;
        public int Kasim2021_C6
        {
            get { return _kasim2021_C6; }
            set
            {
                _kasim2021_C6 = value;
                OnPropertyChanged(nameof(Kasim2021_C6));
            }
        }
        private int _aralik2021_C1;
        public int Aralik2021_C1
        {
            get { return _aralik2021_C1; }
            set
            {
                _aralik2021_C1 = value;
                OnPropertyChanged(nameof(Aralik2021_C1));
            }
        }

        private int _aralik2021_C2;
        public int Aralik2021_C2
        {
            get { return _aralik2021_C2; }
            set
            {
                _aralik2021_C2 = value;
                OnPropertyChanged(nameof(Aralik2021_C2));
            }
        }

        private int _aralik2021_C3;
        public int Aralik2021_C3
        {
            get { return _aralik2021_C3; }
            set
            {
                _aralik2021_C3 = value;
                OnPropertyChanged(nameof(Aralik2021_C3));
            }
        }

        private int _aralik2021_C4;
        public int Aralik2021_C4
        {
            get { return _aralik2021_C4; }
            set
            {
                _aralik2021_C4 = value;
                OnPropertyChanged(nameof(Aralik2021_C4));
            }
        }

        private int _aralik2021_C5;
        public int Aralik2021_C5
        {
            get { return _aralik2021_C5; }
            set
            {
                _aralik2021_C5 = value;
                OnPropertyChanged(nameof(Aralik2021_C5));
            }
        }

        private int _aralik2021_C6;
        public int Aralik2021_C6
        {
            get { return _aralik2021_C6; }
            set
            {
                _aralik2021_C6 = value;
                OnPropertyChanged(nameof(Aralik2021_C6));
            }
        }
        #endregion

        #region IZIN 2022


        private int _ocak2022_C1;
        public int Ocak2022_C1
        {
            get { return _ocak2022_C1; }
            set
            {
                _ocak2022_C1 = value;
                OnPropertyChanged(nameof(Ocak2022_C1));
            }
        }

        private int _ocak2022_C2;
        public int Ocak2022_C2
        {
            get { return _ocak2022_C2; }
            set
            {
                _ocak2022_C2 = value;
                OnPropertyChanged(nameof(Ocak2022_C2));
            }
        }

        private int _ocak2022_C3;
        public int Ocak2022_C3
        {
            get { return _ocak2022_C3; }
            set
            {
                _ocak2022_C3 = value;
                OnPropertyChanged(nameof(Ocak2022_C3));
            }
        }

        private int _ocak2022_C4;
        public int Ocak2022_C4
        {
            get { return _ocak2022_C4; }
            set
            {
                _ocak2022_C4 = value;
                OnPropertyChanged(nameof(Ocak2022_C4));
            }
        }

        private int _ocak2022_C5;
        public int Ocak2022_C5
        {
            get { return _ocak2022_C5; }
            set
            {
                _ocak2022_C5 = value;
                OnPropertyChanged(nameof(Ocak2022_C5));
            }
        }

        private int _ocak2022_C6;
        public int Ocak2022_C6
        {
            get { return _ocak2022_C6; }
            set
            {
                _ocak2022_C6 = value;
                OnPropertyChanged(nameof(Ocak2022_C6));
            }
        }

        private int _subat2022_C1;
        public int Subat2022_C1
        {
            get { return _subat2022_C1; }
            set
            {
                _subat2022_C1 = value;
                OnPropertyChanged(nameof(Subat2022_C1));
            }
        }

        private int _subat2022_C2;
        public int Subat2022_C2
        {
            get { return _subat2022_C2; }
            set
            {
                _subat2022_C2 = value;
                OnPropertyChanged(nameof(Subat2022_C2));
            }
        }

        private int _subat2022_C3;
        public int Subat2022_C3
        {
            get { return _subat2022_C3; }
            set
            {
                _subat2022_C3 = value;
                OnPropertyChanged(nameof(Subat2022_C3));
            }
        }

        private int _subat2022_C4;
        public int Subat2022_C4
        {
            get { return _subat2022_C4; }
            set
            {
                _subat2022_C4 = value;
                OnPropertyChanged(nameof(Subat2022_C4));
            }
        }

        private int _subat2022_C5;
        public int Subat2022_C5
        {
            get { return _subat2022_C5; }
            set
            {
                _subat2022_C5 = value;
                OnPropertyChanged(nameof(Subat2022_C5));
            }
        }

        private int _subat2022_C6;
        public int Subat2022_C6
        {
            get { return _subat2022_C6; }
            set
            {
                _subat2022_C6 = value;
                OnPropertyChanged(nameof(Subat2022_C6));
            }
        }

        private int _mart2022_C1;
        public int Mart2022_C1
        {
            get { return _mart2022_C1; }
            set
            {
                _mart2022_C1 = value;
                OnPropertyChanged(nameof(Mart2022_C1));
            }
        }

        private int _mart2022_C2;
        public int Mart2022_C2
        {
            get { return _mart2022_C2; }
            set
            {
                _mart2022_C2 = value;
                OnPropertyChanged(nameof(Mart2022_C2));
            }
        }

        private int _mart2022_C3;
        public int Mart2022_C3
        {
            get { return _mart2022_C3; }
            set
            {
                _mart2022_C3 = value;
                OnPropertyChanged(nameof(Mart2022_C3));
            }
        }

        private int _mart2022_C4;
        public int Mart2022_C4
        {
            get { return _mart2022_C4; }
            set
            {
                _mart2022_C4 = value;
                OnPropertyChanged(nameof(Mart2022_C4));
            }
        }

        private int _mart2022_C5;
        public int Mart2022_C5
        {
            get { return _mart2022_C5; }
            set
            {
                _mart2022_C5 = value;
                OnPropertyChanged(nameof(Mart2022_C5));
            }
        }

        private int _mart2022_C6;
        public int Mart2022_C6
        {
            get { return _mart2022_C6; }
            set
            {
                _mart2022_C6 = value;
                OnPropertyChanged(nameof(Mart2022_C6));
            }
        }
        private int _nisan2022_C1;
        public int Nisan2022_C1
        {
            get { return _nisan2022_C1; }
            set
            {
                _nisan2022_C1 = value;
                OnPropertyChanged(nameof(Nisan2022_C1));
            }
        }

        private int _nisan2022_C2;
        public int Nisan2022_C2
        {
            get { return _nisan2022_C2; }
            set
            {
                _nisan2022_C2 = value;
                OnPropertyChanged(nameof(Nisan2022_C2));
            }
        }

        private int _nisan2022_C3;
        public int Nisan2022_C3
        {
            get { return _nisan2022_C3; }
            set
            {
                _nisan2022_C3 = value;
                OnPropertyChanged(nameof(Nisan2022_C3));
            }
        }

        private int _nisan2022_C4;
        public int Nisan2022_C4
        {
            get { return _nisan2022_C4; }
            set
            {
                _nisan2022_C4 = value;
                OnPropertyChanged(nameof(Nisan2022_C4));
            }
        }

        private int _nisan2022_C5;
        public int Nisan2022_C5
        {
            get { return _nisan2022_C5; }
            set
            {
                _nisan2022_C5 = value;
                OnPropertyChanged(nameof(Nisan2022_C5));
            }
        }

        private int _nisan2022_C6;
        public int Nisan2022_C6
        {
            get { return _nisan2022_C6; }
            set
            {
                _nisan2022_C6 = value;
                OnPropertyChanged(nameof(Nisan2022_C6));
            }
        }

        private int _mayis2022_C1;
        public int Mayis2022_C1
        {
            get { return _mayis2022_C1; }
            set
            {
                _mayis2022_C1 = value;
                OnPropertyChanged(nameof(Mayis2022_C1));
            }
        }

        private int _mayis2022_C2;
        public int Mayis2022_C2
        {
            get { return _mayis2022_C2; }
            set
            {
                _mayis2022_C2 = value;
                OnPropertyChanged(nameof(Mayis2022_C2));
            }
        }

        private int _mayis2022_C3;
        public int Mayis2022_C3
        {
            get { return _mayis2022_C3; }
            set
            {
                _mayis2022_C3 = value;
                OnPropertyChanged(nameof(Mayis2022_C3));
            }
        }

        private int _mayis2022_C4;
        public int Mayis2022_C4
        {
            get { return _mayis2022_C4; }
            set
            {
                _mayis2022_C4 = value;
                OnPropertyChanged(nameof(Mayis2022_C4));
            }
        }

        private int _mayis2022_C5;
        public int Mayis2022_C5
        {
            get { return _mayis2022_C5; }
            set
            {
                _mayis2022_C5 = value;
                OnPropertyChanged(nameof(Mayis2022_C5));
            }
        }

        private int _mayis2022_C6;
        public int Mayis2022_C6
        {
            get { return _mayis2022_C6; }
            set
            {
                _mayis2022_C6 = value;
                OnPropertyChanged(nameof(Mayis2022_C6));
            }
        }

        private int _haziran2022_C1;
        public int Haziran2022_C1
        {
            get { return _haziran2022_C1; }
            set
            {
                _haziran2022_C1 = value;
                OnPropertyChanged(nameof(Haziran2022_C1));
            }
        }

        private int _haziran2022_C2;
        public int Haziran2022_C2
        {
            get { return _haziran2022_C2; }
            set
            {
                _haziran2022_C2 = value;
                OnPropertyChanged(nameof(Haziran2022_C2));
            }
        }

        private int _haziran2022_C3;
        public int Haziran2022_C3
        {
            get { return _haziran2022_C3; }
            set
            {
                _haziran2022_C3 = value;
                OnPropertyChanged(nameof(Haziran2022_C3));
            }
        }

        private int _haziran2022_C4;
        public int Haziran2022_C4
        {
            get { return _haziran2022_C4; }
            set
            {
                _haziran2022_C4 = value;
                OnPropertyChanged(nameof(Haziran2022_C4));
            }
        }

        private int _haziran2022_C5;
        public int Haziran2022_C5
        {
            get { return _haziran2022_C5; }
            set
            {
                _haziran2022_C5 = value;
                OnPropertyChanged(nameof(Haziran2022_C5));
            }
        }

        private int _haziran2022_C6;
        public int Haziran2022_C6
        {
            get { return _haziran2022_C6; }
            set
            {
                _haziran2022_C6 = value;
                OnPropertyChanged(nameof(Haziran2022_C6));
            }
        }

        private int _temmuz2022_C1;
        public int Temmuz2022_C1
        {
            get { return _temmuz2022_C1; }
            set
            {
                _temmuz2022_C1 = value;
                OnPropertyChanged(nameof(Temmuz2022_C1));
            }
        }

        private int _temmuz2022_C2;
        public int Temmuz2022_C2
        {
            get { return _temmuz2022_C2; }
            set
            {
                _temmuz2022_C2 = value;
                OnPropertyChanged(nameof(Temmuz2022_C2));
            }
        }

        private int _temmuz2022_C3;
        public int Temmuz2022_C3
        {
            get { return _temmuz2022_C3; }
            set
            {
                _temmuz2022_C3 = value;
                OnPropertyChanged(nameof(Temmuz2022_C3));
            }
        }

        private int _temmuz2022_C4;
        public int Temmuz2022_C4
        {
            get { return _temmuz2022_C4; }
            set
            {
                _temmuz2022_C4 = value;
                OnPropertyChanged(nameof(Temmuz2022_C4));
            }
        }

        private int _temmuz2022_C5;
        public int Temmuz2022_C5
        {
            get { return _temmuz2022_C5; }
            set
            {
                _temmuz2022_C5 = value;
                OnPropertyChanged(nameof(Temmuz2022_C5));
            }
        }

        private int _temmuz2022_C6;
        public int Temmuz2022_C6
        {
            get { return _temmuz2022_C6; }
            set
            {
                _temmuz2022_C6 = value;
                OnPropertyChanged(nameof(Temmuz2022_C6));
            }
        }

        private int _agustos2022_C1;
        public int Agustos2022_C1
        {
            get { return _agustos2022_C1; }
            set
            {
                _agustos2022_C1 = value;
                OnPropertyChanged(nameof(Agustos2022_C1));
            }
        }

        private int _agustos2022_C2;
        public int Agustos2022_C2
        {
            get { return _agustos2022_C2; }
            set
            {
                _agustos2022_C2 = value;
                OnPropertyChanged(nameof(Agustos2022_C2));
            }
        }

        private int _agustos2022_C3;
        public int Agustos2022_C3
        {
            get { return _agustos2022_C3; }
            set
            {
                _agustos2022_C3 = value;
                OnPropertyChanged(nameof(Agustos2022_C3));
            }
        }

        private int _agustos2022_C4;
        public int Agustos2022_C4
        {
            get { return _agustos2022_C4; }
            set
            {
                _agustos2022_C4 = value;
                OnPropertyChanged(nameof(Agustos2022_C4));
            }
        }

        private int _agustos2022_C5;
        public int Agustos2022_C5
        {
            get { return _agustos2022_C5; }
            set
            {
                _agustos2022_C5 = value;
                OnPropertyChanged(nameof(Agustos2022_C5));
            }
        }

        private int _agustos2022_C6;
        public int Agustos2022_C6
        {
            get { return _agustos2022_C6; }
            set
            {
                _agustos2022_C6 = value;
                OnPropertyChanged(nameof(Agustos2022_C6));
            }
        }

        private int _eylul2022_C1;
        public int Eylul2022_C1
        {
            get { return _eylul2022_C1; }
            set
            {
                _eylul2022_C1 = value;
                OnPropertyChanged(nameof(Eylul2022_C1));
            }
        }

        private int _eylul2022_C2;
        public int Eylul2022_C2
        {
            get { return _eylul2022_C2; }
            set
            {
                _eylul2022_C2 = value;
                OnPropertyChanged(nameof(Eylul2022_C2));
            }
        }

        private int _eylul2022_C3;
        public int Eylul2022_C3
        {
            get { return _eylul2022_C3; }
            set
            {
                _eylul2022_C3 = value;
                OnPropertyChanged(nameof(Eylul2022_C3));
            }
        }

        private int _eylul2022_C4;
        public int Eylul2022_C4
        {
            get { return _eylul2022_C4; }
            set
            {
                _eylul2022_C4 = value;
                OnPropertyChanged(nameof(Eylul2022_C4));
            }
        }

        private int _eylul2022_C5;
        public int Eylul2022_C5
        {
            get { return _eylul2022_C5; }
            set
            {
                _eylul2022_C5 = value;
                OnPropertyChanged(nameof(Eylul2022_C5));
            }
        }

        private int _eylul2022_C6;
        public int Eylul2022_C6
        {
            get { return _eylul2022_C6; }
            set
            {
                _eylul2022_C6 = value;
                OnPropertyChanged(nameof(Eylul2022_C6));
            }
        }

        private int _ekim2022_C1;
        public int Ekim2022_C1
        {
            get { return _ekim2022_C1; }
            set
            {
                _ekim2022_C1 = value;
                OnPropertyChanged(nameof(Ekim2022_C1));
            }
        }

        private int _ekim2022_C2;
        public int Ekim2022_C2
        {
            get { return _ekim2022_C2; }
            set
            {
                _ekim2022_C2 = value;
                OnPropertyChanged(nameof(Ekim2022_C2));
            }
        }

        private int _ekim2022_C3;
        public int Ekim2022_C3
        {
            get { return _ekim2022_C3; }
            set
            {
                _ekim2022_C3 = value;
                OnPropertyChanged(nameof(Ekim2022_C3));
            }
        }

        private int _ekim2022_C4;
        public int Ekim2022_C4
        {
            get { return _ekim2022_C4; }
            set
            {
                _ekim2022_C4 = value;
                OnPropertyChanged(nameof(Ekim2022_C4));
            }
        }

        private int _ekim2022_C5;
        public int Ekim2022_C5
        {
            get { return _ekim2022_C5; }
            set
            {
                _ekim2022_C5 = value;
                OnPropertyChanged(nameof(Ekim2022_C5));
            }
        }

        private int _ekim2022_C6;
        public int Ekim2022_C6
        {
            get { return _ekim2022_C6; }
            set
            {
                _ekim2022_C6 = value;
                OnPropertyChanged(nameof(Ekim2022_C6));
            }
        }

        private int _kasim2022_C1;
        public int Kasim2022_C1
        {
            get { return _kasim2022_C1; }
            set
            {
                _kasim2022_C1 = value;
                OnPropertyChanged(nameof(Kasim2022_C1));
            }
        }

        private int _kasim2022_C2;
        public int Kasim2022_C2
        {
            get { return _kasim2022_C2; }
            set
            {
                _kasim2022_C2 = value;
                OnPropertyChanged(nameof(Kasim2022_C2));
            }
        }

        private int _kasim2022_C3;
        public int Kasim2022_C3
        {
            get { return _kasim2022_C3; }
            set
            {
                _kasim2022_C3 = value;
                OnPropertyChanged(nameof(Kasim2022_C3));
            }
        }

        private int _kasim2022_C4;
        public int Kasim2022_C4
        {
            get { return _kasim2022_C4; }
            set
            {
                _kasim2022_C4 = value;
                OnPropertyChanged(nameof(Kasim2022_C4));
            }
        }

        private int _kasim2022_C5;
        public int Kasim2022_C5
        {
            get { return _kasim2022_C5; }
            set
            {
                _kasim2022_C5 = value;
                OnPropertyChanged(nameof(Kasim2022_C5));
            }
        }

        private int _kasim2022_C6;
        public int Kasim2022_C6
        {
            get { return _kasim2022_C6; }
            set
            {
                _kasim2022_C6 = value;
                OnPropertyChanged(nameof(Kasim2022_C6));
            }
        }
        private int _aralik2022_C1;
        public int Aralik2022_C1
        {
            get { return _aralik2022_C1; }
            set
            {
                _aralik2022_C1 = value;
                OnPropertyChanged(nameof(Aralik2022_C1));
            }
        }

        private int _aralik2022_C2;
        public int Aralik2022_C2
        {
            get { return _aralik2022_C2; }
            set
            {
                _aralik2022_C2 = value;
                OnPropertyChanged(nameof(Aralik2022_C2));
            }
        }

        private int _aralik2022_C3;
        public int Aralik2022_C3
        {
            get { return _aralik2022_C3; }
            set
            {
                _aralik2022_C3 = value;
                OnPropertyChanged(nameof(Aralik2022_C3));
            }
        }

        private int _aralik2022_C4;
        public int Aralik2022_C4
        {
            get { return _aralik2022_C4; }
            set
            {
                _aralik2022_C4 = value;
                OnPropertyChanged(nameof(Aralik2022_C4));
            }
        }

        private int _aralik2022_C5;
        public int Aralik2022_C5
        {
            get { return _aralik2022_C5; }
            set
            {
                _aralik2022_C5 = value;
                OnPropertyChanged(nameof(Aralik2022_C5));
            }
        }

        private int _aralik2022_C6;
        public int Aralik2022_C6
        {
            get { return _aralik2022_C6; }
            set
            {
                _aralik2022_C6 = value;
                OnPropertyChanged(nameof(Aralik2022_C6));
            }
        }
        #endregion

        #region IZIN 2023


        private int _ocak2023_C1;
        public int Ocak2023_C1
        {
            get { return _ocak2023_C1; }
            set
            {
                _ocak2023_C1 = value;
                OnPropertyChanged(nameof(Ocak2023_C1));
            }
        }

        private int _ocak2023_C2;
        public int Ocak2023_C2
        {
            get { return _ocak2023_C2; }
            set
            {
                _ocak2023_C2 = value;
                OnPropertyChanged(nameof(Ocak2023_C2));
            }
        }

        private int _ocak2023_C3;
        public int Ocak2023_C3
        {
            get { return _ocak2023_C3; }
            set
            {
                _ocak2023_C3 = value;
                OnPropertyChanged(nameof(Ocak2023_C3));
            }
        }

        private int _ocak2023_C4;
        public int Ocak2023_C4
        {
            get { return _ocak2023_C4; }
            set
            {
                _ocak2023_C4 = value;
                OnPropertyChanged(nameof(Ocak2023_C4));
            }
        }

        private int _ocak2023_C5;
        public int Ocak2023_C5
        {
            get { return _ocak2023_C5; }
            set
            {
                _ocak2023_C5 = value;
                OnPropertyChanged(nameof(Ocak2023_C5));
            }
        }

        private int _ocak2023_C6;
        public int Ocak2023_C6
        {
            get { return _ocak2023_C6; }
            set
            {
                _ocak2023_C6 = value;
                OnPropertyChanged(nameof(Ocak2023_C6));
            }
        }

        private int _subat2023_C1;
        public int Subat2023_C1
        {
            get { return _subat2023_C1; }
            set
            {
                _subat2023_C1 = value;
                OnPropertyChanged(nameof(Subat2023_C1));
            }
        }

        private int _subat2023_C2;
        public int Subat2023_C2
        {
            get { return _subat2023_C2; }
            set
            {
                _subat2023_C2 = value;
                OnPropertyChanged(nameof(Subat2023_C2));
            }
        }

        private int _subat2023_C3;
        public int Subat2023_C3
        {
            get { return _subat2023_C3; }
            set
            {
                _subat2023_C3 = value;
                OnPropertyChanged(nameof(Subat2023_C3));
            }
        }

        private int _subat2023_C4;
        public int Subat2023_C4
        {
            get { return _subat2023_C4; }
            set
            {
                _subat2023_C4 = value;
                OnPropertyChanged(nameof(Subat2023_C4));
            }
        }

        private int _subat2023_C5;
        public int Subat2023_C5
        {
            get { return _subat2023_C5; }
            set
            {
                _subat2023_C5 = value;
                OnPropertyChanged(nameof(Subat2023_C5));
            }
        }

        private int _subat2023_C6;
        public int Subat2023_C6
        {
            get { return _subat2023_C6; }
            set
            {
                _subat2023_C6 = value;
                OnPropertyChanged(nameof(Subat2023_C6));
            }
        }

        private int _mart2023_C1;
        public int Mart2023_C1
        {
            get { return _mart2023_C1; }
            set
            {
                _mart2023_C1 = value;
                OnPropertyChanged(nameof(Mart2023_C1));
            }
        }

        private int _mart2023_C2;
        public int Mart2023_C2
        {
            get { return _mart2023_C2; }
            set
            {
                _mart2023_C2 = value;
                OnPropertyChanged(nameof(Mart2023_C2));
            }
        }

        private int _mart2023_C3;
        public int Mart2023_C3
        {
            get { return _mart2023_C3; }
            set
            {
                _mart2023_C3 = value;
                OnPropertyChanged(nameof(Mart2023_C3));
            }
        }

        private int _mart2023_C4;
        public int Mart2023_C4
        {
            get { return _mart2023_C4; }
            set
            {
                _mart2023_C4 = value;
                OnPropertyChanged(nameof(Mart2023_C4));
            }
        }

        private int _mart2023_C5;
        public int Mart2023_C5
        {
            get { return _mart2023_C5; }
            set
            {
                _mart2023_C5 = value;
                OnPropertyChanged(nameof(Mart2023_C5));
            }
        }

        private int _mart2023_C6;
        public int Mart2023_C6
        {
            get { return _mart2023_C6; }
            set
            {
                _mart2023_C6 = value;
                OnPropertyChanged(nameof(Mart2023_C6));
            }
        }
        private int _nisan2023_C1;
        public int Nisan2023_C1
        {
            get { return _nisan2023_C1; }
            set
            {
                _nisan2023_C1 = value;
                OnPropertyChanged(nameof(Nisan2023_C1));
            }
        }

        private int _nisan2023_C2;
        public int Nisan2023_C2
        {
            get { return _nisan2023_C2; }
            set
            {
                _nisan2023_C2 = value;
                OnPropertyChanged(nameof(Nisan2023_C2));
            }
        }

        private int _nisan2023_C3;
        public int Nisan2023_C3
        {
            get { return _nisan2023_C3; }
            set
            {
                _nisan2023_C3 = value;
                OnPropertyChanged(nameof(Nisan2023_C3));
            }
        }

        private int _nisan2023_C4;
        public int Nisan2023_C4
        {
            get { return _nisan2023_C4; }
            set
            {
                _nisan2023_C4 = value;
                OnPropertyChanged(nameof(Nisan2023_C4));
            }
        }

        private int _nisan2023_C5;
        public int Nisan2023_C5
        {
            get { return _nisan2023_C5; }
            set
            {
                _nisan2023_C5 = value;
                OnPropertyChanged(nameof(Nisan2023_C5));
            }
        }

        private int _nisan2023_C6;
        public int Nisan2023_C6
        {
            get { return _nisan2023_C6; }
            set
            {
                _nisan2023_C6 = value;
                OnPropertyChanged(nameof(Nisan2023_C6));
            }
        }

        private int _mayis2023_C1;
        public int Mayis2023_C1
        {
            get { return _mayis2023_C1; }
            set
            {
                _mayis2023_C1 = value;
                OnPropertyChanged(nameof(Mayis2023_C1));
            }
        }

        private int _mayis2023_C2;
        public int Mayis2023_C2
        {
            get { return _mayis2023_C2; }
            set
            {
                _mayis2023_C2 = value;
                OnPropertyChanged(nameof(Mayis2023_C2));
            }
        }

        private int _mayis2023_C3;
        public int Mayis2023_C3
        {
            get { return _mayis2023_C3; }
            set
            {
                _mayis2023_C3 = value;
                OnPropertyChanged(nameof(Mayis2023_C3));
            }
        }

        private int _mayis2023_C4;
        public int Mayis2023_C4
        {
            get { return _mayis2023_C4; }
            set
            {
                _mayis2023_C4 = value;
                OnPropertyChanged(nameof(Mayis2023_C4));
            }
        }

        private int _mayis2023_C5;
        public int Mayis2023_C5
        {
            get { return _mayis2023_C5; }
            set
            {
                _mayis2023_C5 = value;
                OnPropertyChanged(nameof(Mayis2023_C5));
            }
        }

        private int _mayis2023_C6;
        public int Mayis2023_C6
        {
            get { return _mayis2023_C6; }
            set
            {
                _mayis2023_C6 = value;
                OnPropertyChanged(nameof(Mayis2023_C6));
            }
        }

        private int _haziran2023_C1;
        public int Haziran2023_C1
        {
            get { return _haziran2023_C1; }
            set
            {
                _haziran2023_C1 = value;
                OnPropertyChanged(nameof(Haziran2023_C1));
            }
        }

        private int _haziran2023_C2;
        public int Haziran2023_C2
        {
            get { return _haziran2023_C2; }
            set
            {
                _haziran2023_C2 = value;
                OnPropertyChanged(nameof(Haziran2023_C2));
            }
        }

        private int _haziran2023_C3;
        public int Haziran2023_C3
        {
            get { return _haziran2023_C3; }
            set
            {
                _haziran2023_C3 = value;
                OnPropertyChanged(nameof(Haziran2023_C3));
            }
        }

        private int _haziran2023_C4;
        public int Haziran2023_C4
        {
            get { return _haziran2023_C4; }
            set
            {
                _haziran2023_C4 = value;
                OnPropertyChanged(nameof(Haziran2023_C4));
            }
        }

        private int _haziran2023_C5;
        public int Haziran2023_C5
        {
            get { return _haziran2023_C5; }
            set
            {
                _haziran2023_C5 = value;
                OnPropertyChanged(nameof(Haziran2023_C5));
            }
        }

        private int _haziran2023_C6;
        public int Haziran2023_C6
        {
            get { return _haziran2023_C6; }
            set
            {
                _haziran2023_C6 = value;
                OnPropertyChanged(nameof(Haziran2023_C6));
            }
        }

        private int _temmuz2023_C1;
        public int Temmuz2023_C1
        {
            get { return _temmuz2023_C1; }
            set
            {
                _temmuz2023_C1 = value;
                OnPropertyChanged(nameof(Temmuz2023_C1));
            }
        }

        private int _temmuz2023_C2;
        public int Temmuz2023_C2
        {
            get { return _temmuz2023_C2; }
            set
            {
                _temmuz2023_C2 = value;
                OnPropertyChanged(nameof(Temmuz2023_C2));
            }
        }

        private int _temmuz2023_C3;
        public int Temmuz2023_C3
        {
            get { return _temmuz2023_C3; }
            set
            {
                _temmuz2023_C3 = value;
                OnPropertyChanged(nameof(Temmuz2023_C3));
            }
        }

        private int _temmuz2023_C4;
        public int Temmuz2023_C4
        {
            get { return _temmuz2023_C4; }
            set
            {
                _temmuz2023_C4 = value;
                OnPropertyChanged(nameof(Temmuz2023_C4));
            }
        }

        private int _temmuz2023_C5;
        public int Temmuz2023_C5
        {
            get { return _temmuz2023_C5; }
            set
            {
                _temmuz2023_C5 = value;
                OnPropertyChanged(nameof(Temmuz2023_C5));
            }
        }

        private int _temmuz2023_C6;
        public int Temmuz2023_C6
        {
            get { return _temmuz2023_C6; }
            set
            {
                _temmuz2023_C6 = value;
                OnPropertyChanged(nameof(Temmuz2023_C6));
            }
        }

        private int _agustos2023_C1;
        public int Agustos2023_C1
        {
            get { return _agustos2023_C1; }
            set
            {
                _agustos2023_C1 = value;
                OnPropertyChanged(nameof(Agustos2023_C1));
            }
        }

        private int _agustos2023_C2;
        public int Agustos2023_C2
        {
            get { return _agustos2023_C2; }
            set
            {
                _agustos2023_C2 = value;
                OnPropertyChanged(nameof(Agustos2023_C2));
            }
        }

        private int _agustos2023_C3;
        public int Agustos2023_C3
        {
            get { return _agustos2023_C3; }
            set
            {
                _agustos2023_C3 = value;
                OnPropertyChanged(nameof(Agustos2023_C3));
            }
        }

        private int _agustos2023_C4;
        public int Agustos2023_C4
        {
            get { return _agustos2023_C4; }
            set
            {
                _agustos2023_C4 = value;
                OnPropertyChanged(nameof(Agustos2023_C4));
            }
        }

        private int _agustos2023_C5;
        public int Agustos2023_C5
        {
            get { return _agustos2023_C5; }
            set
            {
                _agustos2023_C5 = value;
                OnPropertyChanged(nameof(Agustos2023_C5));
            }
        }

        private int _agustos2023_C6;
        public int Agustos2023_C6
        {
            get { return _agustos2023_C6; }
            set
            {
                _agustos2023_C6 = value;
                OnPropertyChanged(nameof(Agustos2023_C6));
            }
        }

        private int _eylul2023_C1;
        public int Eylul2023_C1
        {
            get { return _eylul2023_C1; }
            set
            {
                _eylul2023_C1 = value;
                OnPropertyChanged(nameof(Eylul2023_C1));
            }
        }

        private int _eylul2023_C2;
        public int Eylul2023_C2
        {
            get { return _eylul2023_C2; }
            set
            {
                _eylul2023_C2 = value;
                OnPropertyChanged(nameof(Eylul2023_C2));
            }
        }

        private int _eylul2023_C3;
        public int Eylul2023_C3
        {
            get { return _eylul2023_C3; }
            set
            {
                _eylul2023_C3 = value;
                OnPropertyChanged(nameof(Eylul2023_C3));
            }
        }

        private int _eylul2023_C4;
        public int Eylul2023_C4
        {
            get { return _eylul2023_C4; }
            set
            {
                _eylul2023_C4 = value;
                OnPropertyChanged(nameof(Eylul2023_C4));
            }
        }

        private int _eylul2023_C5;
        public int Eylul2023_C5
        {
            get { return _eylul2023_C5; }
            set
            {
                _eylul2023_C5 = value;
                OnPropertyChanged(nameof(Eylul2023_C5));
            }
        }

        private int _eylul2023_C6;
        public int Eylul2023_C6
        {
            get { return _eylul2023_C6; }
            set
            {
                _eylul2023_C6 = value;
                OnPropertyChanged(nameof(Eylul2023_C6));
            }
        }

        private int _ekim2023_C1;
        public int Ekim2023_C1
        {
            get { return _ekim2023_C1; }
            set
            {
                _ekim2023_C1 = value;
                OnPropertyChanged(nameof(Ekim2023_C1));
            }
        }

        private int _ekim2023_C2;
        public int Ekim2023_C2
        {
            get { return _ekim2023_C2; }
            set
            {
                _ekim2023_C2 = value;
                OnPropertyChanged(nameof(Ekim2023_C2));
            }
        }

        private int _ekim2023_C3;
        public int Ekim2023_C3
        {
            get { return _ekim2023_C3; }
            set
            {
                _ekim2023_C3 = value;
                OnPropertyChanged(nameof(Ekim2023_C3));
            }
        }

        private int _ekim2023_C4;
        public int Ekim2023_C4
        {
            get { return _ekim2023_C4; }
            set
            {
                _ekim2023_C4 = value;
                OnPropertyChanged(nameof(Ekim2023_C4));
            }
        }

        private int _ekim2023_C5;
        public int Ekim2023_C5
        {
            get { return _ekim2023_C5; }
            set
            {
                _ekim2023_C5 = value;
                OnPropertyChanged(nameof(Ekim2023_C5));
            }
        }

        private int _ekim2023_C6;
        public int Ekim2023_C6
        {
            get { return _ekim2023_C6; }
            set
            {
                _ekim2023_C6 = value;
                OnPropertyChanged(nameof(Ekim2023_C6));
            }
        }

        private int _kasim2023_C1;
        public int Kasim2023_C1
        {
            get { return _kasim2023_C1; }
            set
            {
                _kasim2023_C1 = value;
                OnPropertyChanged(nameof(Kasim2023_C1));
            }
        }

        private int _kasim2023_C2;
        public int Kasim2023_C2
        {
            get { return _kasim2023_C2; }
            set
            {
                _kasim2023_C2 = value;
                OnPropertyChanged(nameof(Kasim2023_C2));
            }
        }

        private int _kasim2023_C3;
        public int Kasim2023_C3
        {
            get { return _kasim2023_C3; }
            set
            {
                _kasim2023_C3 = value;
                OnPropertyChanged(nameof(Kasim2023_C3));
            }
        }

        private int _kasim2023_C4;
        public int Kasim2023_C4
        {
            get { return _kasim2023_C4; }
            set
            {
                _kasim2023_C4 = value;
                OnPropertyChanged(nameof(Kasim2023_C4));
            }
        }

        private int _kasim2023_C5;
        public int Kasim2023_C5
        {
            get { return _kasim2023_C5; }
            set
            {
                _kasim2023_C5 = value;
                OnPropertyChanged(nameof(Kasim2023_C5));
            }
        }

        private int _kasim2023_C6;
        public int Kasim2023_C6
        {
            get { return _kasim2023_C6; }
            set
            {
                _kasim2023_C6 = value;
                OnPropertyChanged(nameof(Kasim2023_C6));
            }
        }
        private int _aralik2023_C1;
        public int Aralik2023_C1
        {
            get { return _aralik2023_C1; }
            set
            {
                _aralik2023_C1 = value;
                OnPropertyChanged(nameof(Aralik2023_C1));
            }
        }

        private int _aralik2023_C2;
        public int Aralik2023_C2
        {
            get { return _aralik2023_C2; }
            set
            {
                _aralik2023_C2 = value;
                OnPropertyChanged(nameof(Aralik2023_C2));
            }
        }

        private int _aralik2023_C3;
        public int Aralik2023_C3
        {
            get { return _aralik2023_C3; }
            set
            {
                _aralik2023_C3 = value;
                OnPropertyChanged(nameof(Aralik2023_C3));
            }
        }

        private int _aralik2023_C4;
        public int Aralik2023_C4
        {
            get { return _aralik2023_C4; }
            set
            {
                _aralik2023_C4 = value;
                OnPropertyChanged(nameof(Aralik2023_C4));
            }
        }

        private int _aralik2023_C5;
        public int Aralik2023_C5
        {
            get { return _aralik2023_C5; }
            set
            {
                _aralik2023_C5 = value;
                OnPropertyChanged(nameof(Aralik2023_C5));
            }
        }

        private int _aralik2023_C6;
        public int Aralik2023_C6
        {
            get { return _aralik2023_C6; }
            set
            {
                _aralik2023_C6 = value;
                OnPropertyChanged(nameof(Aralik2023_C6));
            }
        }
        #endregion


        readonly DepartmentStore _departmentStore;

        readonly ObservableCollection<DepartmentListingItemViewModel> _departmentListingItemViewModels;

        public IEnumerable<DepartmentListingItemViewModel> DepartmentListingItemViewModels => _departmentListingItemViewModels;


        private DepartmentListingItemViewModel _selectedItem;

        public DepartmentListingItemViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                    _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        private int _selectedIndex;

        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }







        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public bool CanSubmit => !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public static RelayCommand UploadPhotoCommand { get; set; }

        public ICommand LoadDepartmentsCommand { get; set; }




        public EmployeeDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand, DepartmentStore departmentStore)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
            _departmentStore = departmentStore;


            _departmentListingItemViewModels = new ObservableCollection<DepartmentListingItemViewModel>();


            LoadDepartmentsCommand = new LoadDepartmentsCommand(departmentStore);

            _departmentStore.DepartmentsLoaded += DepartmentStore_DepartmentsLoaded;


            RegisterCommands();
        }



        protected override void Dispose()
        {
            _departmentStore.DepartmentsLoaded -= DepartmentStore_DepartmentsLoaded;
        }
        private void DepartmentStore_DepartmentsLoaded()
        {
            _departmentListingItemViewModels.Clear();
            foreach (Department department in _departmentStore.Departments)
            {
                AddDepartment(department);
            }
        }

        private void AddDepartment(Department department)
        {
            DepartmentListingItemViewModel itemViewModel = new DepartmentListingItemViewModel(department);

            _departmentListingItemViewModels.Add(itemViewModel);
        }

        public static EmployeeDetailsFormViewModel LoadDepartmentVM(ICommand submitCommand, ICommand cancelCommand, DepartmentStore departmentStore)
        {

            EmployeeDetailsFormViewModel viewModel = new EmployeeDetailsFormViewModel(submitCommand, cancelCommand, departmentStore);

            viewModel.LoadDepartmentsCommand.Execute(null);

            return viewModel;
        }

        private void RegisterCommands()
        {
            UploadPhotoCommand = new RelayCommand(ExecuteOpenFileDialog);
        }

        private void ExecuteOpenFileDialog()
        {
            var dialog = new OpenFileDialog();

            dialog.Filter = "Choose Image(*.JPG;*.PNG;*.bmp);*.BMP|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == true)
            {
                PhotoSource = dialog.FileName;
            }
        }




    }
}


