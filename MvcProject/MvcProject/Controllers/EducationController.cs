using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DbEntityEntities db = new DbEntityEntities();
        
        public ActionResult Index()
        {
            var education = db.CvEducation.ToList();
            return View(education);
        }
        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddEducation(CvEducation p1)
        {
            db.CvEducation.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var del = db.CvEducation.Find(Id);
            db.CvEducation.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditEducation(int Id)
        {
            var edit = db.CvEducation.Find(Id);
            return View("EditEducation", edit);


        }
        public ActionResult Edit(CvEducation p1)
        {
            var edit2 = db.CvEducation.Find(p1.Id);
            edit2.University = p1.University;
            edit2.DegreeProg = p1.DegreeProg;
            edit2.Department = p1.Department;
            edit2.Date = p1.Date;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}