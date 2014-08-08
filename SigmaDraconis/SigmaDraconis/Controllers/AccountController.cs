using SigmaDraconisData.Models;
using SigmaDraconisData.Repositories;
using System;
using System.Collections.Generic;
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
                UserRepository userrepo = new UserRepository();
                userrepo.Add(user);
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (IsValid(user.Username, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login Data is incorrect");
                }
            }
            return View();
        }

        private bool IsValid(string username, string password)
        {
            bool isValid = false;

            UserRepository dur = new UserRepository();
            User myUser = dur.GetByName(username);

            if (myUser != null)
            {
                if (myUser.Password == password)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

    }
}
