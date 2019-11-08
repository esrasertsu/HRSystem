using HRSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Application.Interfaces
{
    public interface IGetEmployeesService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}

