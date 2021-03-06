using static DataClassLibary.BuisnessLogic.SaleProcessor;
using DataClassLibary.Models;
using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DE_Store_Program.Controllers
{
    [Authorize]
    public class SalesController : Controller
    {
        #region DataHolders Method's
        private DbSet<ProductsModel> dbSet { get; set; }
        // GET: Sales
        public ActionResult Index()
        {
            List<SaleRecords> saleRecords = new List<SaleRecords>(); 

            return View();
        }

        public ActionResult SaleData()//Method that populates the  Html list to show all the data in the correct format 
        {
            List<SaleRecords> records = new List<SaleRecords>();

            records.Add(new SaleRecords { SaleID = 12421, SaleType = "Card" });
            records.Add(new SaleRecords { SaleID = 123121, SaleType = "Money" });
            records.Add(new SaleRecords { SaleID = 12421, SaleType = "Buy Now Pay Later" });

            return View(records);
        }

        // GET: Sales/Details/5
        //details error method 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = dbSet.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);

        }

        #endregion

        #region Create Method
        // GET: Sales/Create
        //create error method 
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = dbSet.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        // POST: Sales/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SaleModel collection)
        {
            if(ModelState.IsValid)
            {
                CreateSale(collection.SaleID, collection.SaleType);

                return RedirectToAction("Index"); 
            };

            return View();
        }
        #endregion

        #region Edit Method 

        // GET: Sales/Edit/5
        //edit error method 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = dbSet.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);

        }

        // POST: Sales/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Delete Method
        // GET: Sales/Delete/5
        //delete error method 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = dbSet.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        // POST: Sales/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion
    }
}
