using EnterpriseManagement.API.Models.Time.Enum;
using EnterpriseManagement.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Time
{
    public class Function : BaseEntity
    {

        public FunctionType Type { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
    }
}
