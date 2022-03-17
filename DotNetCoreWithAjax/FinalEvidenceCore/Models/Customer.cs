using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        public string Gender { get; set; }
        [DisplayName("Order Date")]
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Image { get; set; }
        [DisplayName("Order ID")]
        public int? OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
