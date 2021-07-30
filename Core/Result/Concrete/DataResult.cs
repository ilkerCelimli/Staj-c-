using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Impl
{
    public class DataResult<T> : IDataResult<T>
    {

        public DataResult(string message, bool status)
        {
            new DataResult<T>(message,status);
        }

        public DataResult(T data)
        {
            new DataResult<T>(data);
        }

        public DataResult(string message, T data, bool status)
        {
            new DataResult<T>(message,data, status);
        }

        public DataResult(bool status)
        {
            new DataResult<T>(status);

        }


    }
}