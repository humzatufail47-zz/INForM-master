using System;
using System.Linq;
using System.Web.Mvc;
using INForM.Models;
using IN4MDatabase;
using System.Web.Security;

namespace INForM.Controllers
{
    public class LoginController : Controller
    {
        iN4MEntities _mySchema = new iN4MEntities();
        // GET: Login

        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        [ValidateAntiForgeryToken]
        public ActionResult Login_Post(Credentials credentials, string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(credentials);
            }
            var password = PasswordHashing.HashesPassword(credentials.Password);
            var vari = _mySchema.SpAuthenticateUser(credentials.Email, password).FirstOrDefault();
            if (Convert.ToBoolean(vari))
            {
                FormsAuthentication.SetAuthCookie(credentials.Email, false);
                return RedirectToLocal(ReturnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "No User Exist Against Email Id and Password");
                return View(credentials);
            }
        }

        [HttpGet]
        public ActionResult ForgotPass()
        {
            return View();
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Dashboard", "Home");
        }
    }
}