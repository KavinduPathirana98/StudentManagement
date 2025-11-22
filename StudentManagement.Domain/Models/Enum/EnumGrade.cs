using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Enum
{
    public enum EnumGrade
    {
        [Description("F")]
        FAIL = 0,
        [Description("S")]
        SUCCEED = 45,
        [Description("C")]
        CREDIT = 55,
        [Description("B")]
        BEST = 65,
        [Description("A")]
        EXCELLENT = 75

    }
}
