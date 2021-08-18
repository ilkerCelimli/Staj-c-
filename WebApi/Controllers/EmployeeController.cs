using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Core.Result.Concrete;
using Entities.Concretes;
using Ninject;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeServices employee;

        public EmployeeController(IEmployeeServices employee)
        {
            this.employee = employee;
        }



        [HttpGet("/Employee/getall")]

        public IResult GetAll()
        {
            return employee.GetAll();
        }

        [HttpGet("/Employee/getById")]

        public IResult GetById(int id)
        {
            return employee.GetEmployee(id);
        }

        [HttpPost("/Employee/AddEmploye")]

        public IResult AddEmploye(Employee employee)
        {
            return this.employee.AddEmployee(employee);
        }

        [HttpPut("/Employee/updateEmployee")]
        public IResult UpdateEmployee(int id, Employee employee)
        {
            return this.employee.UpdateEmployee(id, employee);
            
        }

        [HttpDelete("/Employee/deleteEmployee")]
        public IResult DeleteEmployee(int id)
        {

            return employee.DeleteEmployee(id);
        }
    }
}
