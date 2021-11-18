using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class ProductRecords
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quanitity { get; set; }

        public int SaleID { get; set; }
    }
}