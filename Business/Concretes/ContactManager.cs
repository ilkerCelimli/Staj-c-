using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
  public  class ContactManager : IContactService

  {
      private readonly ContactDal contactDal = InstanceFactory.GetInstance<ContactDal>();


        public IResult AddContact(Contact contact)
        {
            try
            {
               contactDal.Add(contact);
               return new SuccesfulResult("Eklendi");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult DeleteContact(int id)
        {
            try
            {
                contactDal.Delete(contactDal.Get(i => i.Id == id));

                return new SuccesfulResult("Eklendi");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }

        public IResult UpdateContact(int id ,Contact contact)
        {
            try
            {

                Contact dumy = contactDal.Get(i => i.Id == id);

                contact.Id = id;

          contactDal.Update(contact);
          return new SuccesfulResult("Eklendi");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
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
                Console.Write(e.Message);
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
                Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }
    }
}
