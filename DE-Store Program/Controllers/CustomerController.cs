﻿using static DataClassLibary.BuisnessLogic.CustomerLCProcessor;
using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataClassLibary.Models;
using System.Windows.Forms;

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

        public ActionResult CustomerData()
        {
            ViewBag.Message = "This is a list of all of the Data that we currently have of each Customer";
            List<CustomerLoyaltyCardModel> customers = new List<CustomerLoyaltyCardModel>();
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