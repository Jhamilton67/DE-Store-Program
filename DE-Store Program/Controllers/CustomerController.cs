using static DataClassLibary.BuisnessLogic.CustomerLCProcessor;
using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataClassLibary.Models;

namespace DE_Store_Program.Controllers
{
    public class CustomerController : Controller
    {   [Authorize]
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FinanceApproval()
        {
            ViewBag.Message = "This is a little Test to make sure that the customer is eligable to have the product" +
                "on Finance."; 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinanceApproval(CustomerLoyaltyCardModel loyaltyCard)
        {
           if (ModelState.IsValid)
           {
               //int  RecordsCreated = CreateCustomer(loyaltyCard.CustomerID, 
               //     loyaltyCard.FirstName, 
               //     loyaltyCard.LastName, 
               //     loyaltyCard.Email,
               //     loyaltyCard.BuyNowPayLater);
               // return RedirectToAction("Index");
           }

            return View();
        }

        public ActionResult LoyaltyScheme()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}