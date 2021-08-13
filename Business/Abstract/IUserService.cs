﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Result;
using Core.Result.Concrete;
using Entities.Dto;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user, string password);
        DataResult<List<User>> GetAll();
        DataResult<User> Get(int userId);

        DataResult<User> GetByMail(string email);
    }
}
