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
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "For School Management";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Soft Books School";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts";

            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
        public ActionResult SiteMap()
        {
            ViewBag.Message = "Site Map";

            return View();
        } 
        public ActionResult Help()
        {
            ViewBag.Message = "Help";

            return View();
        } 
        















    }
}
