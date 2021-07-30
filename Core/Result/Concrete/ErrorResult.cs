using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Concrete
{
    public class ErrorResult: Result,IResult
    {

        public ErrorResult(bool status) : base(status)
        {
            new ErrorResult(status);
        }

        public ErrorResult(bool status, string message) : base(status, message)
        {
            new ErrorResult(false, message: message);
        }
    }
}
