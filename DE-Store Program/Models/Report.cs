using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class Report
    {
        public int ReportID { get; set; }   
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
    }
}