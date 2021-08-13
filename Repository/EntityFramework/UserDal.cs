using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Entities.Dto;
using Entities.Dto;

namespace DataAcceses.EntityFramework
{
    public class UserDal : EfdbContextBase<User,DbContext>
    {
        public List<OperationClaims> GetClaims(User user)
        {
            using (DbContext context = new DbContext())
            {
                var result = from operationClaim in context.UserOperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaims {Id = operationClaim.Id};
                return result.ToList();

            }
        }

        public UserAndOperationDto GetUserAndClaim(string email)
        {
            using (DbContext context = new DbContext())
            {   
                var result = from user in context.users
                    join userOperationClaim in context.UserOperationClaims
                        on user.Id equals userOperationClaim.UserId
                    join operationClaim in context.OperationClaims
                        on userOperationClaim.OperationClaimId equals operationClaim.Id
                    join customer in context.Employees
                        on user.Id equals customer.Id
                    where user.Email == email
                    select new UserAndOperationDto
                    {
                        UserId = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        ClaimName = operationClaim.Name,
                    };
                return result.FirstOrDefault();
            }

        }

    }
}
