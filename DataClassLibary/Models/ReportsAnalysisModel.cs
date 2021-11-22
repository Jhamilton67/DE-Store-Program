using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibary.Models
{
   public  class ReportsAnalysisModel
    {
        public int ReportID { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }
        public int ItemsSold { get; set; }
        public int CustomerFootFall { get; set; }
        public DateTime Date { get; set; }
    }

}

