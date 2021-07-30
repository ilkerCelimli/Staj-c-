using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Concrete
{
   public class SuccesfulResultData<T> : DataResult<T>, IDataResult<T>
   {

      public SuccesfulResultData(string message, bool status) : base(message,status)
       {
           new SuccesfulResult(status, message);
       }

      public SuccesfulResultData(T data, bool status,string message) : base(message, data,status)
      {
          new ErrorResultData<T>(data,message, status);
      }

   }
}
