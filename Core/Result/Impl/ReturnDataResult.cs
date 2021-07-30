using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
    public class ReturnDataResult<T> : IDataResult<T>
    {

        public ReturnDataResult(string message, bool status)
        {
            new ReturnDataResult<T>(message,status);
        }

        public ReturnDataResult(T data)
        {
            new ReturnDataResult<T>(data);
        }

        public ReturnDataResult(string message, T data, bool status)
        {
            new ReturnDataResult<T>(message,data, status);
        }

        public ReturnDataResult(bool status)
        {
            new ReturnDataResult<T>(status);

        }


    }
}