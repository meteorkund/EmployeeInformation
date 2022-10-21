using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeDetailsFormViewModel : ViewModelBase
    {
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

        private string _departman;

        public string Departman
        {
            get { return _departman; }
            set
            {
                _departman = value;
                OnPropertyChanged(nameof(Departman));
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

        private string _photoSource ="/Assets/MemetAvatar.jpg";

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
            set { _isSubmitting = value;
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


        public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

        public bool CanSubmit => !string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand UploadPhotoCommand { get; }

        public EmployeeDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }



    }
}
