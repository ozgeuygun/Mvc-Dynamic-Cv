using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models.Entity;
namespace MvcProject.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin t)
        {
            var info = db.Admin.FirstOrDefault(x => x.userName == t.userName && x.pass == t.pass);
            if (info != null)
            {
                return RedirectToAction("Index", "About");
            }
            else
            {
                return View();
            }
        }
    }
}