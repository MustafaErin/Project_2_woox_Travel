using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2_woox_Travel.Context;
using Project_2_woox_Travel.Entities;
using System.Web.Security;


namespace Project_2_woox_Travel.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TravelContext context=new TravelContext();
        public ActionResult Index()
        {
            var a = Session["x"];
            var values = context.Admins.Where(x => x.UserName == a).FirstOrDefault();
            return View(values);
        }
    }
}