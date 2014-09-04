using SigmaDraconis.Models;
using SigmaDraconisData.Models;
using SigmaDraconisData.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SigmaDraconis.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                bool valid = true;
                UserRepository userrepo = new UserRepository();
                if (!userrepo.NameIsUnique(user.Username))
                {
                    valid = false;
                    ModelState.AddModelError("Username", "Username is not unique");
                }
                if (!userrepo.EmailIsUnique(user.Email))
                {
                    valid = false;
                    ModelState.AddModelError("Email", "Email is not unique");
                }
                if (user.Password != user.PasswordAgain)
                {
                    valid = false;
                    ModelState.AddModelError("PasswordAgain", "Passwords don't match");
                }
                if (valid)
                {
                    user.Code = GetRandomString();
                    user.Active = 0;
                    userrepo.Add(user);
                    Mail mail = new Mail();
                    mail.RegisterMail(user);
                    return RedirectToAction("Index", "Home");
                }                
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                User myUser = IsValid(user.Email, user.Password);
                if (myUser != null)
                {
                    if (myUser.Active == 1)
                    {
                        FormsAuthentication.SetAuthCookie(myUser.Email, false);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Account is not activated yet.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect");
                }
            }
            return View();
        }

        public ActionResult Verify(string id)
        {
            UserRepository userrep = new UserRepository();
            User user = userrep.GetByCode(id);
            if (user != null)
            {
                user.Code = null;
                user.Active = 1;
                userrep.SaveChanges();
                ViewBag.verify = "Email verified, please login with your account to start using the website.";
                return View();
            }
            ViewBag.verify = "Operation failed, please try again.";
            return View();
        }

        private User IsValid(string email, string password)
        {
            UserRepository userrep = new UserRepository();
            User myUser = userrep.GetByEmail(email);

            if (myUser != null)
            {
                if (myUser.Password == password)
                {
                    return myUser;
                }
            }

            return null;
        }

        public static string GetRandomString()
        {
            string code = Path.GetRandomFileName();
            code = code.Replace(".", ""); // Remove period.
            return code;
        }

    }
}
