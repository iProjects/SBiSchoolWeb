using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SBiSchoolWeb.Business;
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.UI.MVC.Models;

namespace SBiSchoolWeb.UI.MVC.Controllers
{
    [HandleError]
    [Authorize]
    public class ExamTypesController : Controller
    {
        //[Authorize]
        public ActionResult GetAllExamTypes()
        {
            ExamTypesComponent ec = new ExamTypesComponent();
            List<ExamType> ExamTypes = ec.GetAllExamTypes();

            return View("ExamTypesListView", ExamTypes);
        }

        //
        // GET: /ExamTypes/Details/5

        public ActionResult ExamTypeDetails(int id)
        {
            return View();
        }

        //
        // GET: /ExamTypes/Create

        public ActionResult CreateExamType()
        {
            return View();
        }

        //
        // POST: /ExamTypes/Create

        [HttpPost]
        public ActionResult CreateExamType([Bind] ExamType model)
        {

            // TODO: Add insert logic here

            return RedirectToAction("Index");
        }

        //
        // GET: /ExamTypes/Edit/5

        public ActionResult EditExamType(int id)
        {
            return View();
        }

        //
        // POST: /ExamTypes/Edit/5

        [HttpPost]
        public ActionResult EditExamType([Bind] ExamType model)
        {
            // TODO: Add update logic here

            return RedirectToAction("Index");
        }

        //
        // GET: /ExamTypes/Delete/5

        public ActionResult DeleteExamType([Bind] ConfirmDeleteModel model)
        {
            return View();
        }

        //
        // POST: /ExamTypes/Delete/5

        [HttpPost]
        public ActionResult DeleteExamType(int id, string description)
        { // TODO: Add delete logic here

            return RedirectToAction("Index");
        }



    }
}