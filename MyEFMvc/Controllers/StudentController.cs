using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;

namespace MyEFMvc.Controllers
{
    public class StudentController : Controller
    {
        private StudentManager stuManager = new StudentManager();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<Students> stulist = new List<Students>();
            stulist = stuManager.GetStudentsListByclassId("1");
            int stucount = stuManager.GetStuCount("ClassId=1");
            var json = new {
                rows = stulist.ToArray(),
                total=stucount
            };
            return Json(json,JsonRequestBehavior.AllowGet);
        }
    }
}