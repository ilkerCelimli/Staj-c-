using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.impl
{ 
    
   public class Contact : IEntity
    {
        public long contactId { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public string message { get; set; }

    }
}
