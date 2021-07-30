using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace DataAcceses.EntityFramework
{
    public class EfEmployeeDal :EfdbContextBase<Employee,DbContext> , IEntity
    {
    }
}
