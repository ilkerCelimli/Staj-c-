using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Result;
using Core.Result.Concrete;
using Entities.Concretes;


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


        [HttpGet("/Emplooye/getall")]

        public IResult GetAll()
        {
            return employee.GetAll();
        }

    }
}
