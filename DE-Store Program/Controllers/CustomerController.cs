using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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