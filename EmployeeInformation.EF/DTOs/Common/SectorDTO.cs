using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs.Common
{
    public class SectorDTO 
    {
        public int Id { get; set; }

        public string SectorName { get; set; }
        public ICollection<EmployeeDTO> EmployeeDTOs { get; set; }

    }
}
