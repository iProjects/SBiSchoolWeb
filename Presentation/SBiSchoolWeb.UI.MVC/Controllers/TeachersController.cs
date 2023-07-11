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
    public class TeachersController : Controller
    {
        public ActionResult TeachersList()
        {
            TeachersComponent tc = new TeachersComponent();
            List<Teacher> model = tc.GetAllTeachers();

            return View(model);
        }

        public ActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeacher([Bind] Teacher model)
        {
            if (ModelState.IsValid)
            {
                TeachersComponent tc = new TeachersComponent();

                Teacher _Teacher = new Teacher();
                _Teacher.Name = Utils.ConvertFirstLetterToUpper(model.Name);
                _Teacher.IDNo = model.IDNo;
                _Teacher.TSCNo = model.TSCNo;
                _Teacher.Position = model.Position;
                _Teacher.Email = model.Email.ToLower();
                _Teacher.DateJoined = model.DateJoined;
                _Teacher.DateLeft = model.DateLeft;
                _Teacher.IsLeft = model.IsLeft;
                _Teacher.HighestQualification = model.HighestQualification;
                _Teacher.Status = model.Status;
                _Teacher.IsDeleted = false;

                Teacher returnedTeacher = tc.CreateTeacher(_Teacher);

                return RedirectToAction("TeachersList");

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

        public ActionResult EditTeacher(int id)
        {
            TeachersComponent tc = new TeachersComponent();

            Teacher model = tc.GetTeacher(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditTeacher([Bind] Teacher model)
        {
            if (ModelState.IsValid)
            {
                TeachersComponent tc = new TeachersComponent();

                Teacher _Teacher = tc.GetTeacher(model.Id);
                _Teacher.Name = Utils.ConvertFirstLetterToUpper(model.Name);
                _Teacher.IDNo = model.IDNo;
                _Teacher.TSCNo = model.TSCNo;
                _Teacher.Position = model.Position;
                _Teacher.Email = model.Email.ToLower();
                _Teacher.DateJoined = model.DateJoined;
                _Teacher.DateLeft = model.DateLeft;
                _Teacher.IsLeft = model.IsLeft;
                _Teacher.HighestQualification = model.HighestQualification;
                _Teacher.Status = model.Status;

                tc.UpdateTeacher(_Teacher);

                return RedirectToAction("TeachersList");

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

        public ActionResult TeacherDetails(int id)
        {
            TeachersComponent tc = new TeachersComponent();

            Teacher model = tc.GetTeacher(id);

            return View(model);
        }

        public ActionResult DeleteTeacher(int id, string description)
        {
            ConfirmDeleteModel model = new ConfirmDeleteModel();

            model.Id = id;
            model.Description = description;

            return View("ConfirmDeleteTeacher", model);
        }

        [HttpPost]
        public ActionResult DeleteTeacher([Bind] ConfirmDeleteModel model)
        {
            TeachersComponent tc = new TeachersComponent();

            tc.DeleteTeacher(model.Id);

            return RedirectToAction("TeachersList");
        }





    }
}