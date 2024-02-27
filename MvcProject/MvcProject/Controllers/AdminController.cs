using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbEntityEntities db = new DbEntityEntities();
        [Authorize]
        public ActionResult Index()
        {
            var admn = db.Admin.ToList();
            return View(admn);
        }
       
    }
}