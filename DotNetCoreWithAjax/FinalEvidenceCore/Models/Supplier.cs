using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
