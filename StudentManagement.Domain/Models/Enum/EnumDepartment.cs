using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Enum
{
    public enum EnumDepartment
    {
        [Description("This for represent engineering department")]
        ENGINEERING = 100,
        [Description("This for represent management department")]
        MANAGEMENT = 200,
        [Description("This for represent language department")]
        LANGUAGES = 300

    }
}
