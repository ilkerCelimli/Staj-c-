using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Entities.Concretes;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _service;

        public ContactController(IContactService contact)
        {
            _service = contact;
        }

        [HttpGet("/Contact/GetAll")]

        public IResult GetAll()
        {
          return _service.GetAllContact();
        }

        [HttpGet("/Contact/GetById")]
        public IResult GetById(int id)
        {
            return _service.GetContact(id);

        }

        [HttpPost("/Contact/AddContact")]

        public IResult AddContact(Contact contact)
        {
            return _service.AddContact(contact);
        }


        [HttpPut("/Contact/updateContact")]

        public IResult UpdateContact(int id, Contact contact) => _service.UpdateContact(id, contact);

        [HttpDelete("/Contact/DeleteContact")]
        public IResult DeleteContact(int id) => _service.DeleteContact(id);
    }

   
    

}
