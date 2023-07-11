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
    public class ExamsController : Controller
    {
        //[Authorize]
        public ActionResult GetAllExams()
        {
            ExamsComponent ec = new ExamsComponent();
            List<Exam> Exams = ec.GetAllExams();

            return View("ExamsListView", Exams);
        }
        //[Authorize]
        public ActionResult ExamDetails(int id)
        {
            return View();
        }
        //[Authorize]
        public ActionResult CreateExam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateExam([Bind] Exam model)
        {
            return RedirectToAction("Index");
        }
        //[Authorize]
        public ActionResult EditExam(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult EditExam([Bind] Exam model)
        {

            return RedirectToAction("Index");
        }

        //[Authorize]
        public ActionResult DeleteExam([Bind] ConfirmDeleteModel model)
        {
            return View();
        }


        [HttpPost]
        public ActionResult DeleteExam(int id, string description)
        {
            // TODO: Add delete logic here

            return RedirectToAction("Index");
        }

        //[Authorize]
        public ActionResult GetAllRegisteredStudents()
        {
            ExamsComponent ec = new ExamsComponent();
            List<StudentExam> StudentExam = ec.GetAllRegisteredStudents();

            return View("RegisterStudentsListView", StudentExam);
        }

        //[Authorize]
        public ActionResult GetAllMarkSheet()
        {
            ExamsComponent ec = new ExamsComponent();
            List<StudentExam> StudentExam = ec.GetAllMarkSheet();

            return View("MarkSheetListView", StudentExam);
        }

        //[Authorize]
        public ActionResult GetAllProcessedExams()
        {
            ExamsComponent ec = new ExamsComponent();
            List<StudentsExamResults_Temp> StudentsExamResults = ec.GetAllProcessedExams();

            return View("ProcessExamsListView", StudentsExamResults);
        }

        //[Authorize]
        public ActionResult GetAllProgressResultsList()
        {
            ExamsComponent ec = new ExamsComponent();
            List<StudentProgresses_Temp> StudentProgresses = ec.GetAllProgressResultsList();

            return View("ProgressResultsView", StudentProgresses);
        }

        //[Authorize]
        public ActionResult GetAllRegisteredExams()
        {
            ExamsComponent ec = new ExamsComponent();
            List<RegisteredExam> RegisteredExams = ec.GetAllRegisteredExams();

            return View("RegisteredExamsListView", RegisteredExams);
        }




    }
}