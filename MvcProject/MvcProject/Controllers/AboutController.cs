using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models.Entity;

namespace MvcProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbEntityEntities db = new DbEntityEntities();
       
        public ActionResult Index()
        {
            var about = db.CvAbout.ToList();
            return View(about);
        }
        public ActionResult EditAbout(int Id)
        {
            var edit = db.CvAbout.Find(Id);
            return View("EditAbout", edit);


        }
        public ActionResult Edit(CvAbout p1)
        {
            var edit2 = db.CvAbout.Find(p1.Id);
            edit2.Email = p1.Email;
            edit2.Description = p1.Description;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}