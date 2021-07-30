using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using Entities.Concretes;

using DataAcceses.EntityFramework;

namespace DataAcceses.EntityFramework
{
   public class AnnounCementsDal : EfdbContextBase<Announcements,DbContext> ,IEntity
    {
    }
}
