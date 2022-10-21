﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.Domain.Commands
{
    public interface IDeleteEmployeeCommand
    {
        Task Execute(int id);
    }
}
