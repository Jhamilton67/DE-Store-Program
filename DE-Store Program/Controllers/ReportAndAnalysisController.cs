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
    public class ReportAndAnalysisController : Controller
    {
        #region DataHolders Method's
        private DbSet<ReportsAnalysisModel> Reports { get; set; }

        // GET: ReportAndAnalysis
        public ActionResult Index()
        {
            List<ReportsAndAnalysis> reportAndAnalyses = new List<ReportsAndAnalysis>();

            return View();
        }

        public ActionResult ReportandAnalysisData()
        {
            List<ReportsAndAnalysis> analyses = new List<ReportsAndAnalysis>();

            analyses.Add(new ReportsAndAnalysis {ReportID = 124431, ShopName = "DeStore1", ItemsSold = 122112, CustomerFootFall = 88968851 });

            return View(analyses);
        }

        // GET: ReportAndAnalysis/Details/5
        //Error for Details method 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ReportsAnalysisModel Products = Reports.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }
        #endregion

        #region CreateMethod
        // GET: ReportAndAnalysis/Create
        //Create error method 
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ReportsAnalysisModel Products = Reports.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        // POST: ReportAndAnalysis/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region EditMethod
        // GET: ReportAndAnalysis/Edit/5
        //edit error method 
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ReportsAnalysisModel Products = Reports.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        // POST: ReportAndAnalysis/Edit/5
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

        #region DeleteMethod

        // GET: ReportAndAnalysis/Delete/5
        //delete error method 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
            }
            ReportsAnalysisModel Products = Reports.Find(id);
            if (Products == null)
            {
                return HttpNotFound();
            }
            return View(Products);
        }

        // POST: ReportAndAnalysis/Delete/5
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
