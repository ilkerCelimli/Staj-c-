﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Dto
{
    public class UserForUpdateDto: IDto

    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
