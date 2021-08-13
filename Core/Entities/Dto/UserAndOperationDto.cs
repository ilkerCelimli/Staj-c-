using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Dto
{
    public class UserAndOperationDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ClaimName { get; set; }
        public string CompanyName { get; set; }
        public int FindeksPoint { get; set; }
    }
}
