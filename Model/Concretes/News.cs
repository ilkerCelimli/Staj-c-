using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.Concretes
{
    public class News : IEntity
    {

      public long Id { get; set; }

      public string NewsTitle { get; set; }

      public string NewsDetail { get; set; }



    }
}
