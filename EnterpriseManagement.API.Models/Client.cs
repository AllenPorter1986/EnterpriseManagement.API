using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models
{
    public class Client : BaseEntity
    {
        public Client()
        {
            Clients = new HashSet<Client>();
        }

        public int? ClientId { get; set; }
        public virtual ICollection<Client> Clients { get; set; } // Recusive relationship
    }
}
