using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class SaleRecords
    {
        public int SaleID { get; set; } 
        public int SaleType { get; set; }

        public virtual ICollection<ProductRecords> GetProducts { get; set; }
    }
}