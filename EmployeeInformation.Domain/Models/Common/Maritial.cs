using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Models.Common
{
    public class Maritial 
    {
        public Maritial(int id, string maritialStatus)
        {
            Id = id;
            MaritialStatus = maritialStatus;
        }

        public int Id { get; }
        public string MaritialStatus { get; }
    }
}
