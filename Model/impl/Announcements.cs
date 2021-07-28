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
        public long annoId { get; set; }

        public string announcementsTitle { get; set; }

        public string AnnouncementsDetail { get; set; }


    }
}
