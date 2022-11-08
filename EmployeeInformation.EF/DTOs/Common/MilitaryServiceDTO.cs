using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs.Common
{
    public class MilitaryServiceDTO
    {
        public int Id { get; set; }

        public string MilitaryStatus { get; set; }
        public ICollection<EmployeeDTO> EmployeeDTOs { get; set; }
    }
}
