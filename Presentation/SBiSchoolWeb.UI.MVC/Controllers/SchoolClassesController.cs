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
    public class SchoolClassesController : Controller
    {
        public ActionResult SchoolClassesList()
        {
            SchoolClassesComponent sc = new SchoolClassesComponent();
            List<SchoolClass> model = sc.GetAllSchoolClasses();

            return View(model);
        }

        public ActionResult CreateSchoolClass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSchoolClass([Bind] SchoolClass model)
        {
            if (ModelState.IsValid)
            {
                SchoolClassesComponent sc = new SchoolClassesComponent();

                SchoolClass _SchoolClass = new SchoolClass();
                _SchoolClass.ShortCode = Utils.ConvertFirstLetterToUpper(model.ShortCode);
                _SchoolClass.ClassName = Utils.ConvertFirstLetterToUpper(model.ClassName);
                _SchoolClass.ProgrammeYearId = model.ProgrammeYearId;
                _SchoolClass.NoOfSubjects = model.NoOfSubjects;
                _SchoolClass.TeacherId = model.TeacherId;
                _SchoolClass.CurrentYrLevel = model.CurrentYrLevel;
                _SchoolClass.NextYrLevel = model.NextYrLevel;
                _SchoolClass.Remarks = model.Remarks;
                _SchoolClass.Status = model.Status;
                _SchoolClass.IsDeleted = false;

                SchoolClass returnedSchoolClass = sc.CreateSchoolClass(_SchoolClass);

                return RedirectToAction("SchoolClassesList");

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

        public ActionResult EditSchoolClass(int id)
        {
            SchoolClassesComponent sc = new SchoolClassesComponent();

            SchoolClass model = sc.GetSchoolClass(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditSchoolClass([Bind] SchoolClass model)
        {
            if (ModelState.IsValid)
            {
                SchoolClassesComponent sc = new SchoolClassesComponent();

                SchoolClass _SchoolClass = sc.GetSchoolClass(model.Id);
                _SchoolClass.ShortCode = Utils.ConvertFirstLetterToUpper(model.ShortCode);
                _SchoolClass.ClassName = Utils.ConvertFirstLetterToUpper(model.ClassName);
                _SchoolClass.ProgrammeYearId = model.ProgrammeYearId;
                _SchoolClass.NoOfSubjects = model.NoOfSubjects;
                _SchoolClass.TeacherId = model.TeacherId;
                _SchoolClass.CurrentYrLevel = model.CurrentYrLevel;
                _SchoolClass.NextYrLevel = model.NextYrLevel;
                _SchoolClass.Remarks = model.Remarks;
                _SchoolClass.Status = model.Status;

                sc.UpdateSchoolClass(_SchoolClass);

                return RedirectToAction("SchoolClassesList");

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

        public ActionResult SchoolClassDetails(int id)
        {
            SchoolClassesComponent sc = new SchoolClassesComponent();

            SchoolClass model = sc.GetSchoolClass(id);

            return View(model);
        }

        public ActionResult DeleteSchoolClass(int id, string description)
        {
            ConfirmDeleteModel model = new ConfirmDeleteModel();

            model.Id = id;
            model.Description = description;

            return View("ConfirmDeleteSchoolClass", model);
        }

        [HttpPost]
        public ActionResult DeleteSchoolClass([Bind] ConfirmDeleteModel model)
        {
            SchoolClassesComponent sc = new SchoolClassesComponent();

            sc.DeleteSchoolClass(model.Id);

            return RedirectToAction("SchoolClassesList");
        }




    }
}