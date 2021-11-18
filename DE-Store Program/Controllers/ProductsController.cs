using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DE_Store_Program.Controllers
{
    public class ProductsController : Controller
    {   [Authorize]
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductDetail()
        {
            ViewBag.Message = "the Current Stock that the Store has";
            List<ProductRecords> productRecordsInfo = new List<ProductRecords>();
            return View();
        }

        public ActionResult ProductData()
        {
            List<ProductRecords> ProductData = new List<ProductRecords>
            {
                new ProductRecords { SaleID = 5754, ProductID = 1243124, Name = "Hammer", Price = 2500, Quanitity = 1 },
                new ProductRecords { SaleID = 5812, ProductID = 53241, Name = "Green Paint", Price = 5000, Quanitity = 3 },
                new ProductRecords { SaleID = 5987, ProductID = 89648, Name = "WallPaper", Price = 50, Quanitity = 1 }
            };

            return View(ProductData);
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
            return Delete();
        }

    }
}