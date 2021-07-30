using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;


namespace Entities.Concretes
{
    public class Announcements : IEntity
    {
        public long Id { get; set; }

        public string AnnouncementsTitle { get; set; }

        public string AnnouncementsDetail { get; set; }


    }
}
