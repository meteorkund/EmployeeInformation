using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.EF.DTOs
{
    public class Vacation2018DTO : BaseDTO
    {
        public int Id { get; set; }
        public int? Ocak2018_c1 { get; set; }
        public int? Ocak2018_c2 { get; set; }
        public int? Ocak2018_c3 { get; set; }
        public int? Ocak2018_c4 { get; set; }
        public int? Ocak2018_c5 { get; set; }
        public int? Ocak2018_c6 { get; set; }

        public EmployeeDTO EmployeeDTO { get; set; }
    }
}
