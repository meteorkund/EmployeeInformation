using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs.Common
{
    public class EducationDTO
    {
        public int Id { get; set; }

        public string EducationStatus { get; set; }
        public ICollection<EmployeeDTO> EmployeeDTOs { get; set; }
    }
}
