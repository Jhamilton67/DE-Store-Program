using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibary.Models
{
    public class CustomerLoyaltyCardModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Employeed { get; set; }
        public bool BuyNowPayLater { get; set; }

    }
}
