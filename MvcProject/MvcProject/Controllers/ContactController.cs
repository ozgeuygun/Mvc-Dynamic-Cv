using MvcProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DbEntityEntities db = new DbEntityEntities();
        public ActionResult Index()
        {
            var con = db.CvContact.ToList();
            return View(con);
        }
      
      
    }
}