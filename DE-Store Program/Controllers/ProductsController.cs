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
            return Delete();
        }

    }
}