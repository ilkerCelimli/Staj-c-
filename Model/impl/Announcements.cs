using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.impl
{
    public class Announcements : IEntity
    {
        public long AnnoId { get; set; }

        public string AnnouncementsTitle { get; set; }

        public string AnnouncementsDetail { get; set; }


    }
}
