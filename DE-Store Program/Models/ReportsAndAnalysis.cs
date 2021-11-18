using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class ReportsAndAnalysis
    {
        public int ReportID { get; set; }
        public int ShopName { get; set; }
        public int ItemsSold { get; set; }
        public int CustomerFootFall { get; set; }
        public DateTime Date { get; set; }
    }
}