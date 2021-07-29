using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.impl
{
   public class Employee : IEntity
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public long NationalIdendity { get; set; }

        public string Gender { get; set; } 

        public string Phone { get; set; }

        public DateTime Birtday { get; set; }


        public string WorkPlace { get; set; }

        public string Task { get; set; }

        public string ReasonForDeparture { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string PrimarySchool { get; set; }
        public int PrimarySchoolRank { get; set; }
        public bool PrimarySchoolComplate { get; set; }

        public string MiddleSchool { get; set; }
        public int MiddleSchoolRank { get; set; }
        public bool MiddleSchoolComplate { get; set; }

        public string HighSchool { get; set; }
        public int HighSchoolRank { get; set; }
        public bool HighSchoolComplate { get; set; }

        public string University { get; set; }
        public int UniversityRank { get; set; }
        public bool UniversityComplate { get; set; }

        public string DriverLicance { get; set; }

        public string UsedPrograms { get; set; }


        public string ReferancedInformation { get; set; }

        public string ReferancedPhone { get; set; }

        public string AppliedTask { get; set; }

        public bool ChangeOfResidance { get; set; }

        public bool ExtraShift { get; set; }

        public bool Shift { get; set; }


    }
}
