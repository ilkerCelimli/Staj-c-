using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
  public  class ContactManager : IContactService

  {
      private ContactDal contactDal
          ;

      public ContactManager(ContactDal contactDal)
      {
          this.contactDal = contactDal;
      }


        public IResult AddContact(Contact contact)
        {
            try
            {
               contactDal.Add(contact);
               return new SuccesfulResult(true, "Eklendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult DeleteContact(int id)
        {
            try
            {
                contactDal.Delete(contactDal.Get(i => i.Id == id));

                return new SuccesfulResult(true, "Silindi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult UpdateContact(Contact contact)
        {
            try
            {
          contactDal.Update(contact);
          return new SuccesfulResult(true, "güncellendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult GetAllContact()
        {
            try
            {
                return new DataResult<Contact>(contactDal.GetAll().ToList());
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult GetContact(int id)
        {
            try
            {
                return new SuccesfulResultData<Contact>(contactDal.Get(i => i.Id == id));
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");

            }
        }
    }
}
