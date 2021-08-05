using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Concrete
{
    public class ErrorResult: Result
    {

        public ErrorResult(bool b, string messages) : base(false, messages)
        {
        }

        public ErrorResult() : base(false)
        {

        }
    }
}
