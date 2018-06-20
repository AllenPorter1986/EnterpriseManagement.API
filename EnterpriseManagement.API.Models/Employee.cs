using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models
{
    public class Employee:BaseEntity
    {
        public string Identifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
