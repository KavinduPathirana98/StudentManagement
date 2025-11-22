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
    public class Course : ModelBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Credits { get; set; }
        public EnumDepartment Department { get; set; }
        public string Description { get; set; }

    }
}
