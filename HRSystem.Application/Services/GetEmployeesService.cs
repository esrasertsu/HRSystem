using HRSystem.Application.Interfaces;
using HRSystem.Domain.Models;
using HRSystem.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Application.Services
{
    public class GetEmployeesService : IGetEmployeesService
    {
        private readonly DataContext _context;

        public GetEmployeesService(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await _context.Employees.Include(x => x.Role).ToListAsync();
            return employees;
        }
    }
}
