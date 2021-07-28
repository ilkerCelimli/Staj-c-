using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Abstract;

namespace Model.impl
{
    class Employee : IEntity
    {

        public long id { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public long nationalIdendity { get; set; }

        public string gender { get; set; } 

        public string phone { get; set; }

        public DateTime birtday { get; set; }


        public string workPlace { get; set; }

        public string task { get; set; }

        public string reasonFordeparture { get; set; }

        public DateTime starTime { get; set; }

        public DateTime endTime { get; set; }

        public string primarySchool { get; set; }
        public int primarySchoolRank { get; set; }
        public bool primarySchoolComplate { get; set; }

        public string middleSchool { get; set; }
        public int middleSchoolRank { get; set; }
        public bool middleSchoolComplate { get; set; }

        public string highSchool { get; set; }
        public int highSchoolRank { get; set; }
        public bool highSchoolComplate { get; set; }

        public string university { get; set; }
        public int universityRank { get; set; }
        public bool universityComplate { get; set; }

        public string driverLicance { get; set; }

        public string usedPrograms { get; set; }

        public string referancedInformation { get; set; }

        public string referancedPhone { get; set; }

        public string appliedTask { get; set; }

        public bool changeOfResidance { get; set; }

        public bool extraShift { get; set; }

        public bool shift { get; set; }


    }
}
