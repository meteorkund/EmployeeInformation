using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MaritialStat;

public class MaritialStatusListingItemViewModel :ViewModelBase
{
    public Maritial MaritialStatus { get; private set; }

    public int MaritialStatusId => MaritialStatus.Id;
    public string MaritialStatusName => MaritialStatus.MaritialStatus;

    public MaritialStatusListingItemViewModel(Maritial maritialStatus)
    {
        MaritialStatus = maritialStatus;
    }
}
