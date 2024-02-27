using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            var language = db.CvLanguage.ToList();
            return View(language);
        }
        [HttpGet]
        public ActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLanguage(CvLanguage p1)
        {
            db.CvLanguage.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var del = db.CvLanguage.Find(Id);
            db.CvLanguage.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditLanguage(int Id)
        {
            var edit = db.CvLanguage.Find(Id);
            return View("EditLanguage", edit);
        }
        public ActionResult Edit(CvLanguage p1)
        {
            var edit2 = db.CvLanguage.Find(p1.Id);
            edit2.LSkillName = p1.LSkillName;
            edit2.Llevel = p1.Llevel;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}