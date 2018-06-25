using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Time
{
    public class TaskDetail : BaseEntity
    {
        public int FunctionId { get; set; }
        public int ClientId { get; set; }
    }
}
