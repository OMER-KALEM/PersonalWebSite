using PersonalWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class MainScreenController : Controller
    {
        // GET: MainScreen
        Context context = new Context();

        public ActionResult Index()
        {
            var deger = context.MainScreens.ToList();
            return View(deger);
        }
    }
}