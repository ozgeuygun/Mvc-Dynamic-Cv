using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            var skill = db.CvSkills.ToList();
            return View(skill);
        }
        [HttpGet]
        public ActionResult AddSkills()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkills(CvSkills p1)
        {
            db.CvSkills.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var del = db.CvSkills.Find(Id);
            db.CvSkills.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditSkills(int Id)
        {
            var edit = db.CvSkills.Find(Id);
            return View("EditSkills", edit);
        }
        public ActionResult Edit(CvSkills p1)
        {
            var edit2 = db.CvSkills.Find(p1.Id);
            edit2.SkillName = p1.SkillName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}