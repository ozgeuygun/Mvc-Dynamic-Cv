using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class SocialController : Controller
    {
        // GET: Social
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            var scl = db.CvSocialMedia.ToList();
            return View(scl);
        }
        [HttpGet]
        public ActionResult AddSocial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocial(CvSocialMedia p1)
        {
            db.CvSocialMedia.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var del = db.CvSocialMedia.Find(Id);
            db.CvSocialMedia.Remove(del);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditSocial(int Id)
        {
            var edit = db.CvSocialMedia.Find(Id);
            return View("EditSocial", edit);
        }
        public ActionResult Edit(CvSocialMedia p1)
        {
            var edit2 = db.CvSocialMedia.Find(p1.Id);
            edit2.Sname = p1.Sname;
            edit2.Link = p1.Link;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}