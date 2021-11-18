using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class CustomerLoyaltyCard
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }

        public bool BuyNowPayLater { get; set; }

    }
}