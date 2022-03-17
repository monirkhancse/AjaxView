using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Purchase Price")]
        public int PurchasePrice { get; set; }
        [DisplayName("Sales Price")]
        public int SalesPrice { get; set; }
        [DisplayName("Order Quantity")]
        public int OrderQuantity { get; set; }
        [DisplayName("Expire Date")]
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }


    }
}

