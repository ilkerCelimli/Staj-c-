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

      public long newsId { get; set; }

      public string newsTitle { get; set; }

      public string newsDetail { get; set; }



    }
}
