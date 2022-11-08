using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs.Common
{
    public class MaritialDTO
    {
        public int Id { get; set; }

        public string MaritialStatus { get; set; }
        public ICollection<EmployeeDTO> EmployeeDTOs { get; set; }
    }
}
