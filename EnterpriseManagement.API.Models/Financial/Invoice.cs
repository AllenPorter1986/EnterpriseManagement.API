using EnterpriseManagement.Models.Billing.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.Billing
{
    public class Invoice: BaseEntity
    {
        public Invoice()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }
        public InvoiceType Type { get; set; }

        public ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
