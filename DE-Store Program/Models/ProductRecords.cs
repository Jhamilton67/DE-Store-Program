using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class ProductRecords
    {
        [Display(Name = "Product ID")]
        [Range(10000, 99999, ErrorMessage = "You Need To enter a Valid Customer ID")]
        public int ProductID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Quantity")]
        public int Quanitity { get; set; }

        [Display(Name = "Sale ID ")]
        public int SaleID { get; set; }
    }
}