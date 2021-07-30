using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Result.Concrete
{
    public class Result : IResult
    {
        public bool Status { get; set; }

        public string Message { get; set; }



        public Result(bool status)
        {
            this.Status = status;

        }

        public Result(bool status, string message)
        {
            this.Status = status;
            this.Message = message;

        }
        
    }
}
