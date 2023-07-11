using SBiSchoolWeb.Business; 
using SBiSchoolWeb.Entities;
using SBiSchoolWeb.UI.MVC.Models; 
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Web; 
using System.Web.Mvc;

namespace SBiSchoolWeb.UI.MVC.Controllers
{
    [HandleError]
    [Authorize]
    public class SubjectsController : Controller
    {
        public ActionResult SubjectsList()
        {
            SubjectsComponent sc = new SubjectsComponent();
            List<Subject> model = sc.GetSubjects();

            return View(model);
        }


        public ActionResult CreateSubject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSubject([Bind] Subject model)
        {
            if (ModelState.IsValid)
            {
                SubjectsComponent sc = new SubjectsComponent();

                Subject _Subject = new Subject();
                _Subject.ShortCode = Utils.ConvertFirstLetterToUpper(model.ShortCode);
                _Subject.Description = Utils.ConvertFirstLetterToUpper(model.Description);
                _Subject.OutOf = model.OutOf;
                _Subject.PassMark = model.PassMark;
                _Subject.NoOfRequiredHours = model.NoOfRequiredHours;
                _Subject.Fees = model.Fees;
                _Subject.ROrder = model.ROrder;
                _Subject.Status = model.Status;
                _Subject.Remarks = model.Remarks;
                _Subject.IsDeleted = false;

                Subject returnedSubject = sc.CreateSubject(_Subject);

                return RedirectToAction("SubjectsList");

            }
            else
            {
                string[] errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors).Select(m => m.ErrorMessage).ToArray();
                foreach (var err in errors)
                {
                    ModelState.AddModelError(err, err);
                }
                return View(model);
            }
        }

        public ActionResult EditSubject(string shortcode)
        {
            SubjectsComponent sc = new SubjectsComponent();

            Subject model = sc.SelectSubject(shortcode);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditSubject([Bind] Subject model)
        {
            if (ModelState.IsValid)
            {
                SubjectsComponent sc = new SubjectsComponent();

                Subject _Subject = sc.SelectSubject(model.ShortCode);
                _Subject.ShortCode = Utils.ConvertFirstLetterToUpper(model.ShortCode);
                _Subject.Description = Utils.ConvertFirstLetterToUpper(model.Description);
                _Subject.OutOf = model.OutOf;
                _Subject.PassMark = model.PassMark;
                _Subject.NoOfRequiredHours = model.NoOfRequiredHours;
                _Subject.Fees = model.Fees;
                _Subject.ROrder = model.ROrder;
                _Subject.Status = model.Status;
                _Subject.Remarks = model.Remarks;

                sc.UpdateSubject(_Subject);

                return RedirectToAction("SubjectsList");

            }
            else
            {
                string[] errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors).Select(m => m.ErrorMessage).ToArray();
                foreach (var err in errors)
                {
                    ModelState.AddModelError(err, err);
                }
                return View(model);
            }
        }

        public ActionResult SubjectDetails(string shortcode)
        {
            SubjectsComponent sc = new SubjectsComponent();

            Subject model = sc.SelectSubject(shortcode);

            return View(model);
        }

        public ActionResult DeleteSubject(string shortcode, string description)
        {
            SubjectsComponent sc = new SubjectsComponent();
            ConfirmDeleteModel model = new ConfirmDeleteModel();
            model.Id3 = shortcode;
            model.Description = description;

            return View("ConfirmDeleteSubject", model);

        }


        [HttpPost]
        public ActionResult DeleteSubject([Bind] ConfirmDeleteModel model)
        {
            SubjectsComponent sc = new SubjectsComponent();

            sc.DeleteSubject(model.Id3);

            return RedirectToAction("SubjectsList");
        }




    }
}