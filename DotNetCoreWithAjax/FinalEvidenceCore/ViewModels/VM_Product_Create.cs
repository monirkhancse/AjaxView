using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalEvidenceCore.ViewModels
{
    public class VM_Product_Create
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int PurchasePrice { get; set; }
        public int SalesPrice { get; set; }
        public int OrderQuantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
