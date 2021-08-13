using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Result;
using Core.Result.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Entities.Dto;

namespace Business.Concretes
{
    public class AuthManager : IAuthService
    {

        private readonly ITokenHelper tokenHelper;
        private readonly IUserService userService;

        public AuthManager(ITokenHelper token, IUserService user)
        {
            this.userService = user;
            this.tokenHelper = token;
        }


        public DataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            userService.Add(user);
            return new SuccesfulResultData<User>(user, "kayıt başarılı.");

        }

        public DataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = userService.GetByMail(userForLoginDto.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorResultData<User>("Email bulunamadı");
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorResultData<User>("şifre yanlış");
            }
            return new SuccesfulResultData<User>(userToCheck.Data, "giriş başarılı.");

        }

        public IResult UserExists(string email)
        {

            if (userService.GetByMail(email).Data != null)
            {
                return new ErrorResult("Email zaten mevcut.");
            }
            return new SuccesfulResult();
        }

        public DataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = userService.GetClaims(user);
            var accessToken = tokenHelper.CreateToken(user, claims.Data);
            return new SuccesfulResultData<AccessToken>(accessToken, "giriş başarılı.");
        }
    }
}
