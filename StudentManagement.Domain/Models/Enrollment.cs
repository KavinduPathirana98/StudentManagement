using StudentManagement.Domain.Models.Common;
using StudentManagement.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models
{
    public class Enrollment : ModelBase
    {

        public int ID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int InstructorID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public EnumGrade Grade { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }

    }
}
