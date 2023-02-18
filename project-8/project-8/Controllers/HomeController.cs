using project_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project_8.Controllers
{
    public class HomeController : Controller
    {

        private project8Entities db = new project8Entities();

        // GET: Default
        public ActionResult Index()
        {
            var majors = db.Majors;
            return View("Index", majors.ToList());
        }

        public ActionResult Search(string search)
        {
            ViewBag.Message = "This Major Is Not Found";
                ViewBag.Search = db.Majors.Where(p => p.Name.Contains(search)).Count();
                return View("Index", db.Majors.Where(p => p.Name.Contains(search)).ToList());
           
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Courses()
        {

            return View();
        }

        public ActionResult Events()
        {

            return View();
        }

        public ActionResult Blogs()
        {

            return View();
        }
        public ActionResult blogSingle()
        {

            return View();
        }
    }
}