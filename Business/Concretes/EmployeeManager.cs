using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
   public class EmployeeManager : IEmployeeServices
   {
       private readonly EfEmployeeDal employeeDal;

       public EmployeeManager(EfEmployeeDal efEmployee)
       {
           this.employeeDal = efEmployee;
       } 
      


        public IResult AddEmployee(Employee employee)
        {
            try
            {
                employeeDal.Add(employee);

                return new SuccesfulResult("eklendi");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");
            }
        }

        public IResult DeleteEmployee(int id)
        {
           employeeDal.Delete(employeeDal.Get(i => i.Id == id));

           return new SuccesfulResult("Eklendi");
        }

        public IResult UpdateEmployee(int id ,Employee employee)
        {
            try
            {
               Employee employeeDumy = employeeDal.Get(e => e.Id == id);

               employee.Id = employeeDumy.Id;

                employeeDal.Update(employee);

                return new SuccesfulResult( "Güncellendi");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
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
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

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
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }
    }
}
