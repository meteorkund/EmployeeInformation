using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices
{
    public class MilitaryListingItemViewModel : ViewModelBase
    {
        public MilitaryServiceStatus Military { get; private set; }

        public int MilitaryServiceId => Military.Id;
        public string MilitaryStatus => Military.MilitaryStatus;

        public MilitaryListingItemViewModel(MilitaryServiceStatus military)
        {
            Military = military;
        }
    }
}
