using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPAT1.Models
{
    public class Semester
    {
        public string SemesterID { get; set; }
        public Course[] semesterCourses { get; set; }
        
    }
}
