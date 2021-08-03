using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace Core.Result.Concrete
{
   public class SuccesfulResultData<T> : DataResult<T>, IDataResult<T>
   {
        public SuccesfulResultData(List<global::Entities.Concretes.News> news)
        {
            News = news;
        }

        public SuccesfulResultData(string message, bool status) : base(message,status)
       {
           new SuccesfulResult(status, message);
       }

      public SuccesfulResultData(T data, bool status,string message) : base(message, data,status)
      {
          new ErrorResultData<T>(data,message, status);
      }

        public List<global::Entities.Concretes.News> News { get; }
    }
}
