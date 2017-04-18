using EnterpriseManagement.Models.TimeManagement.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.TimeManagement
{
    public class Function : BaseEntity
    {

        public FunctionType Type { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
    }
}
