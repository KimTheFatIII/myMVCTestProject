using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult login(Models.UserInfo user)
        {
            return View();
        }
        public ActionResult regist()
        {
            return View();
        }
    }
}