using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var about = db.CvAbout.ToList();
            return View(about);
        }
        public ActionResult Education()
        {
            var education = db.CvEducation.ToList();
            return View(education);
        }
        public ActionResult Language()
        {
            var language = db.CvLanguage.ToList();
            return View(language);
        }
        public ActionResult Skills()
        {
            var skill = db.CvSkills.ToList();
            return View(skill);
        }

        public ActionResult Social()
        {
            var social = db.CvSocialMedia.ToList();
            return View(social);
        }
        public ActionResult Contact()
        {
            var contact = db.CvContact.ToList();
            return View(contact);
        }
    }
}