using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DE_Store_Program.Models
{
    public class CustomerLoyaltyCard
    {
        [Display(Name = "Customer ID")]
        [Range(10000, 99999, ErrorMessage ="You Need To enter a Valid Customer ID")]
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You have to Enter your First Name")]
        public string FirstName{ get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You have to Enter your Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "You have to Enter your Email Address")]
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage ="The Email and the Comfirm Email must Match.")]
        public string ConfirmEmail { get; set; }

        public string Employeed { get; set; }
        #region Finance Approval 
        [Display(Name = "Buy now Pay Later")]
        public string BuyNowPayLater { get; set; }
        #endregion
    }
}