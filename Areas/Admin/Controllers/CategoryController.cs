using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_2_woox_Travel.Context;
using Project_2_woox_Travel.Entities;

namespace Project_2_woox_Travel.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        TravelContext context=new TravelContext();

        [Authorize]
        public ActionResult CategoryList()
        {
            var values=context.Categorys.ToList();
            return View(values);
        }
    }
}