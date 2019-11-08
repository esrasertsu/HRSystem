using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRSystem.Application.Interfaces;
using HRSystem.Domain.Models;
using HRSystem.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IGetEmployeesService _getEmployeesService;

        public EmployeesController(IGetEmployeesService getEmployeesService)
        {
              _getEmployeesService = getEmployeesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            var employees = await _getEmployeesService.GetEmployees();
            
            if (!employees.Any())
            {
                return NoContent();
            }

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
