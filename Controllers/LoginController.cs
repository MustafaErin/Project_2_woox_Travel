using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2_woox_Travel.Context;
using Project_2_woox_Travel.Entities;
using System.Web.Security;

namespace Project_2_woox_Travel.Controllers
{
    public class LoginController : Controller
    {
       TravelContext context=new TravelContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);

            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName,false);
                Session["x"] = values.UserName;
                return RedirectToAction("index", "Profile",new { area = "admin" });

            }
            else
            {
                return View();
            }
            
        }
    }
}