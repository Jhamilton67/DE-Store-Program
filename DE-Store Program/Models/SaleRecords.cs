using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class SaleRecords
    {
        [Display(Name = "Sale ID" )]
        public int SaleID { get; set; } 

        [Display(Name = "Sale Type")]
        public string SaleType { get; set; }
        public virtual ICollection<ProductRecords> GetProducts { get; set; }
    }
}