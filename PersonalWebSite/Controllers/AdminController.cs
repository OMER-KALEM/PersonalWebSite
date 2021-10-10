using PersonalWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var deger = context.MainScreens.ToList();
            return View(deger);
        }
        public ActionResult MainScreenBring(int id)
        {
            MainScreen mainScreenBring = context.MainScreens.Find(id);
            return View("MainScreenBring", mainScreenBring);
        }
        
        public ActionResult MainScreenUpdate(MainScreen mainScreen)
        {
            MainScreen mainScreenBring = context.MainScreens.Find(mainScreen.Id);
            mainScreenBring.Name = mainScreen.Name;
            mainScreenBring.ProfilPhoto = mainScreen.ProfilPhoto;
            mainScreenBring.JobTitle = mainScreen.JobTitle;
            mainScreenBring.Explanation = mainScreen.Explanation;
            mainScreenBring.Contact = mainScreen.Contact;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IconList()
        {
            var deger = context.Icons.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult AddIcon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIcon(Icon icon)
        {
            context.Icons.Add(icon);
            context.SaveChanges();
            return RedirectToAction("IconList");
        }

        public ActionResult GetIcon(int id)
        {
            var iconToUpdate = context.Icons.Find(id);
            return View("GetIcon", iconToUpdate);
        }

        public ActionResult UpdateIcon(Icon newicon)
        {
            Icon iconToUpdate = context.Icons.Find(newicon.Id);
            iconToUpdate.IconName = newicon.IconName;
            iconToUpdate.Link = newicon.Link;
            context.SaveChanges();
            return RedirectToAction("IconList");
        }
    }
}