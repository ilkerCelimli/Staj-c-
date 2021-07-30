using System;
using Core.Result.Impl;

namespace Core
{
    public class Class1
    {


        public IResult Deneme()
        {
            return new UnSuccesfulResult(false);
        }
    }
}
