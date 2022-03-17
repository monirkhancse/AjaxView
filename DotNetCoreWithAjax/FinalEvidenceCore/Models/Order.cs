using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.Models
{
    public class Order
    {
        public Order()
        {
            Customers = new HashSet<Customer>();
        }

        public int OrderId { get; set; }
        [DisplayName("Order Name")]
        public string OrderName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
