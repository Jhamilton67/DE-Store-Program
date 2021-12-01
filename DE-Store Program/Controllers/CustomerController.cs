using static DataClassLibary.BuisnessLogic.CustomerLCProcessor;
using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataClassLibary.Models;
using System.Windows.Forms;
using System.Data.Entity;

namespace DE_Store_Program.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        #region DataHolders Method's
        private DbSet<CustomerLoyaltyCardModel> Customers { get; set; }

        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.Message = "This is a list of all of the Data that we currently have of each Customer";
            List<CustomerLoyaltyCardModel> customers = new List<CustomerLoyaltyCardModel>();
            return View();
        }

        public ActionResult FinanceApproval()
        {
            ViewBag.Message = "This is a little Test to make sure that the customer is eligable to have the product" +
                "on Finance."; 
            return View();
        }

        public ActionResult CustomerListData()
        {
            List<CustomerLoyaltyCard> customersModel = new List<CustomerLoyaltyCard>
            {
                new CustomerLoyaltyCard { CustomerID = 1242, FirstName = "Tim", LastName = "Wood",  Email = "TimWood@Test.com", Employeed = "Yes", BuyNowPayLater = "Active"},
                new CustomerLoyaltyCard { CustomerID = 1111, FirstName = "John", LastName = "Brown",  Email = "JohnBrown@Test.com", Employeed = "No", BuyNowPayLater = "Not Active"},
                new CustomerLoyaltyCard { CustomerID = 1522, FirstName = "Lisa", LastName = "Simpson",  Email = "Lisa.Simpson@Test.com", Employeed = "Yes", BuyNowPayLater = "Active"},
                new CustomerLoyaltyCard { CustomerID = 1231, FirstName = "Bill", LastName = "Storn",  Email = "Bstorn@Test.com", Employeed = "Yes", BuyNowPayLater = "Active"}
            };

            return View(customersModel); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult FinanceApproval(CustomerLoyaltyCardModel loyaltyCard)
        {
            //string message = "Connecting to the Finance Approval System";
            //string Caption = "Finance Approval Required";
            //MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            //DialogResult result; 

           if (ModelState.IsValid)
           {
                CreateCustomer(loyaltyCard.CustomerID, 
                    loyaltyCard.FirstName, 
                    loyaltyCard.LastName, 
                    loyaltyCard.Email, 
                    loyaltyCard.Employeed, 
                    loyaltyCard.BuyNowPayLater);

                return RedirectToAction("Index");
           }

            return View();
        }

        public ActionResult LoyaltyScheme()
        {
            return View();
        }

        #endregion

        #region Create Method
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            CustomerLoyaltyCardModel Products = Customers.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        public ActionResult Create(CustomerLoyaltyCardModel customer)
        {
            if (ModelState.IsValid)
            {
                CreateCustomer(customer.CustomerID, 
                    customer.FirstName, 
                    customer.LastName, 
                    customer.Email, 
                    customer.Employeed, 
                    customer.BuyNowPayLater);

                return RedirectToAction("Index");
            }
            return View();
        }

        #endregion

        #region Edit Method
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            CustomerLoyaltyCardModel Products = Customers.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }


        public ActionResult Edit()
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        #endregion

        #region Delete Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            CustomerLoyaltyCardModel Products = Customers.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        public ActionResult Delete()
        {
            if (ModelState.IsValid)
            {

            }

            return View();
        }
        #endregion
    }
}