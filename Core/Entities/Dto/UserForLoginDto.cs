﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

using Core.Entities.Abstract;namespace Entities.Dto
{
    public class UserForLoginDto : IDto
    {
        
        
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
