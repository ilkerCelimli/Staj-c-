using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AnnouncementController : Controller

    {

        private readonly IAnnouncementsService _service = InstanceFactory.GetInstance<IAnnouncementsService>();



        [HttpGet("/Announcement/getAll")]

        public IResult GetAll()
        {
            return _service.GetAllAnnouncement();
        }

        [HttpGet("/Announcement/getById")]

        public IResult GetById(int id)
        {

            return _service.GetAnnouncement(id);
        }

        [HttpPost("/Announcement/AddAnnouncement")]

        public IResult AddAnnouncement(Announcements announcements)
        {
            return _service.AddAnnouncement(announcements);
        }

        [HttpDelete("/Announcement/deleteAnnouncement")]

        public IResult DeleteAnnouncement(int id)
        {

            return _service.DeleteAnnouncement(id);

        }

        [HttpPut("/Announcement/UpdateAnnouncement")]

        public IResult UpdateAnnouncement(int id,Announcements announcements)
        {
            return _service.UpdateAnnouncement(id, announcements);
        }
    }
}
