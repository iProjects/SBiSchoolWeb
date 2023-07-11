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
    public class StudentsController : Controller
    {
        public ActionResult StudentsList()
        {
            StudentsComponent sc = new StudentsComponent();
            List<Student> model = sc.GetAllStudents();

            return View(model);
        }

        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent([Bind] Student model)
        {
            StudentsComponent sc = new StudentsComponent();

            if (ModelState.IsValid)
            {
                Student _Student = new Student();
                _Student.StudentSurName = Utils.ConvertFirstLetterToUpper(model.StudentSurName);
                _Student.StudentOtherNames = Utils.ConvertFirstLetterToUpper(model.StudentOtherNames);
                _Student.AdminNo = Utils.ConvertFirstLetterToUpper(model.AdminNo);
                _Student.SchoolId = model.SchoolId;
                _Student.Gender = model.Gender;
                _Student.Photo = model.Photo;
                _Student.ClassStreamId = model.ClassStreamId;
                _Student.DateOfBirth = model.DateOfBirth;
                _Student.Phone = model.Phone;
                if (model.Email != null)
                {
                    _Student.Email = model.Email.ToLower();
                }
                _Student.Homepage = model.Homepage;
                _Student.StudentAddress = Utils.ConvertFirstLetterToUpper(model.StudentAddress);
                _Student.AdmissionType = model.AdmissionType;
                _Student.Status = model.Status;
                _Student.KCPE = model.KCPE;
                _Student.KCSE = model.KCSE;
                _Student.AdmissionDate = model.AdmissionDate;
                _Student.AdmittedBy = model.AdmittedBy;
                _Student.Remarks = model.Remarks;
                _Student.Photo = model.Photo;
                _Student.LastModifiedTime = model.LastModifiedTime;
                _Student.GLAccountId = model.GLAccountId;
                _Student.CustomerId = model.CustomerId;
                _Student.FatherName = model.FatherName;
                _Student.FatherCellPhone = model.FatherCellPhone;
                _Student.FatherOfficePhone = model.FatherOfficePhone;
                _Student.FatherEmail = model.FatherEmail;
                _Student.MotherName = model.MotherName;
                _Student.MotherCellPhone = model.MotherCellPhone;
                _Student.MotherOfficePhone = model.MotherOfficePhone;
                _Student.MotherEmail = model.MotherEmail;
                _Student.GuardianName = model.GuardianName;
                _Student.GuardianCellPhone = model.GuardianCellPhone;
                _Student.GuardianOfficePhone = model.GuardianOfficePhone;
                _Student.GuardianEmail = model.GuardianEmail;
                _Student.PrevSchoolId = model.PrevSchoolId;
                _Student.PrevSchoolName = model.PrevSchoolName;
                _Student.PrevSchoolPhone = model.PrevSchoolPhone;
                _Student.PrevSchoolAddress = model.PrevSchoolAddress;
                _Student.ReasonForLeaving = model.ReasonForLeaving;
                _Student.ExtraCurricular1 = model.ExtraCurricular1;
                _Student.ExtraCurricular2 = model.ExtraCurricular2;
                _Student.ExtraCurricular3 = model.ExtraCurricular3;
                _Student.Term1MeanGrade = model.Term1MeanGrade;
                _Student.Term2MeanGrade = model.Term2MeanGrade;
                _Student.Term3MeanGrade = model.Term3MeanGrade;
                _Student.Eligible = model.Eligible;
                _Student.RequireTransport = model.RequireTransport;
                _Student.TransportChargeType = model.TransportChargeType;
                _Student.FeesPayPlan = model.FeesPayPlan;
                _Student.Boarder = model.Boarder;
                _Student.ResidenceHallRoomId = model.ResidenceHallRoomId;
                _Student.ResidenceId = model.ResidenceId;
                _Student.DoctorName = model.DoctorName;
                _Student.Ailments = model.Ailments;
                _Student.Foods = model.Foods;
                _Student.Allergies = model.Allergies;
                _Student.HostelName = model.HostelName;
                _Student.BedNo = model.BedNo;
                _Student.IsDeleted = false;

                Student returnedStudent = sc.CreateStudent(_Student);

                return RedirectToAction("StudentsList");

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

        public ActionResult EditStudent(int id)
        {
            StudentsComponent sc = new StudentsComponent();

            Student model = sc.GetStudent(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult EditStudent([Bind] Student model)
        {
            if (ModelState.IsValid)
            {
                StudentsComponent sc = new StudentsComponent();

                Student _Student = sc.GetStudent(model.Id);
                _Student.StudentSurName = Utils.ConvertFirstLetterToUpper(model.StudentSurName);
                _Student.StudentOtherNames = Utils.ConvertFirstLetterToUpper(model.StudentOtherNames);
                _Student.AdminNo = Utils.ConvertFirstLetterToUpper(model.AdminNo);
                _Student.SchoolId = model.SchoolId;
                _Student.Gender = model.Gender;
                _Student.Photo = model.Photo;
                _Student.ClassStreamId = model.ClassStreamId;
                _Student.DateOfBirth = model.DateOfBirth;
                _Student.Phone = model.Phone;
                if (model.Email != null)
                {
                    _Student.Email = model.Email.ToLower();
                }
                _Student.Homepage = model.Homepage;
                _Student.StudentAddress = Utils.ConvertFirstLetterToUpper(model.StudentAddress);
                _Student.AdmissionType = model.AdmissionType;
                _Student.Status = model.Status;
                _Student.KCPE = model.KCPE;
                _Student.KCSE = model.KCSE;
                _Student.AdmissionDate = model.AdmissionDate;
                _Student.AdmittedBy = model.AdmittedBy;
                _Student.Remarks = model.Remarks;
                _Student.Photo = model.Photo;
                _Student.LastModifiedTime = model.LastModifiedTime;
                _Student.GLAccountId = model.GLAccountId;
                _Student.CustomerId = model.CustomerId;
                _Student.FatherName = model.FatherName;
                _Student.FatherCellPhone = model.FatherCellPhone;
                _Student.FatherOfficePhone = model.FatherOfficePhone;
                _Student.FatherEmail = model.FatherEmail;
                _Student.MotherName = model.MotherName;
                _Student.MotherCellPhone = model.MotherCellPhone;
                _Student.MotherOfficePhone = model.MotherOfficePhone;
                _Student.MotherEmail = model.MotherEmail;
                _Student.GuardianName = model.GuardianName;
                _Student.GuardianCellPhone = model.GuardianCellPhone;
                _Student.GuardianOfficePhone = model.GuardianOfficePhone;
                _Student.GuardianEmail = model.GuardianEmail;
                _Student.PrevSchoolId = model.PrevSchoolId;
                _Student.PrevSchoolName = model.PrevSchoolName;
                _Student.PrevSchoolPhone = model.PrevSchoolPhone;
                _Student.PrevSchoolAddress = model.PrevSchoolAddress;
                _Student.ReasonForLeaving = model.ReasonForLeaving;
                _Student.ExtraCurricular1 = model.ExtraCurricular1;
                _Student.ExtraCurricular2 = model.ExtraCurricular2;
                _Student.ExtraCurricular3 = model.ExtraCurricular3;
                _Student.Term1MeanGrade = model.Term1MeanGrade;
                _Student.Term2MeanGrade = model.Term2MeanGrade;
                _Student.Term3MeanGrade = model.Term3MeanGrade;
                _Student.Eligible = model.Eligible;
                _Student.RequireTransport = model.RequireTransport;
                _Student.TransportChargeType = model.TransportChargeType;
                _Student.FeesPayPlan = model.FeesPayPlan;
                _Student.Boarder = model.Boarder;
                _Student.ResidenceHallRoomId = model.ResidenceHallRoomId;
                _Student.ResidenceId = model.ResidenceId;
                _Student.DoctorName = model.DoctorName;
                _Student.Ailments = model.Ailments;
                _Student.Foods = model.Foods;
                _Student.Allergies = model.Allergies;
                _Student.HostelName = model.HostelName;
                _Student.BedNo = model.BedNo;

                sc.UpdateStudent(_Student);

                return RedirectToAction("StudentsList");
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

        public ActionResult StudentDetails(int id)
        {
            StudentsComponent sc = new StudentsComponent();

            Student model = sc.GetStudent(id);

            return View(model);
        }

        public ActionResult DeleteStudent(int id, string description)
        {
            ConfirmDeleteModel model = new ConfirmDeleteModel();

            model.Id = id;
            model.Description = description;

            return View("ConfirmDeleteStudent", model);
        }

        [HttpPost]
        public ActionResult DeleteStudent([Bind] ConfirmDeleteModel model)
        {
            StudentsComponent sc = new StudentsComponent();

            sc.DeleteStudent(model.Id);

            return RedirectToAction("StudentsList");
        }





    }
}