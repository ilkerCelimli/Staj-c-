using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.Result.Concrete
{
    public class SuccesfulResult :Result,IResult
    {
    

        public SuccesfulResult(bool status) : base(status)
        {
            new SuccesfulResult(status);
        }

  

        public SuccesfulResult(bool status, string message) : base(status, message)
        {
          

            new SuccesfulResult(true, message :message);
        }
    }
}
