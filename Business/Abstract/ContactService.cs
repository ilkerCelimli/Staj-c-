using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Result;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface IContactService
    {

        IResult AddContact(Contact contact);
        IResult DeleteContact(int id);
        IResult UpdateContact(int id ,Contact contact);
        IResult GetAllContact();
        IResult GetContact(int id);

    }
}
