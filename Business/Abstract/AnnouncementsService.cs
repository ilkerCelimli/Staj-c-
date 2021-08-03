using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Result;
using Entities.Concretes;

namespace Business.Abstract
{
    interface IAnnouncementsService
    {

        IResult AddAnnouncement(Announcements announcements);
        IResult DeleteAnnouncement(int id);
        IResult UpdateAnnouncement(Announcements announcements);
        IResult GetAllAnnouncement();
        IResult GetAnnouncement(int id);

    }
}
