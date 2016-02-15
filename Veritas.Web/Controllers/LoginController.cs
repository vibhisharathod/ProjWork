using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Veritas.Web.Models;

namespace Veritas.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(ViewAccount model, string returnUrl)
        {
            return RedirectToAction("Index", "Dashboard");
        }
    }
}