using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Repository.EntityFramework
{
  public  class ContactDal : EfdbContextBase<ContactDal,DbContext> , IEntity
    {
    }
}
