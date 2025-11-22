using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Enum
{
    public enum EnumStudentStatus
    {
        [Description("This for represent inactive student")]
        INACTIVE,

        [Description("This for represent active student")]
        ACTIVE,

        [Description("This for represent graduated student")]
        GRADUATED
    }
}
