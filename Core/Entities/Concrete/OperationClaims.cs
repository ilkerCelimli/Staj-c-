using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
   public class OperationClaims : IEntity
    {

            public int Id { get; set; }
            public string Name { get; set; }

    }
}
