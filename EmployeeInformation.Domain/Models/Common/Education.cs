using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Models.Common
{
    public class Education
    {
        public Education(int id, string educationDegree)
        {
            EducationDegree = educationDegree;
            Id = id;
        }

        public int Id { get; }
        public string EducationDegree { get; }
    }
}
