using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.impl
{
    public class News : IEntity
    {

      public long NewsId { get; set; }

      public string NewsTitle { get; set; }

      public string NewsDetail { get; set; }



    }
}
