using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;
using Model.impl;
using Repository.Abstract;

namespace Repository.EntityFramework
{
    class EfNewsDal : EfdbContextBase<News ,DbContext> , IEntity
    {


    }
}
