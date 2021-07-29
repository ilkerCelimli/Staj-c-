using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;
using Model.impl;

namespace Repository.EntityFramework
{
   public class AnnounCementsDal : EfdbContextBase<Announcements,DbContext> ,IEntity
    {
    }
}
