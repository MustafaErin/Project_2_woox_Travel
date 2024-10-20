using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2_woox_Travel.Entities;
using Project_2_woox_Travel.Context;

namespace Project_2_woox_Travel.Controllers
{
    public class RegisterController : Controller
    {
        TravelContext context=new TravelContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return RedirectToAction("index","Login");
        }
    }
}