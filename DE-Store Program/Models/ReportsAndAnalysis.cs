using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class ReportsAndAnalysis
    {   [Display(Name = "Report ID ")]
        public int ReportID { get; set; }

        [Display(Name = "Shop Name ")]
        public string ShopName { get; set; }

        [Display(Name = "Items Sold ")]
        public int ItemsSold { get; set; }

        [Display(Name = "Customer FootFall ")]
        public int CustomerFootFall { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}