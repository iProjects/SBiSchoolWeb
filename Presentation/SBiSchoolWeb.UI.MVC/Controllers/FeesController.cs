using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBiSchoolWeb.Business;
using SBiSchoolWeb.Entities;

namespace SBiSchoolWeb.UI.MVC.Controllers
{
    [HandleError]
    [Authorize]
    public class FeesController : Controller
    {
        //[Authorize]
        public ActionResult GetAllFeeStructures()
        {
            FeesComponent fc = new FeesComponent();
            List<FeesStructure> FeesStructures = fc.GetAllFeeStructure();

            return View("FeeStructureListView", FeesStructures);
        }

        //[Authorize]
        public ActionResult GetAllAdmissions()
        {
            FeesComponent fc = new FeesComponent();
            List<Student> Students = fc.GetAllAdmissions();

            return View("AdmissionsListView", Students);
        }

        //[Authorize]
        public ActionResult GetAllFeeStructureAcademics()
        {
            FeesComponent fc = new FeesComponent();
            List<FeeStructureAcademic> FeeStructureAcademics = fc.GetAllFeeStructureAcademics();

            return View("FeeStructureAcademicListView", FeeStructureAcademics);
        }

        //[Authorize]
        public ActionResult GetAllFeeStructureOthers()
        {
            FeesComponent fc = new FeesComponent();
            List<FeeStructureOther> FeeStructureOthers = fc.GetAllFeeStructureOthers();

            return View("FeeStructureOtherListView", FeeStructureOthers);
        }



    }
}