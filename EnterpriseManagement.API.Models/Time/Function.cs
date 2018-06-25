using EnterpriseManagement.API.Models.Time.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseManagement.API.Models.Time
{    
    public class Function : BaseEntity
    {

        public FunctionType Type { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
    }
}
