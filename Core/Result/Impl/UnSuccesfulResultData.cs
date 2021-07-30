using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
    class UnSuccesfulResultData<T> : ReturnDataResult<T> , IResult 
    {
        public UnSuccesfulResultData(string message, bool status) : base(message, status)
        {
            new UnSuccesfulResult(status);
        }

        public UnSuccesfulResultData(T data, string message, bool status) : base(message, status)
        {
            new UnSuccesfulResultData<T>(data, message, status);
        }

        public UnSuccesfulResultData(bool status) : base(status) 
        {
            new UnSuccesfulResult(status);
        }

    }
}
