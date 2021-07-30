using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
   public class ErrorResultData<T> : DataResult<T> , IResult 
    {
        public ErrorResultData(string message, bool status) : base(message, status)
        {
            new ErrorResult(status);
        }

        public ErrorResultData(T data, string message, bool status) : base(message, status)
        {
            new ErrorResultData<T>(data, message, status);
        }

        public ErrorResultData(bool status) : base(status) 
        {
            new ErrorResult(status);
        }

    }
}
