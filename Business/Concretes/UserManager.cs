using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dto;
using Core.Result;
using Core.Result.Concrete;
using Core.Utilities.Security.Hashing;
using DataAcceses.EntityFramework;
using Entities.Dto;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {

        private readonly UserDal userDal;

        public UserManager(UserDal userDal)
        {
            this.userDal = userDal;
        }

        public IResult Add(User user)
        {
            userDal.Add(user);
           return new SuccesfulResult("Eklendi");
        }

        public IResult Delete(User user)
        {
           userDal.Delete(user);

           return new SuccesfulResult("silindi");
        }

        public IResult Update(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var updateUser = new User
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = user.Status
            };
            userDal.Update(updateUser);
            return new SuccesfulResult("güncellendi");
        }

        public DataResult<List<User>> GetAll()
        {
          return new SuccesfulResultData<List<User>>(userDal.GetAll(),"listelendi");
        }

        public DataResult<User> Get(int userId)
        {
            return new SuccesfulResultData<User>(userDal.Get(p => p.Id == userId));
        }

        public DataResult<UserAndOperationDto> GetUserAndClaim(string email)
        {
            return new SuccesfulResultData<UserAndOperationDto>(userDal.GetUserAndClaim(email));
        }


        public DataResult<User> GetByMail(string email)
        {
            return new SuccesfulResultData<User>(userDal.Get(p => p.Email == email));
        }

        public DataResult<List<OperationClaims>> GetClaims(User user)
        {
            return new SuccesfulResultData<List<OperationClaims>>(userDal.GetClaims(user));
        }
    }
}
