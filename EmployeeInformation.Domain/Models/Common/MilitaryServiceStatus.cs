using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Models.Common;

public class MilitaryServiceStatus
{
    public MilitaryServiceStatus(int id, string militaryStatus)
    {
        Id = id;
        MilitaryStatus = militaryStatus;
    }

    public int Id { get; }
    public string MilitaryStatus { get; }
}
