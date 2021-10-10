using PersonalWebSite.Models.Classes;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonalWebSite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Admin currentAdmin = context.Admins.FirstOrDefault(item => item.UserName == admin.UserName && item.Password == admin.Password);

            if (currentAdmin != null)
            {
                FormsAuthentication.SetAuthCookie(currentAdmin.UserName, false);
                Session["UserName"] = currentAdmin.UserName;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
    }
}