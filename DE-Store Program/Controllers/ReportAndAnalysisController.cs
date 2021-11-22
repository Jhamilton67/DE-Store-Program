using DE_Store_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DE_Store_Program.Controllers
{
    public class ReportAndAnalysisController : Controller
    {   [Authorize]
        // GET: ReportAndAnalysis
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReportData()
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReportAndAnalysis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportAndAnalysis/Create
        [HttpPost]
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

        // GET: ReportAndAnalysis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReportAndAnalysis/Edit/5
        [HttpPost]
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

        // GET: ReportAndAnalysis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReportAndAnalysis/Delete/5
        [HttpPost]
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
    }
}
