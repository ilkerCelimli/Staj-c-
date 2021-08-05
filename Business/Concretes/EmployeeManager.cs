﻿using System;
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
       private readonly EfEmployeeDal employeeDal = InstanceFactory.GetInstance<EfEmployeeDal>();

      


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

        public IResult UpdateEmployee(int id ,Employee employee)
        {
            try
            {
               Employee employeeDumy = employeeDal.Get(e => e.Id == id);

               employee.Id = employeeDumy.Id;

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
