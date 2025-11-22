using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Models.Common
{
    public class ModelBase
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccesMessage { get; set; }
    }
}
