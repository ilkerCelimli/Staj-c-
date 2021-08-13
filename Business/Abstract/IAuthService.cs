using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Result;
using Core.Result.Concrete;
using Core.Utilities.Security.Jwt;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IAuthService
    {

        DataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        DataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        DataResult<AccessToken> CreateAccessToken(User user);
    }
}
