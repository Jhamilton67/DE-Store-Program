using static DataClassLibary.BuisnessLogic.ProductProcessor;
using DataClassLibary.Models;
using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DE_Store_Program.Controllers
{   [Authorize]
    public class ProductsController : Controller
    {
        #region DataHolders Method's
        private DbSet<ProductsModel> ProductsModels { get; set; }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PriceControl()
        {
            return View(); 
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "the Current Stock that the Store has";
            List<ProductRecords> productRecordsInfo = new List<ProductRecords>();
            return View();
        }
        /// <summary>
        /// a methof that loads all of my Products data from the database into the List formatted Html Page. 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoadProducts()
       {
            ViewBag.Message = "Products list";
            var data = GetProducts();
            List<ProductsModel> products = new List<ProductsModel>();

            foreach (var row in data)
            {
                products.Add(new ProductsModel
                {
                    SaleID = row.SaleID,
                    ProductID = row.ProductID, 
                    Name = row.Name, 
                    Price = row.Price, 
                    Quantity = row.Quantity
                });
            }

            return View();
       }

        public ActionResult StockLevelsForManager()
        {
            return View();
        }
            
        public ActionResult ProductData()
        {
            List<ProductRecords> ProductData = new List<ProductRecords>();

            ProductData.Add(new ProductRecords { SaleID = 5754, ProductID = 1243124, Name = "Hammer", Price = 200, Quanitity = 1 });
            ProductData.Add(new ProductRecords { SaleID = 5812, ProductID = 53241, Name = "Green Paint", Price = 5000, Quanitity = 3 });
            ProductData.Add(new ProductRecords { SaleID = 5987, ProductID = 89648, Name = "WallPaper", Price = 50, Quanitity = 1 });
            
            return View(ProductData);
        }

        #endregion

        #region Create Method
        //create error method 
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = ProductsModels.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        public ActionResult Create()
        {
            return View();
        }

        #endregion

        #region Edit Method
        //edit error method
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = ProductsModels.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        public ActionResult Edit()
        {
            return View();
        }

        #endregion

        #region Delete Method
        //delete error method 
        public ActionResult Delete(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ProductsModel Products = ProductsModels.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        public ActionResult Delete()
        {
            return View(); 
        }

        #endregion
    }
}