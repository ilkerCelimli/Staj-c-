using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace Core.Result.Concrete
{
   public class SuccesfulResultData<T> : DataResult<T>
   {
       public SuccesfulResultData(T data, string messages) : base(data, true, messages)
       {
       }
       public SuccesfulResultData(T data) : base(data, true)
       {

       }

       public SuccesfulResultData(List<T> data) : base(data)
       {

       }

    }
}
