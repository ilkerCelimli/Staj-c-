using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Concrete
{
   public class ErrorResultData<T> : DataResult<T>   
    {
        public ErrorResultData(T data, string messages) : base(data, false, messages)
        {
        }
        public ErrorResultData(T data) : base(data, false)
        {

        }
        public ErrorResultData(string message) : base(default, false, message)
        {

        }
        public ErrorResultData() : base(default, false)
        {

        }

    }
}
