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
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public bool Employeed { get; set; }
        #region Finance Approval 
        public bool BuyNowPayLater { get; set; }
        #endregion
    }
}