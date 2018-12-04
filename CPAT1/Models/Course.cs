using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPAT1.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseID { get; set; }
        public string Description { get; set; }
        public int? CreditHours { get; set; }
        public string Major { get; set; }
        public int InitialTermNumber { get; set; }
        public int courseDemand { get; set; } = 0;
        public string[] PreRequisites { get; set; }
        public int? SemesterAvailability { get; set; }
        public void GetPreReqs()
        {

        }

    }
}
