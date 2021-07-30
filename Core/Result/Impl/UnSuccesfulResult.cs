using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
    public class UnSuccesfulResult: Result,IResult
    {

        public UnSuccesfulResult(bool status) : base(status)
        {
            new UnSuccesfulResult(status);
        }

        public UnSuccesfulResult(bool status, string message) : base(status, message)
        {
            new UnSuccesfulResult(false, message: message);
        }
    }
}
