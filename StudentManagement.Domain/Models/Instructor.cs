using StudentManagement.Domain.Models.Common;
using StudentManagement.Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudentManagement.Domain.Models
{
    public class Instructor : ModelBase
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EnumDepartment Department { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
