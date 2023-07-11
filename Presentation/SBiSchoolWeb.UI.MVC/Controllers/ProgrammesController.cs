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
    public class ProgrammesController : Controller
    {
        public ActionResult ProgrammesList()
        {
            ProgrammesComponent pc = new ProgrammesComponent();

            List<Programme> model = pc.GetAllProgrammes();

            decimal _TotalProgrammeFees = 0;

            foreach (var programme in model)
            {
                var _programmeyearsquery = from py in pc.GetAllProgrammeYears()
                                           where py.ProgrammeId.Trim() == programme.Id.Trim()
                                           select py;
                List<ProgrammeYear> _ProgramYears = _programmeyearsquery.ToList();

                foreach (var _ProgrammeYear in _ProgramYears)
                {
                    var _ProgramYearCoursesquery = from pyc in pc.GetAllProgrammeYearCourses()
                                                   where pyc.ProgrammeId == programme.Id
                                                   where pyc.IsDeleted == false
                                                   where pyc.ProgrammeYearId == _ProgrammeYear.Id
                                                   select pyc;
                    List<ProgrammeYearCourse> _ProgrammeYearCourses = _ProgramYearCoursesquery.ToList();

                    _TotalProgrammeFees += _ProgrammeYearCourses.Sum(i => i.ExamFees) + _ProgrammeYearCourses.Sum(i => i.ResitFees) + _ProgrammeYearCourses.Sum(i => i.TuitionFees);
                }

                programme.Fees = _TotalProgrammeFees;
            }

            return View(model);
        }

        public ActionResult CreateProgramme()
        {
            return View();

        }

        [HttpPost]
        public ActionResult CreateProgramme([Bind] Programme model)
        {
            if (ModelState.IsValid)
            {
                ProgrammesComponent pc = new ProgrammesComponent();

                Programme _Programme = new Programme();
                _Programme.Id = Utils.ConvertFirstLetterToUpper(model.Id);
                _Programme.Description = Utils.ConvertFirstLetterToUpper(model.Description);
                _Programme.Hours = model.Hours;
                _Programme.Fees = model.Fees;
                _Programme.Status = model.Status;
                _Programme.IsDeleted = false;

                Programme returnedProgramme = pc.CreateProgramme(_Programme);

                return RedirectToAction("ProgrammesList");

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

        public ActionResult EditProgramme(string id)
        {
            ProgrammesComponent pc = new ProgrammesComponent();

            Programme model = pc.GetProgramme(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditProgramme([Bind] Programme model)
        {
            if (ModelState.IsValid)
            {
                ProgrammesComponent pc = new ProgrammesComponent();

                Programme _Programme = pc.GetProgramme(model.Id);
                _Programme.Id = Utils.ConvertFirstLetterToUpper(model.Id);
                _Programme.Description = Utils.ConvertFirstLetterToUpper(model.Description);
                _Programme.Hours = model.Hours;
                _Programme.Fees = model.Fees;
                _Programme.Status = model.Status;

                pc.UpdateProgramme(_Programme);

                return RedirectToAction("ProgrammesList");

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

        public ActionResult ProgrammeDetails(string id)
        {
            ProgrammesComponent pc = new ProgrammesComponent();

            Programme model = pc.GetProgramme(id);

            return View(model);

        }

        public ActionResult DeleteProgramme(string id, string description)
        {
            ConfirmDeleteModel model = new ConfirmDeleteModel();

            model.Id3 = id;
            model.Description = description;

            return View("ConfirmDeleteProgramme", model);
        }

        [HttpPost]
        public ActionResult DeleteProgramme([Bind] ConfirmDeleteModel model)
        {
            ProgrammesComponent pc = new ProgrammesComponent();

            pc.DeleteProgramme(model.Id3);

            return RedirectToAction("ProgrammesList");
        }



    }
}