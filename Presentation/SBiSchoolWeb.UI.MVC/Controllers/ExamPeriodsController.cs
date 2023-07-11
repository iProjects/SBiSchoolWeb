using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBiSchoolWeb.Business;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.UI.MVC.Models;

namespace SBiSchoolWeb.UI.MVC.Controllers
{
    [HandleError]
    [Authorize]
    public class ExamPeriodsController : Controller
    {
        //[Authorize]
        public ActionResult GetAllExamPeriods()
        {
            ExamPeriodsComponent ec = new ExamPeriodsComponent();
            List<ExamPeriod> ExamPeriods = ec.GetAllExamPeriods();

            return View("ExamPeriodsListView", ExamPeriods);
        }

        //
        // GET: /ExamPeriods/Details/5

        public ActionResult ExamPeriodDetails(int id)
        {
            return View();
        }

        //
        // GET: /ExamPeriods/Create

        public ActionResult CreateExamPeriod()
        {
            return View();
        }

        //
        // POST: /ExamPeriods/Create

        [HttpPost]
        public ActionResult CreateExamPeriod([Bind] ExamPeriod model)
        {   // TODO: Add insert logic here

            return RedirectToAction("Index");
        }

        //
        // GET: /ExamPeriods/Edit/5

        public ActionResult EditExamPeriod(int id)
        {
            return View();
        }

        //
        // POST: /ExamPeriods/Edit/5

        [HttpPost]
        public ActionResult EditExamPeriod([Bind] ExamPeriod model)
        {
            // TODO: Add update logic here

            return RedirectToAction("Index");
        }

        //
        // GET: /ExamPeriods/Delete/5

        public ActionResult DeleteExamPeriod([Bind] ConfirmDeleteModel model)
        {
            return View();
        }

        //
        // POST: /ExamPeriods/Delete/5

        [HttpPost]
        public ActionResult DeleteExamPeriod(int id, string description)
        {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }




    }
}