using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Result;
using Entities.Concretes;

namespace Business.Abstract
{
   public interface IEmployeeServices
    {

        IResult AddEmployee(Employee employee);
        IResult DeleteEmployee(int id);
        IResult UpdateEmployee(int id,Employee employee);
         IResult GetAll();
        IResult GetEmployee(int i );




    }
}
