using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
   public class EmployeeManager : IEmployeeServices
    {
        private EfEmployeeDal employeeDal;

        public EmployeeManager(EfEmployeeDal employeeDal)
        {
            this.employeeDal = employeeDal;
        }


        public IResult AddEmployee(Employee employee)
        {
            try
            {
                employeeDal.Add(employee);

                return new SuccesfulResult(true, "Eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");
            }
        }

        public IResult DeleteEmployee(int id)
        {
           employeeDal.Delete(employeeDal.Get(i => i.Id == id));

           return new SuccesfulResult(true, "Ekelndi");
        }

        public IResult UpdateEmployee(Employee employee)
        {
            try
            {
                employeeDal.Update(employee);

                return new SuccesfulResult(true, "Güncellendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult GetAll()
        {
            try
            {
                return new SuccesfulResultData<Employee>(employeeDal.GetAll().ToList());
            }
            catch (Exception e)
            {
                return null;

            }
        }

        public IResult GetEmployee(int id)
        {
            try
            {
                return new SuccesfulResultData<Employee>(employeeDal.Get(i => i.Id == id));
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }
    }
}
