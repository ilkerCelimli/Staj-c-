using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
   public class SuccesfulReturnData<T> : ReturnDataResult<T>, IDataResult<T>
   {

      public SuccesfulReturnData(string message, bool status) : base(message,status)
       {
           new SuccesfulResult(status, message);
       }

      public SuccesfulReturnData(T data, bool status,string message) : base(message, data,status)
      {
          new UnSuccesfulResultData<T>(data,message, status);
      }

   }
}
